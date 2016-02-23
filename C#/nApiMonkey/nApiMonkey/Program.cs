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
            string project_name = "";
            string sandbox_path = "";
            PackageConfigReader oldConfReader = new PackageConfigReader();
            //clone from repo
            string oldRootSol = @"";
            string oldProjectPath = @"";
            string oldPathToPackages = oldProjectPath+@"\packages.config";
            List<PackageElement> confPackages=oldConfReader.readConfig(oldPathToPackages);
            List<PackageElement> update =checkUpdate(confPackages);
            if (update == null) Console.Write("nahi");
            else
            {
                foreach (PackageElement e in update)
                {
                    DirectoryInfo d= new DirectoryInfo(Directory.GetCurrentDirectory());
                    PackageConfigReader newConfReader = new PackageConfigReader();
                    string newRootSol = sandbox_path+@"\"+project_name+@"_"+e.Packageid.Substring(0,4)+ e.Version.ToNormalizedString();
                    Console.WriteLine("new root sol " + newRootSol);
                    string newProjectPath = newRootSol+@"\src\Hangfire.Core";
                    Directory.CreateDirectory(newRootSol);
                    System.Diagnostics.Process.Start(@"G:\Demo\ApiMonkey\C#\nApiMonkey\nApiMonkey\scripts\script.bat", oldRootSol+" "+ newRootSol).WaitForExit();
                    string newPathToPackages = newProjectPath+@"\packages.config";
                    Console.WriteLine(e.Packageid + " " + e.Version);
                    newConfReader.writeToConfig(newPathToPackages, e.Packageid, SemanticVersion.Parse(PACKAGE_OLD), e.Version);
                    UpdateCommand updateCmd = new UpdateCommand();
                    updateCmd.Execute(e.Packageid, newProjectPath+@"\Hangfire.Core.csproj", e.Version, newRootSol + @"\packages");
                    System.Diagnostics.Process.Start(@"G:\Demo\ApiMonkey\C#\nApiMonkey\nApiMonkey\scripts\build.bat", newProjectPath + @"\Hangfire.Core.csproj").WaitForExit();
                    //break;  //currently updating to only single version
                    
                }

            }
            Console.ReadKey();

        }
       static string PACKAGE_OLD;
        private static List<PackageElement> checkUpdate(List<PackageElement> confPackages)
        {
            bool single = false;
            ListCommand listCmd = new ListCommand();
            List<PackageElement> newVersions=new List<PackageElement>();
            foreach (PackageElement confelem in confPackages){
                //write to cache TODO
                string packageVersion = confelem.Version.ToNormalizedString();
                string[] pv = packageVersion.Split('.');
                var repoResults = listCmd.Execute(confelem.Packageid);
                foreach (var rpackage in repoResults)
                {
                    if (rpackage.IsReleaseVersion())
                    {
                      // Console.WriteLine(rpackage.Id + rpackage.Version);
                        string currRepoVersion = rpackage.Version.ToNormalizedString();
                        PACKAGE_OLD = currRepoVersion;
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
                                    Console.WriteLine("updatepatch " + rpackage.Id + currRepoVersion);
                                    newVersions.Add(new PackageElement(rpackage.Id, NuGet.SemanticVersion.Parse(currRepoVersion)));
                                    single = true;
                                }
                            }
                        }
                        
                    }
                }
                if(single) return newVersions;
            }
            return null;
        }
        
    }
}
