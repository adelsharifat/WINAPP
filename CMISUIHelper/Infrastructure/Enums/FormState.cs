using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISUIHelper.Infrastructure.Enums
{
    public enum FormState
    {
        [Description("Save")]
        Save,
        [Description("Edit")]
        Edit,
        [Description("Read")]
        View
    }
}
