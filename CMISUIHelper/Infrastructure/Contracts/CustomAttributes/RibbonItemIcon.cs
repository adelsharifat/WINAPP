using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISUIHelper.Infrastructure.Contracts.CustomAttributes
{
    public class  RibbonItemIcon:Attribute
    {
        private string resourceName;
        private string resourceKey;
        public RibbonItemIcon(string ResourceName,string ResourceKey)
        {
            this.resourceName = ResourceName;
            this.resourceKey = ResourceKey;
        }

        public string ResourceName => resourceName;
        public string ResourceKey => resourceKey;
    }
}
