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
//using NuGet.VisualStudio;
using NuGet.Common;

namespace nApiMonkey
{
        class UpdateCommand
        {
        public void Execute(string packageid,string targetFolder)
        {
            IPackageRepository repo = PackageRepositoryFactory.Default.CreateRepository("https://packages.nuget.org/api/v2");       
            var packagePathResolver = new DefaultPackagePathResolver(targetFolder);
            var packagesFolderFileSystem = new PhysicalFileSystem("");
            var ms = new MSBuildProjectSystem("");
            var localRepository = new LocalPackageRepository(packagePathResolver, packagesFolderFileSystem);
            var projectManager = new ProjectManager(repo, packagePathResolver, ms,localRepository);
            
            projectManager.PackageReferenceAdded += (sender, args) => args.Package.GetLibFiles().Each(file => SaveAssemblyFile(args.InstallPath, file));
            projectManager.AddPackageReference(packageid);
            projectSystem.Save();

            Assembly.GetExecutingAssembly().Location.ParentDirectory().ParentDirectory().ParentDirectory().AppendPath("NuGetSample.csproj");
            try { 
               // manager.UpdatePackage(packageid, true, false);
                System.Console.Write("Success");
            } catch(Exception e)
            {
                System.Console.Write("failure");
                System.Console.Write(e.StackTrace);
            }
            
        }

        //PackageManager manager = new PackageManager(repo, path);
        //string webRepositoryDirectory = WebProjectManager.GetWebRepositoryDirectory();
        //IPackagePathResolver pathResolver = new DefaultPackagePathResolver(webRepositoryDirectory);
        //IPackageRepository localRepository = PackageRepositoryFactory.Default.CreateRepository(webRepositoryDirectory);
        //var projectManager = new ProjectManager(repo, pathResolver, project, localRepository);

    }
}

