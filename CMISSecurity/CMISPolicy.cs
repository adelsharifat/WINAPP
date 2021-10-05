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

            var aclsFields = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x=>x.GetTypes())
                .Where(x => x.IsClass)
                .SelectMany(x => x.GetRuntimeFields())
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

        private List<Assembly> GetListOfEntryAssemblyWithReferences()
        {
            List<Assembly> listOfAssemblies = new List<Assembly>();
            var mainAsm = Assembly.GetEntryAssembly();
            listOfAssemblies.Add(mainAsm);

            foreach (var refAsmName in mainAsm.GetReferencedAssemblies())
            {
                listOfAssemblies.Add(Assembly.Load(refAsmName));
            }
            return listOfAssemblies;
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

    }
}
