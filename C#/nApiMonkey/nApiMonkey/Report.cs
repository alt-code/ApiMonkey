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
        
        public void writeNewReport(string newprojectPath, string packageid, SemanticVersion version)
        {
            var errorCount = File.ReadLines(newprojectPath+ @"\"+BUILD_ERROR_FILE).Count();
            var warningCount = File.ReadLines(newprojectPath + @"\"+BUILD_WARN_FILE).Count();
            Console.WriteLine("Errors: " + errorCount + " Warnings: " + warningCount);

            //string path = txtFilePath.Text;
            using (StreamWriter sw = File.AppendText(reportLocation + @"\Report.md"))
            {
                
                    sw.WriteLine("Package: "+packageid+" Version: "+version);
                    sw.WriteLine("Errors: "+errorCount);
                    sw.WriteLine("Warnings: "+warningCount);
                
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

     
    }
}
