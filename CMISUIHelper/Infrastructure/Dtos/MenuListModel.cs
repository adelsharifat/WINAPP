using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISUIHelper.Infrastructure.Dtos
{
    public class MenuListModel
    {
        public Type Form { get; set; }
        public string Title { get; set; }
        public string GroupTitle { get; set; }
        public string ResourceName { get; set; }
        public string ResourceKey { get; set; }
        public int ItemOrderId { get; set; }
        public int GroupOrderId { get; set; }
    }
}
