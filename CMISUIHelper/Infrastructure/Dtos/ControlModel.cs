using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISUIHelper.Infrastructure.Dtos
{
    public class ControlModel
    {
        public string Name { get; set; } = Guid.NewGuid().ToString("N").Substring(0, 10);
        public Type Type { get; set; }
        public object Control { get; set; }
    }
}
