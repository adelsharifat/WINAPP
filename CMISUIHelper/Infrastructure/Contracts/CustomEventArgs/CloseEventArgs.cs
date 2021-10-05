using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISUIHelper.Infrastructure.Contracts.CustomEventArgs
{
    public class CloseEventArgs:EventArgs
    {
        private bool cancel = false;

        public bool Cancel
        {
            get { return cancel; }
            set { cancel = value; }
        }
    }
}
