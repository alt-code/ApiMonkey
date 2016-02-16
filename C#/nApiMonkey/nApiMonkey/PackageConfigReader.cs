using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuGet;
using System.IO;

namespace nApiMonkey
{
    class PackageConfigReader
    {
       public List<PackageElement> readConfig(string fileName)
        {
            List<PackageElement> element = new List<PackageElement> ();
            var file = new PackageReferenceFile(fileName);
            foreach (PackageReference packageReference in file.GetPackageReferences())
            {
                element.Add(new PackageElement(packageReference.Id, packageReference.Version));
                Console.WriteLine("Id={0}, Version={1}", packageReference.Id, packageReference.Version);
            }
            
            return element;
        }
        public void readAllConfigs(string root)
        {
              foreach (string fileName in Directory.EnumerateFiles(root, "packages.config", SearchOption.AllDirectories))
              {
                Console.WriteLine(fileName);
                //1readConfig(fileName);
              }
        }

        public bool writeToConfig(string fileName, string packageId, SemanticVersion oldversion, SemanticVersion newversion)
        {
            var file = new PackageReferenceFile(fileName);
            file.DeleteEntry(packageId, oldversion);
            file.AddEntry(packageId, newversion);
            return true;
        }
    }
}
