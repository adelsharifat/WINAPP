using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISSecurity.Infrastructre.CustomAttribute
{
    [AttributeUsage(AttributeTargets.Field)]
    public class Permit : Attribute
    {
        private string _itemHandlerName = null;
        private string _description = null;

        public Permit(string Description = null, string ItemHandlerName = null)
        {
            _description = Description;
            _itemHandlerName = ItemHandlerName;
        }        

        public string Description => _description;
        public string ItemHandlerName => _itemHandlerName;

    }

    [AttributeUsage(AttributeTargets.Class)]
    public class Schema : Attribute
    {
        private string _name = null;
        public Schema(string Name)
        {
            _name = Name;
        }
        public string Name => _name;
    }
}
