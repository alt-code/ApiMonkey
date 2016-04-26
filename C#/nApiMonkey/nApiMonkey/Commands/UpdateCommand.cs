using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuGet;
using NuGet.VisualStudio;
using System.IO;
using NuGet.Common;

namespace nApiMonkey
{
    class UpdateCommand
    {
        public bool Execute(string packageid, string projectFile, SemanticVersion version, string packages)
        {
            try
            {
                System.Console.WriteLine("-------------------------------------");
                System.Console.WriteLine("Project File " + projectFile);
                System.Console.WriteLine("Package "+packageid);
                System.Console.WriteLine("Version "+version);
                
                IPackageRepository repo = PackageRepositoryFactory.Default.CreateRepository("https://packages.nuget.org/api/v2");
                var packagePathResolver = new DefaultPackagePathResolver(packages);
                var packagesFolderFileSystem = new PhysicalFileSystem(packages);
                var projectSystem = new MSBuildProjectSystem(projectFile);
                var localRepository = new LocalPackageRepository(packagePathResolver, packagesFolderFileSystem);
                var projectManager = new ProjectManager(repo, packagePathResolver, projectSystem, localRepository);
                
                projectManager.RemovePackageReference(packageid,true,false);
                projectManager.AddPackageReference(packageid, version, true, false);
                projectSystem.Save();

                string filename = packageid + "." + version;
                string[] s = Directory.GetFiles(packages+ @"\"+filename);
                if (s.IsEmpty()) { System.Console.WriteLine("empty"); }
                else
                {
                    var nupkgFile = new PhysicalFileSystem(s[0]);
                    ZipPackage z = new ZipPackage(s[0]);
                    z.ExtractContents(nupkgFile, packages + @"\" + filename);
                } 
                System.Console.WriteLine("Successfully updated");
                return true;
            }
            catch (Exception e)
            {
                System.Console.Write("failure");
                System.Console.Write(e.StackTrace);
                return false;
            }

        }
    }
}


