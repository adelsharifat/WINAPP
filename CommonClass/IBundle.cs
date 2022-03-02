using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClass
{
    public class IBundle
    {
        public virtual string GetCode()
        {
            return String.Empty;
        }

        public virtual string GetName()
        {
            return String.Empty;
        }

        public virtual Version GetVersion()
        {
            return new System.Version();
        }

        public virtual bool IsDevelopment()
        {
            return false;
        }

        public virtual void Register()
        {
            // Register acl definition
            //Security.Acl.DefinedPermissions.Add(Acl.Get());
        }


    }
}
