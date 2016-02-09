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
            PackageConfigReader confReader = new PackageConfigReader();
            List<PackageElement> confPackages=confReader.readConfig(@"G:\samples_nuget\Hangfire\src\Hangfire.Core\packages.config");
            bool update=checkUpdate(confPackages);                  
            //    InstallCommand installCmd = new InstallCommand();
            //    installCmd.Execute("EntityFramework", "6.1.3", @"<path to packages folder>");
            //     UpdateCommand updateCmd = new UpdateCommand();
            //    updateCmd.Execute("ncrontab", @"G:\samples_nuget\Hangfire\src\Hangfire.Core\Hangfire.Core.csproj", "3.1.0", @"G:\samples_nuget\Hangfire\packages");

            // Waits for any key to be pressed.
            Console.ReadKey();

        }

        private static bool checkUpdate(List<PackageElement> confPackages)
        {
            ListCommand listCmd = new ListCommand();
            foreach(PackageElement elem in confPackages){
                var repoResults = listCmd.Execute(elem.Packageid);
                foreach (var package in repoResults)
                {
                    //write to cache TODO
                    if (package.IsReleaseVersion())
                    {
                        var currVersion = package.Version;
                        Console.WriteLine(package.Id + package.Version);
                        if(elem.Version.ToNormalizedString().Equals(currVersion.ToNormalizedString()))
                        {
                            Console.WriteLine("match"+ package.Id + package.Version);
                        }
                        break;
                    }
                }
            }
            return true;
        }
    }
}
