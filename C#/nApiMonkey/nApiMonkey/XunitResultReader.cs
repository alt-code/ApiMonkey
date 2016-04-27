using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nApiMonkey
{
    //Not Completely implemented yet.
    class XunitResultReader
    {
        int failed_tests = 0;
        int passed_tests = 0;

        public StringBuilder read(string filename)
        {
            StringBuilder testResult = new StringBuilder();
            bool flag = false;
            string line;
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(filename))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (flag)
                            testResult.Append(line);
                        // Read the stream to a string, and write the string to the console.
                        if (line.Contains("TEST EXECUTION SUMMARY"))
                            flag = true;
                            //TO BE IMPLEMENTED
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The test file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.Out.WriteLine(testResult);
            return testResult;
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
