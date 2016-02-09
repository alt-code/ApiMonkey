using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuGet;
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
    }
}
