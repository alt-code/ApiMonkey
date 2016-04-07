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
        //optional version for storing oler versions from config file.
        private SemanticVersion old_version;
        public PackageElement(string id, SemanticVersion version1)
        {
            this.Packageid = id;
            this.Version = version1;
        }
        public PackageElement(string id, SemanticVersion version1, SemanticVersion oversion)
        {
            this.Packageid = id;
            this.Version = version1;
            this.old_version = oversion;
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
        public SemanticVersion OldVersion
        {
            get
            {
                return old_version;
            }

            set
            {
                old_version = value;
            }
        }

        //Package elements are considered as equal if they have same package names. Versions can be different.
        public override bool Equals(object obj)
            {
                PackageElement item = obj as PackageElement;

            return (item.Packageid == this.Packageid);// && item.Version == this.Version);
            }

            public override int GetHashCode()
            {
                return Packageid.GetHashCode();
            
            }
    }
}
