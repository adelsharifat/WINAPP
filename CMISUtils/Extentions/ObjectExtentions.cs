using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISUtils.Extentions
{
    public static class ObjectExtentions
    {
        public static int ToInt(this object obj)
            => obj == null ? 0 : Convert.ToInt32(obj);

        public static decimal ToDecimal(this object obj)
            => obj == null ? 0m : Convert.ToDecimal(obj);

        public static bool IsEmpty(this string str)
            => String.IsNullOrEmpty(str) && String.IsNullOrWhiteSpace(str);
    }
}
