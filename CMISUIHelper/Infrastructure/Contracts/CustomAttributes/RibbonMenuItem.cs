using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISUIHelper.Infrastructure.Contracts.CustomAttributes
{
    public class RibbonMenuItem:Attribute
    {
        private string title;
        private int orderId;
        public RibbonMenuItem(string Title, int OrderId)
        {
            this.title = Title;
            this.orderId = OrderId;
        }

        public string Title => title;
        public int OrderId => orderId;
    }
}
