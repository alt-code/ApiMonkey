using System;
using NuGet;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nApiMonkey.Commands
{
    class InstallCommand
    {
        public void Execute(string packageid, string version, string path)
        {
            IPackageRepository repo = PackageRepositoryFactory.Default.CreateRepository("https://packages.nuget.org/api/v2");
            PackageManager manager = new PackageManager(repo, path);
            try { 
                manager.InstallPackage(packageid, SemanticVersion.Parse(version));
                Console.Write("Success");
            } catch(Exception e)
            {
                Console.Write("failure");
                Console.Write(e.StackTrace);
            }
        }
    }
}
