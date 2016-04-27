using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Microsoft.TeamFoundation.TestManagement.Client;

/*
TRX Format:
<ResultSummary outcome='Failed'>
<Counters total='19' executed='19' passed='18' error='0' failed='1' timeout='0' aborted='0' inconclusive='0' passedButRunAborted='0' notRunnable='0' notExecuted='0' disconnected='0' warning='0' completed='0' inProgress='0' pending='0'>
</ResultSummary>
*/
namespace nApiMonkey
{
    //Result of executing mstest is stored in .trx file. Function to read results from this file are written in this class.
    class TRXReader
    {
        int failed_tests = 0;
        int passed_tests = 0;
        
        //Read trx file
        public StringBuilder read(string trxfile)
        {
            StringBuilder result = new StringBuilder();
            string testName = "";
            if (File.Exists(trxfile))
            {
                XmlTextReader reader = new XmlTextReader(trxfile);
                try
                {
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element: // The node is an element.
                                //List the overall results of tests run and update pass/fail counters
                                if (reader.Name.Equals("Counters"))
                                {
                                    while (reader.MoveToNextAttribute()) // Read the attributes.
                                    {
                                        result.Append(reader.Name + "='" + reader.Value + " ");
                                        if (reader.Name.Equals("failed"))
                                            failed_tests = Int32.Parse(reader.Value);
                                        else if(reader.Name.Equals("passed"))
                                            passed_tests = Int32.Parse(reader.Value);
                                    }
                                }
                                //List all the failed/aborted test names
                                else if (reader.Name.Equals("UnitTestResult"))
                                {
                                    while (reader.MoveToNextAttribute())
                                    {
                                        result.Append("Unittt");
                                        if (reader.Name.Equals("testName"))
                                            testName = reader.Value;
                                        if (reader.Name.Equals("outcome") && (reader.Value.Equals("Failed") || reader.Value.Equals("Aborted")))
                                            result.Append("Test Name: " + testName + " Status: " + reader.Value + System.Environment.NewLine);
                                    }
                                }
                                break;
                        }
                    }
                }
                catch (Exception e) { reader.Close(); }
                reader.Close();              
            }
        return result;
            
        }
        public int Failed_tests
        {
            get
            {
                return failed_tests;
            }

            set
            {
                failed_tests = value;
            }
        }

        public int Passed_tests
        {
            get
            {
                return passed_tests;
            }

            set
            {
                passed_tests = value;
            }
        }
    }
}
