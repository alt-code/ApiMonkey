using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuGet;

namespace nApiMonkey
{
    class PackageElement
    {
        //private string id;
        string packageid;
        //string version;
        private SemanticVersion version;

        public PackageElement(string id, SemanticVersion version1)
        {
            this.Packageid = id;
            this.Version = version1;
        }

        public string Packageid
        {
            get
            {
                return packageid;
            }

            set
            {
                packageid = value;
            }
        }

        public SemanticVersion Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value;
            }
        }
    }
}
