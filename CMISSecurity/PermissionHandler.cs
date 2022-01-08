using CMISUIHelper.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISSecurity
{
    public static class PermissionHandler
    {
        public static bool AllowAcl(Dictionary<string,PermisionValue> permissions,string acl)
        {
            if(permissions.ContainsKey(acl))
            {
                return permissions[acl] == PermisionValue.Allow;
            }
            else
            {
                return false;
            }
        }
    }
}
