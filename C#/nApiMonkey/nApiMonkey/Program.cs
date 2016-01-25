using nApiMonkey.Commands;
using NuGet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nApiMonkey
{
    class Program
    {
        static void Main(string[] args)
        {
            ListCommand listCmd = new ListCommand();
            var results = listCmd.Execute("nunit");
            foreach( var package in results )
            {
                Console.WriteLine(package.Id + package.Version);
            }

            // Waits for any key to be pressed.
            Console.ReadKey();
        }
    }
}
