using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Microsoft.TeamFoundation.TestManagement.Client;

/*
<ResultSummary outcome='Failed'>
<Counters total='19' executed='19' passed='18' error='0' failed='1' timeout='0' aborted='0' inconclusive='0' passedButRunAborted='0' notRunnable='0' notExecuted='0' disconnected='0' warning='0' completed='0' inProgress='0' pending='0'>
</ResultSummary>
*/
namespace nApiMonkey
{
    class TRXReader
    {
        public StringBuilder read(string trxfile)
        {
            //int count = 0;
            StringBuilder result = new StringBuilder();
            string testName="";
            XmlTextReader reader = new XmlTextReader(trxfile);
            try
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                            if (reader.Name.Equals("Counters"))
                            {
                                //Console.Write("<" + reader.Name);
                                while (reader.MoveToNextAttribute()) // Read the attributes.
                                    result.Append(reader.Name + "='" + reader.Value + " ");
                            }else if (reader.Name.Equals("UnitTestResult"))
                            {
                                while (reader.MoveToNextAttribute())
                                {
                                    if (reader.Name.Equals("testName"))
                                        testName=reader.Value;
                                    if(reader.Name.Equals("outcome") && (reader.Value.Equals("Failed") || reader.Value.Equals("Aborted")))
                                        result.Append("Test Name: "+testName+" Status: " + reader.Value + System.Environment.NewLine);
                                }
                            }
                            break;
                        case XmlNodeType.Text: //Display the text in each element.
                                           //   Console.WriteLine(reader.Value);
                            break;
                        case XmlNodeType.EndElement: //Display the end of the element.
                                             //        Console.Write("</" + reader.Name);
                                               //      Console.WriteLine(">");
                            break;
                    }

                }
            }
            catch (Exception e) { reader.Close(); }
            reader.Close();
            //
            Console.Write(result);
            Console.ReadKey();
            return result;
        }

    }
}
