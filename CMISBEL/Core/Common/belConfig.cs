using CMISDAL.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISBEL.Core.Common
{
    public class belConfig
    {
        public static belConfig Do { get; private set; } = new belConfig();
        public Dictionary<string,string> Config(int projectId,string scope)
        {
            try
            {
                Dictionary<string, string> Config_Dic = new Dictionary<string, string>();
                var data = CommonDals.Do.Config.FetchConfig(projectId, scope);
                data.AsEnumerable().ToList().ForEach((row) =>
                {
                    Config_Dic.Add(row["Name"].ToString(), row["Value"].ToString());
                });
                return Config_Dic;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
