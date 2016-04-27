using nApiMonkey.Commands;
using NuGet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nApiMonkey
{
    class Program
    {
        static void Main(string[] args)
        {
            // set these variables before runing the tool
            string project_name = "";
            string project_path = @"";
            string sandbox_path = @"";
            string oldRootSol = @"";
            string testLocation = @"";

            //define script paths
            string git_script = @"G:\new_demo\ApiMonkey\C#\nApiMonkey\nApiMonkey\scripts\gitcmd.sh";
            string build_script = @"G:\new_demo\ApiMonkey\C#\nApiMonkey\nApiMonkey\scripts\build.bat";
            string copy_script = @"G:\new_demo\ApiMonkey\C#\nApiMonkey\nApiMonkey\scripts\script.bat";
            //end of variables 
            
            //Clone project from git. Can be skipped and done manually as well.
            System.Diagnostics.Process.Start(git_script, project_path).WaitForExit();

            Report repo = new Report();
            repo.ReportLocation = project_path;
            repo.ReportName = project_name + "Report.md";
            repo.removeIfExists();

            //Run msbuild and test executino on original project. and write the results to the report.
            System.Diagnostics.Process.Start(build_script, oldRootSol + " " + project_name + ".sln " + testLocation).WaitForExit();
            TRXReader tr = new TRXReader();
            repo.writeOriginalReport(oldRootSol, tr);

            PackageConfigReader reader = new PackageConfigReader();
            //Read the entire project for packages.config files and build a dictionary with packages and the projects list which reference them.
            List<string> packageFilePaths = reader.readAllConfigs(oldRootSol);
            Dictionary<PackageElement, List<string>> dictionary = reader.readConfig(packageFilePaths, oldRootSol);
            List<PackageElement> oldlist = new List<PackageElement>(dictionary.Keys);
            //Check if newer versions are available for the packages.
            List<PackageElement> update = checkUpdate(oldlist);
            StringBuilder testResult = new StringBuilder();
            if (update == null) Console.Write("No updates found");
            else
            {
                //Go through all packages where update is available and create sandboxes for each of them
                foreach (PackageElement e in update)
                {
                    bool success=true;
                    List<string> paths = dictionary[e];
                    string newRootSol = sandbox_path + @"\" + project_name + @"_" + e.Packageid.Substring(0, e.Packageid.Length / 2 + 1) + e.Version.ToNormalizedString();
                    //string newProjectPath = newRootSol + @"\" + project_name;
                    Directory.CreateDirectory(newRootSol);
                    System.Diagnostics.Process.Start(copy_script, oldRootSol + " " + newRootSol + " " + project_name + ".sln ").WaitForExit();
                    //Update references to the new version for all projects which refer to it
                    foreach (string projectPath in paths)
                    {
                        Console.WriteLine("Updating " + projectPath);
                        PackageConfigReader newConfReader = new PackageConfigReader();
                        string newPathToPackages = newRootSol + projectPath + @"packages.config";
                        string newProjectPath = newRootSol + projectPath;
                        string project = Directory.EnumerateFiles(newProjectPath, "*.csproj?").First();
                        UpdateCommand updateCmd = new UpdateCommand();
                        bool update_success=updateCmd.Execute(e.Packageid, project, e.Version, newRootSol + @"\packages");
                        if (update_success == false)
                        {
                            success = false;
                            break;
                        }
                            newConfReader.writeToConfig(newPathToPackages, e.Packageid, e.Version);
                    }
                    if (success)
                    {
                        //If uodate is successful, run the build and write results to final report.
                        System.Diagnostics.Process.Start(@"G:\new_demo\ApiMonkey\C#\nApiMonkey\nApiMonkey\scripts\build.bat", newRootSol + " " + project_name + ".sln " + testLocation).WaitForExit();
                        tr = new TRXReader();
                        testResult = tr.read(newRootSol + @"\testResults.trx");
                        repo.writeBuildReport(newRootSol, e.Packageid, e.Version, testResult,true);
                    }
                    else
                        repo.writeBuildReport(newRootSol, e.Packageid, e.Version, testResult, false);
                }

            }

            Console.ReadKey();
        }
        static string PACKAGE_OLD;
        //check if updates are available
        private static List<PackageElement> checkUpdate(List<PackageElement> confPackages)
        {
            bool single = false;
            ListCommand listCmd = new ListCommand();
            List<PackageElement> newVersions = new List<PackageElement>();
            foreach (PackageElement confelem in confPackages)
            {
                    //write to cache TODO
                    string packageVersion = confelem.Version.ToNormalizedString();
                    string[] pv = packageVersion.Split('.');
                    var repoResults = listCmd.Execute(confelem.Packageid);
                    Console.WriteLine("Getting all versions of package " + confelem.Packageid);
                    foreach (var rpackage in repoResults)
                    {
                        if (rpackage.IsReleaseVersion())
                        {
                            string currRepoVersion = rpackage.Version.ToNormalizedString();
                            string[] repov = currRepoVersion.Split('.');
                            if (float.Parse(pv[0]) < float.Parse(repov[0]))//major version
                            {
                                //Console.WriteLine("updatemajor " + rpackage.Id + currRepoVersion);
                                newVersions.Add(new PackageElement(rpackage.Id, NuGet.SemanticVersion.Parse(currRepoVersion), NuGet.SemanticVersion.Parse(packageVersion)));
                                single = true;
                                
                            }
                            else if (float.Parse(pv[0]) == float.Parse(repov[0]))
                            {
                                if ( float.Parse(pv[1]) < float.Parse(repov[1]))
                                {
                                    //  Console.WriteLine("updateminor " + rpackage.Id + currRepoVersion);
                                    newVersions.Add(new PackageElement(rpackage.Id, NuGet.SemanticVersion.Parse(currRepoVersion), NuGet.SemanticVersion.Parse(packageVersion)));
                                    single = true;

                                }
                                else if (float.Parse(pv[1]) == float.Parse(repov[1]))
                                {
                                     if (float.Parse(pv[2]) < float.Parse(repov[2]))
                                     {
                                         Console.WriteLine("updatepatch " + rpackage.Id + currRepoVersion);
                                         newVersions.Add(new PackageElement(rpackage.Id, NuGet.SemanticVersion.Parse(currRepoVersion), NuGet.SemanticVersion.Parse(packageVersion)));
                                         single = true;
                                     }
                                     
                                }
                            }

                        }

                    }
                
            }
            if (single) return newVersions;
            return null;
        }

    }
}

/*          
    Example setting variables for repo: https://github.com/HangfireIO/Hangfire
            string project_name = "Hangfire";
            string project_path = @"G:\samples_proj";
            string sandbox_path = @"G:\nuget_sandbox";
            string oldRootSol = @"G:\samples_proj\Hangfire";
            string testLocation = @"tests\Hangfire.Core.Tests\bin\Debug\Hangfire.Core.Tests.dll tests\Hangfire.SqlServer.RabbitMq.Tests\bin\Debug\Hangfire.SqlServer.RabbitMq.Tests.dll";

*/
