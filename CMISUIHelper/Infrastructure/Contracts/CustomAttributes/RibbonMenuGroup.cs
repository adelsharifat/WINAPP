using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISUIHelper.Infrastructure.Contracts.CustomAttributes
{
    public class RibbonMenuGroup:Attribute
    {
        private string title;
        private int orderId;
        public RibbonMenuGroup(string Title, int OrderId)
        {
            this.title = Title;
            this.orderId = OrderId;
        }

        public string Title => title;
        public int OrderId => orderId;
    }
}
