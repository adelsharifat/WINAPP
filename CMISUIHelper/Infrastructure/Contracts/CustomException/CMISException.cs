using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISUIHelper.Infrastructure.Contracts.CustomException
{
    public class CMISException: Exception
    {
        public CMISException(string message):base(message)
        {
           
        }
    }
}
