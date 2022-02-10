using CMISSecurity.Infrastructre.CustomAttribute;
using CMISUIHelper.Infrastructure.Enums;
using CMISUIHelper.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CMISSecurity
{
    public static class PermissionHandler
    {
        public static bool AllowAcl(Dictionary<string,PermisionValue> permissions,string acl)
        {
            if(permissions.ContainsKey(acl))
                return permissions[acl] == PermisionValue.Allow;
            return false;
        }

        public static bool AllowAcl(this string acl, ViewTab view)
        {
            var aclName = $"{view.AppSchema}.{acl}";
            if (view.ACLS.ContainsKey(aclName))            
                return view.ACLS[aclName] == PermisionValue.Allow;
            return false;
        }
    }
}
