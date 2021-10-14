using CMISDAL.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISDAL.Common
{
    public class CommonDals
    {
        public static CommonDals Do { get; private set; } = new CommonDals();

        public dalUser User { get=>new dalUser();  }
        public dalProject Project { get => new dalProject(); }
        public dalCompany Company { get => new dalCompany(); }
        public dalContract Contract { get => new dalContract(); }
        public dalAreaUnit AreaUnit { get => new dalAreaUnit(); }
        public dalConfig Config { get => new dalConfig(); }
        public dalPermision Permision { get => new dalPermision(); }
        public dalServer Server { get => new dalServer(); }
    }
}
