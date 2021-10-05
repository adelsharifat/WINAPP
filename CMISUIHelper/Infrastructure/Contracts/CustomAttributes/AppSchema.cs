using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISUIHelper.Infrastructure.Contracts.CustomAttributes
{
    public class AppSchema:Attribute
    {
        private string[] schemas;
        public AppSchema(params string[] Schemas)
        {
            this.schemas = Schemas;
        }

        public string[] Schemas => schemas;
    }
}
