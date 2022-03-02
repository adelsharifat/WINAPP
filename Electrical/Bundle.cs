using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrical
{
    public class Bundle:CommonClass.IBundle
    {

        public const string SCHEMA = "EL";
        public const string APPNAME = "Electrical";
        public const string VERSION = "1.0.0";
        public override string GetCode()
        {
            return SCHEMA;
        }

        public override string GetName()
        {
            return APPNAME;
        }

        public override Version GetVersion()
        {
            return new Version(VERSION);
        }

        public override bool IsDevelopment()
        {
            return false;
        }
    }
}
