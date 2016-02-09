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
using NuGet.Common;

namespace nApiMonkey
{
        class UpdateCommand
        {
        public void Execute(string packageid,string targetFolder, String version, string packages)
        {
            try
            {
            IPackageRepository repo = PackageRepositoryFactory.Default.CreateRepository("https://packages.nuget.org/api/v2");            
            var packagePathResolver = new DefaultPackagePathResolver(packages);
            var packagesFolderFileSystem = new PhysicalFileSystem(packages);
            var projectSystem = new MSBuildProjectSystem(targetFolder);
            var localRepository = new LocalPackageRepository(packagePathResolver, packagesFolderFileSystem);
            var projectManager = new ProjectManager(repo, packagePathResolver, projectSystem, localRepository);
            
           // projectManager.PackageReferenceAdded += (sender, args) => args.Package.GetLibFiles().Each(file => SaveAssemblyFile(args.InstallPath, file));
           // projectManager.AddPackageReference(packageid);
            projectManager.UpdatePackageReference(packageid, SemanticVersion.Parse(version), false, false);
            projectSystem.Save();
               
            System.Console.Write("Success");
            } catch(Exception e)
            {
                System.Console.Write("failure");
                System.Console.Write(e.StackTrace);
            }
           
        }
        }
}

