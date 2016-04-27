using nApiMonkey.Commands;
using NuGet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*          
            string project_name = "YelpSharp";
            string project_path = @"G:\samples_nuget";
            string sandbox_path = @"G:\nuget_sandbox";
            string oldRootSol = @"G:\samples_nuget\YelpSharp";
            string testLocation = @"YelpSharpTests\bin\Debug\YelpSharpTests.dll";
            string project_name = "Bonobo.Git.Server";
            string project_path = @"G:\samples_proj";
            string sandbox_path = @"G:\nuget_sandbox_new";
            string oldRootSol = @"G:\samples_proj\Bonobo-Git-Server";
            string testLocation = @"Bonobo.Git.Server.Test\bin\Debug\Bonobo.Git.Server.Test.dll";
            string project_name = "Hangfire";
            string project_path = @"G:\samples_proj";
            string sandbox_path = @"G:\nuget_sandbox";
            string oldRootSol = @"G:\samples_proj\Hangfire";
            string testLocation = @"tests\Hangfire.Core.Tests\bin\Debug\Hangfire.Core.Tests.dll tests\Hangfire.SqlServer.RabbitMq.Tests\bin\Debug\Hangfire.SqlServer.RabbitMq.Tests.dll";

    */
namespace nApiMonkey
{
    class Program
    {
        static void Main(string[] args)
        {
            // set these variables before runing the tool
            string project_name = "Microsoft.Bot.Builder";
            string project_path = @"G:\samples_proj";
            string sandbox_path = @"G:\nuget_sandbox_new\BotBuilder_new";
            string oldRootSol = @"G:\samples_proj\BotBuilder\CSharp";
            string testLocation = @"Tests\Microsoft.Bot.Builder.Tests\bin\Debug\Microsoft.Bot.Builder.Tests.dll";

            //define script paths
            string git_script = @"G:\new_demo\ApiMonkey\C#\nApiMonkey\nApiMonkey\scripts\gitcmd.sh";
            string build_script = @"G:\new_demo\ApiMonkey\C#\nApiMonkey\nApiMonkey\scripts\build.bat";
            string copy_script = @"G:\new_demo\ApiMonkey\C#\nApiMonkey\nApiMonkey\scripts\script.bat";
            //end of variables 

            //   System.Diagnostics.Process.Start(git_script, project_path).WaitForExit();

            Report repo = new Report();
            repo.ReportLocation = project_path;
            repo.ReportName = project_name + "Report.md";
            repo.removeIfExists();

        //    System.Diagnostics.Process.Start(build_scipt, oldRootSol + " " + project_name + ".sln " + testLocation).WaitForExit();
            TRXReader tr = new TRXReader();
            repo.writeOriginalReport(oldRootSol, tr);

            PackageConfigReader reader = new PackageConfigReader();

            List<string> packageFilePaths = reader.readAllConfigs(oldRootSol);
            Dictionary<PackageElement, List<string>> dictionary = reader.readConfig(packageFilePaths, oldRootSol);

            // PackageConfigReader oldConfReader = new PackageConfigReader();
            // string oldPathToPackages = oldProjectPath + @"\packages.config";
            // List<PackageElement> confPackages = oldConfReader.readConfig(oldPathToPackages);
            List<PackageElement> oldlist = new List<PackageElement>(dictionary.Keys);
            List<PackageElement> update = checkUpdate(oldlist);
            StringBuilder testResult = new StringBuilder();
            if (update == null) Console.Write("nahi");
            else
            {
                foreach (PackageElement e in update)
                {
                    bool success=true;
                    List<string> paths = dictionary[e];
                    string newRootSol = sandbox_path + @"\" + project_name + @"_" + e.Packageid.Substring(0, e.Packageid.Length / 2 + 1) + e.Version.ToNormalizedString();
                    //string newProjectPath = newRootSol + @"\" + project_name;
                    Directory.CreateDirectory(newRootSol);
                    System.Diagnostics.Process.Start(copy_script, oldRootSol + " " + newRootSol + " " + project_name + ".sln ").WaitForExit();
                    foreach (string projectPath in paths)
                    {
                        Console.WriteLine("Updating " + projectPath);
                        PackageConfigReader newConfReader = new PackageConfigReader();
                        string newPathToPackages = newRootSol + projectPath + @"packages.config";
                        string newProjectPath = newRootSol + projectPath;
                        //  Console.WriteLine("new project path" + newProjectPath);
                        //Console.WriteLine(e.Packageid + " old " + e.OldVersion + " new " + e.Version);
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
                        System.Diagnostics.Process.Start(@"G:\new_demo\ApiMonkey\C#\nApiMonkey\nApiMonkey\scripts\build.bat", newRootSol + " " + project_name + ".sln " + testLocation).WaitForExit();
                        tr = new TRXReader();
                        //Read build output and generate a report
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
        private static List<PackageElement> checkUpdate(List<PackageElement> confPackages)
        {
            bool single = false;
            
            ListCommand listCmd = new ListCommand();
            List<PackageElement> newVersions = new List<PackageElement>();
            foreach (PackageElement confelem in confPackages)
            {
               // if (confelem.Packageid.Equals("xunit"))                {//|| confelem.Packageid.Equals("RabbitMQ.Client")){
                    //write to cache TODO
                    string packageVersion = confelem.Version.ToNormalizedString();
                    string[] pv = packageVersion.Split('.');
                    var repoResults = listCmd.Execute(confelem.Packageid);
                    //  PACKAGE_OLD = packageVersion;
                    Console.WriteLine("Getting all versions of package " + confelem.Packageid);
                    foreach (var rpackage in repoResults)
                    {
                        if (rpackage.IsReleaseVersion())
                        {
                            // Console.WriteLine(rpackage.Id + rpackage.Version);
                            string currRepoVersion = rpackage.Version.ToNormalizedString();
                            // PACKAGE_OLD = currRepoVersion;
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
