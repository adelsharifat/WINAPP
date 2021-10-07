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
        public static dalUser User { get=>new dalUser();  }
        public static dalProject Project { get => new dalProject(); }
        public static dalCompany Company { get => new dalCompany(); }
        public static dalConfig Config { get => new dalConfig(); }
        public static dalPermision Permision { get => new dalPermision(); }
        public static dalServer Server { get => new dalServer(); }
    }
}
