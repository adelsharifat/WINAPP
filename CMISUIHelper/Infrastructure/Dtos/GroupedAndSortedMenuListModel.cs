using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISUIHelper.Infrastructure.Dtos
{
    public class GroupedAndSortedMenuListModel
    {
        public string RibbonPageGroup { get; set; }
        public List<MenuListModel> Menus { get; set; }
    }
}
