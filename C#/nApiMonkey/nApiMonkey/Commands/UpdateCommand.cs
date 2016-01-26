using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuGet;

namespace nApiMonkey
{
    class UpdateCommand
    {
        public void Execute(string packageid,string path)
        {
            IPackageRepository repo = PackageRepositoryFactory.Default.CreateRepository("https://packages.nuget.org/api/v2");
            PackageManager manager = new PackageManager(repo, path);
            try { 
                manager.UpdatePackage(packageid, false, false);
                Console.Write("Success");
            } catch(Exception e)
            {
                Console.Write("failure");
                Console.Write(e.StackTrace);
            }
            
        }
    }
}
