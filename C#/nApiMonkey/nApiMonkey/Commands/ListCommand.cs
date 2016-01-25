using NuGet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nApiMonkey.Commands
{
    class ListCommand
    {
        public IList<IPackage> Execute(string packageId)
        {
            IPackageRepository repo = PackageRepositoryFactory.Default.CreateRepository("https://packages.nuget.org/api/v2");
            return repo.FindPackagesById(packageId).ToList();
        }
    }
}
