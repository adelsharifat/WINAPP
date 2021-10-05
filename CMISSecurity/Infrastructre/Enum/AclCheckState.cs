using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISSecurity.Infrastructure.Enum
{
    public enum AclCheckState
    {
        Inherit = 0,
        Allow = 1,
        Deny = -1,
    }
}
