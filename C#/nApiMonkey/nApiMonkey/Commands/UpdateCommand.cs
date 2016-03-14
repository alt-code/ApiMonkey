using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuGet;
//using Microsoft.Web.Infrastructure;
//using System.Web.WebPages;
//using Microsoft.VisualStudio;
//using MsBuildProject = Microsoft.Build.Evaluation.Project;
//using Project1 = EnvDTE.Project;
using NuGet.VisualStudio;
using System.IO;
using NuGet.Common;

namespace nApiMonkey
{
    class UpdateCommand
    {
        public void Execute(string packageid, string projectFile, SemanticVersion version, string packages)
        {
            try
            {
                IPackageRepository repo = PackageRepositoryFactory.Default.CreateRepository("https://packages.nuget.org/api/v2");
                var packagePathResolver = new DefaultPackagePathResolver(packages);
                var packagesFolderFileSystem = new PhysicalFileSystem(packages);
                var projectSystem = new MSBuildProjectSystem(projectFile);
                var localRepository = new LocalPackageRepository(packagePathResolver, packagesFolderFileSystem);
                var projectManager = new ProjectManager(repo, packagePathResolver, projectSystem, localRepository);

                projectManager.UpdatePackageReference(packageid, version, false, false);
                projectSystem.Save();

                System.Console.WriteLine("Updating "+packages);
                string filename = packageid + "." + version;
                string[] s = Directory.GetFiles(packages+ @"\"+filename);
                if (s.IsEmpty()) { System.Console.WriteLine("empty"); }
                else
                {
                    System.Console.WriteLine("nupkg file: " + s.First());
                    var nupkgFile = new PhysicalFileSystem(s[0]);
                    ZipPackage z = new ZipPackage(s[0]);
                    z.ExtractContents(nupkgFile, packages + @"\" + filename);
                }
                System.Console.Write("Successfully updated");
            }
            catch (Exception e)
            {
                System.Console.Write("failure");
                System.Console.Write(e.StackTrace);
            }

        }
    }
}


