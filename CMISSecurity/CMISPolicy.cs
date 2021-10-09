using CMISSecurity.Infrastructre.CustomAttribute;
using CMISSecurity.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CMISSecurity
{
    public class CMISPolicy
    {
        public List<ACLModel> PermissionList {
            get {
                return GetPermissionList();
            }
        }

        private List<ACLModel> GetPermissionList()
        {
            List<ACLModel> aCLModels = new List<ACLModel>();
            LoadReferencedAssembly(Assembly.GetEntryAssembly());
            var aclsFields = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.FullName.Contains("PublicKeyToken=null")).SelectMany(x=>x.GetTypes())
                .Where(x => x.IsClass)
                .SelectMany(x => x.GetFields())
                .Where(x => x.GetCustomAttributes(typeof(Permit), false).FirstOrDefault() != null );

            foreach (var item in aclsFields)
            {
                var schema = item.ReflectedType.GetCustomAttribute<Schema>().Name;

                var permitAttributes = item.GetCustomAttribute<Permit>();

                aCLModels.Add(new ACLModel
                {
                    Id = 0,
                    Schema = schema,
                    Name = item.GetValue(null).ToString(),
                    Description = permitAttributes.Description,
                    Allow = false,
                    ItemsDataProvider = GetDataItemProvider(item.ReflectedType, permitAttributes.ItemHandlerName)
                });

            }
           

            return aCLModels;
        }

        private DataTable GetDataItemProvider(Type type,string itemHandlerName)
        {
            List<ValueModel> valueModelList = new List<ValueModel>();
            var method = (from m in type.GetTypeInfo().DeclaredMethods
                         where m.Name == itemHandlerName
                         select m).FirstOrDefault();
            var instance = Activator.CreateInstance(type);
            var items = method?.Invoke(instance, null) as DataTable;


            return items;
        }

        private void LoadReferencedAssembly(Assembly assembly)
        {
            foreach (AssemblyName name in assembly.GetReferencedAssemblies())
            {
                if (!AppDomain.CurrentDomain.GetAssemblies().Any(a => a.FullName == name.FullName))
                {
                    this.LoadReferencedAssembly(Assembly.Load(name));
                }
            }
        }
    }
}
