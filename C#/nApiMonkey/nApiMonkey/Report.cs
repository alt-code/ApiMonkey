using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuGet;

namespace nApiMonkey
{
    class Report
    {
        const string BUILD_ERROR_FILE = "BuildErrors.log";
        const string BUILD_WARN_FILE = "BuildWarnings.log";
        string reportLocation;
        string reportName;
        public void writeBuildReport(string newprojectPath, string packageid, SemanticVersion version)
        {
            var errorCount = File.ReadLines(newprojectPath+ @"\"+BUILD_ERROR_FILE).Count();
            var warningCount = File.ReadLines(newprojectPath + @"\"+BUILD_WARN_FILE).Count();
            Console.WriteLine("Errors: " + errorCount + " Warnings: " + warningCount);

            using (StreamWriter sw = File.AppendText(reportLocation + @"\"+reportName))
            {
                    sw.WriteLine("Package: "+packageid+" Version: "+version);
                    sw.WriteLine("Errors: "+errorCount);
                    sw.WriteLine("Warnings: "+warningCount);
                    sw.WriteLine("");
            }
        }
        public void writeOriginalReport(string projectPath)
        {
            var errorCount = File.ReadLines(projectPath + @"\" + BUILD_ERROR_FILE).Count();
            var warningCount = File.ReadLines(projectPath + @"\" + BUILD_WARN_FILE).Count();
            Console.WriteLine("Errors: " + errorCount + " Warnings: " + warningCount);

            using (StreamWriter sw = File.AppendText(reportLocation + @"\"+reportName))
            {
                sw.WriteLine("Original Project: ");
                sw.WriteLine("Errors: " + errorCount);
                sw.WriteLine("Warnings: " + warningCount);
                sw.WriteLine("------------------------------------------------------------------");
                sw.WriteLine("Newer Versions: ");
            }
        }
        public string ReportLocation
        {
            get
            {
                return reportLocation;
            }

            set
            {
                reportLocation = value;
            }
        }
        public string ReportName
        {
            get
            {
                return reportName;
            }

            set
            {
                reportName = value;
            }
        }

    }
}
