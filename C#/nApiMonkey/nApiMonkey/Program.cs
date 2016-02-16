using nApiMonkey.Commands;
using NuGet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nApiMonkey
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootSol = @"";//change C:\Users\Tanvi\Documents\Visual Studio 2015\Projects\WindowsFormsApplication2
            string projectPath = @""//change C:\Users\Tanvi\Documents\Visual Studio 2015\Projects\WindowsFormsApplication2\WindowsFormsApplication2
            PackageConfigReader confReader = new PackageConfigReader();
            string pathToPackages = projectPath+@"\packages.config";
            List<PackageElement> confPackages=confReader.readConfig(pathToPackages);
            List<PackageElement> update =checkUpdate(confPackages);
            if (update == null) Console.Write("nahi");
            else
            {             
                foreach(PackageElement e in update)
                {
                    Console.Write(e.Packageid + " " + e.Version);
                    confReader.writeToConfig(pathToPackages, e.Packageid, SemanticVersion.Parse("6.0.0"), e.Version);
                    UpdateCommand updateCmd = new UpdateCommand();
                    updateCmd.Execute(e.Packageid, projectPath+@"\WindowsFormsApplication2.csproj", e.Version, rootSol+@"\packages");
                    break;  //currently updating to only single version
                }

            }
           
            //  System.Diagnostics.Process.Start(@"G:\Demo\ApiMonkey\C#\nApiMonkey\nApiMonkey\script.sh");
            //    InstallCommand installCmd = new InstallCommand();
            //    installCmd.Execute("EntityFramework", "6.1.3", @"<path to packages folder>");
            // Waits for any key to be pressed.
            Console.ReadKey();

        }

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
