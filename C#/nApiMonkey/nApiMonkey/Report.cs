using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuGet;

namespace nApiMonkey
{
    //Write final tool report generated for a project
    class Report
    {
        const string BUILD_ERROR_FILE = "BuildErrors.log";
        const string BUILD_WARN_FILE = "BuildWarnings.log";
        //const string testfile = "tests.txt";
        string reportLocation;
        string reportName;
        int original_errors = 0;
        int original_warnings = 0;
        int original_passed_tests = 0;
        int original_failed_tests=0;
        StringBuilder testResultOrig;

        //writes result of updated dependencies
        //build result and tests result are consolidated and written here.
        public void writeBuildReport(string newprojectPath, string packageid, SemanticVersion version, StringBuilder testResult, bool success)
        {
            if (!success)
            {
                using (StreamWriter sw = File.AppendText(reportLocation + @"\" + reportName))
                {
                    sw.WriteLine("Package:" + packageid + " Version:" + version + " (Update Unsuccessful)");
                    sw.WriteLine("");
                }
            }
            else
            {
                var errorCount = File.ReadLines(newprojectPath + @"\" + BUILD_ERROR_FILE).Count();
                var warningCount = File.ReadLines(newprojectPath + @"\" + BUILD_WARN_FILE).Count();
                Console.WriteLine("Errors: " + errorCount + " Warnings: " + warningCount);

                //read test results file
                // testResult = readTestFile(newprojectPath + @"\" + testfile);
                int failed_tests = 0;//read from testResult and update this variable. currently not reading anything
                using (StreamWriter sw = File.AppendText(reportLocation + @"\" + reportName))
                {
                    if (errorCount == 0 && failed_tests <= original_failed_tests)
                        sw.WriteLine("Package:" + packageid + " Version:" + version + "  (Updated Successfully)");
                    else
                        sw.WriteLine("Package:" + packageid + " Version:" + version + " : (Fails with errors)");
                    sw.WriteLine("Errors: " + errorCount + " Warnings: " + warningCount);
                    sw.WriteLine("Test Results: ");
                    sw.WriteLine(testResult);
                    sw.WriteLine("");
                }
            }
        }

        internal void removeIfExists()
        {
            File.Delete(reportLocation + @"\" + reportName);
        }
        //This method writes the result of build execution and tests for original project (without any updated dependencies.)
        public void writeOriginalReport(string projectPath, TRXReader tr)
        {
           
            // testResult = readTestFile(projectPath + @"\" + testfile
            tr=readTestFileMSTest(tr, projectPath);
            original_errors = File.ReadLines(projectPath + @"\" + BUILD_ERROR_FILE).Count();
            original_warnings = File.ReadLines(projectPath + @"\" + BUILD_WARN_FILE).Count();
            original_passed_tests = tr.Passed_tests;
            original_failed_tests = tr.Failed_tests;
            Console.WriteLine("Errors: " + original_errors + " Warnings: " + original_warnings);

            using (StreamWriter sw = File.AppendText(reportLocation + @"\"+reportName))
            {
                sw.WriteLine("Original Project: ");
                sw.WriteLine("Errors: " + original_errors+" Warnings: " + original_warnings);
                sw.WriteLine("Test Results: ");
                sw.WriteLine(testResultOrig);
                sw.WriteLine("------------------------------------------------------------------");
                sw.WriteLine("Newer Versions: ");
            }
        }
        //reads contents of .trx file 
        TRXReader readTestFileMSTest(TRXReader tr, string solutionPath)
        {
            testResultOrig = tr.read(solutionPath + @"\TestResults.trx");
            return tr;
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
