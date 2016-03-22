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
            string project_name = "Hangfire";
            string project_path = @"G:\samples\";
            string sandbox_path = @"G:\nuget_sandbox_new";

            string oldRootSol = @"G:\samples\Hangfire";
            string oldProjectPath = @"G:\samples_nuget\Hangfire\" + project_name;
                        //cloning a repo
                        //string repo = "";
                     //    System.Diagnostics.Process.Start(@"G:\new_demo\ApiMonkey\C#\nApiMonkey\nApiMonkey\scripts\gitcmd.sh", oldRootSol).WaitForExit();

            Report repo = new Report();
            repo.ReportLocation = project_path;
            repo.ReportName = project_name + "Report.md";
            repo.removeIfExists();

            System.Diagnostics.Process.Start(@"G:\new_demo\ApiMonkey\C#\nApiMonkey\nApiMonkey\scripts\build.bat", oldRootSol+" "+ project_name + ".sln").WaitForExit();
            repo.writeOriginalReport(oldRootSol);

            PackageConfigReader reader = new PackageConfigReader();
            List<string> packageFilePaths=reader.readAllConfigs(@"G:\samples\Hangfire");
            Dictionary<PackageElement, List<string>> dictionary= reader.readConfig(packageFilePaths,oldRootSol);

            // PackageConfigReader oldConfReader = new PackageConfigReader();
            // string oldPathToPackages = oldProjectPath + @"\packages.config";
            // List<PackageElement> confPackages = oldConfReader.readConfig(oldPathToPackages);
            List<PackageElement> oldlist = new List<PackageElement>(dictionary.Keys);
            List<PackageElement> update = checkUpdate(oldlist);
            
            if (update == null) Console.Write("nahi");
            else
            {
                foreach (PackageElement e in update)
                {
                    List<string> paths=dictionary[e];
                    string newRootSol = sandbox_path + @"\" + project_name + @"_" + e.Packageid.Substring(0, e.Packageid.Length/2) + e.Version.ToNormalizedString();
                    
                    //string newProjectPath = newRootSol + @"\" + project_name;
                    Directory.CreateDirectory(newRootSol);
                    System.Diagnostics.Process.Start(@"G:\new_demo\ApiMonkey\C#\nApiMonkey\nApiMonkey\scripts\script.bat", oldRootSol + " " + newRootSol).WaitForExit();
                    foreach (string projectPath in paths)
                    {
                        PackageConfigReader newConfReader = new PackageConfigReader();
                        string newPathToPackages = newRootSol + projectPath + @"packages.config";
                        string newProjectPath = newRootSol + projectPath;
                        Console.WriteLine("new project path" + newProjectPath);
                        Console.WriteLine(e.Packageid + " old " + SemanticVersion.Parse(PACKAGE_OLD) + " new " + e.Version);
                        newConfReader.writeToConfig(newPathToPackages, e.Packageid, SemanticVersion.Parse(PACKAGE_OLD), e.Version);
                        string project=Directory.EnumerateFiles(newProjectPath, "*.csproj").First();
                        UpdateCommand updateCmd = new UpdateCommand();
                        updateCmd.Execute(e.Packageid, project, e.Version, newRootSol + @"\packages");
                    }
                    //Console.ReadKey();
                    System.Diagnostics.Process.Start(@"G:\new_demo\ApiMonkey\C#\nApiMonkey\nApiMonkey\scripts\build.bat", newRootSol + " " + project_name + ".sln").WaitForExit();

                    //Read build output and generate a report
                    repo.writeBuildReport(newRootSol, e.Packageid, e.Version);
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
                //write to cache TODO
                string packageVersion = confelem.Version.ToNormalizedString();
                string[] pv = packageVersion.Split('.');
                var repoResults = listCmd.Execute(confelem.Packageid);
                PACKAGE_OLD = packageVersion;
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
                            Console.WriteLine("updatemajor " + rpackage.Id + currRepoVersion);
                            newVersions.Add(new PackageElement(rpackage.Id, NuGet.SemanticVersion.Parse(currRepoVersion)));
                            single = true;
                        }
                        else if (float.Parse(pv[0]) == float.Parse(repov[0]))
                        {
                            if (float.Parse(pv[1]) < float.Parse(repov[1]))
                            {
                                Console.WriteLine("updateminor " + rpackage.Id + currRepoVersion);
                                newVersions.Add(new PackageElement(rpackage.Id, NuGet.SemanticVersion.Parse(currRepoVersion)));
                                single = true;
                            }
                            else if (float.Parse(pv[1]) == float.Parse(repov[1]))
                            {
                                if (float.Parse(pv[2]) < float.Parse(repov[2]))
                                {
                                   // Console.WriteLine("updatepatch " + rpackage.Id + currRepoVersion);
                                   // newVersions.Add(new PackageElement(rpackage.Id, NuGet.SemanticVersion.Parse(currRepoVersion)));
                                   // single = true;
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
