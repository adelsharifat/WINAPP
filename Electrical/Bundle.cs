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
            return "QC Electrical";
        }

        //public override Version GetVersion()
        //{
        //    return new Version(VERSION);
        //}

        //public override bool IsDevelopment()
        //{
        //    return Config.IsDemo();
        //}

        //public override void Register()
        //{
        //    // Register acl definition
        //    Security.Acl.DefinedPermissions.Add(Acl.Get());
        //}
    }
}
