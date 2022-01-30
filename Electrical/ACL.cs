using CMISSecurity;
using CMISSecurity.Infrastructre.CustomAttribute;
using Electrical;
using Electrical.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCElectrical
{
    [Schema(Bundle.SCHEMA)]
    public class ACL : CMISPolicy
    {

        [Permit("Allow access to specific companies", "Companies")]
        public const string Company = nameof(Company);

        [Permit("Allow access to specific contracts", "Contracts")]
        public const string Contract = nameof(Contract);

        [Permit("Allow access to Save itemcode")]
        public const string ButtonSaveItemCode = nameof(ButtonSaveItemCode);

        [Permit("Allow access to delete itemcode")]
        public const string ButtonDeleteItemCode = nameof(ButtonDeleteItemCode);

        [Permit("Allow access to show itemcode list")]
        public const string ShowItemCodeList = nameof(ShowItemCodeList);

        [Permit("Allow access to show category list")]
        public const string ShowCategoiesList = nameof(ShowCategoiesList);

        [Permit("Allow access to Save caegory")]
        public const string ButtonSaveCategory = nameof(ButtonSaveCategory);

        [Permit("Allow access to delete category")]
        public const string ButtonDeleteCategory = nameof(ButtonDeleteCategory);





        //Company combo provider
        public DataTable Companies()
        {
            return DAL.Do.FetchCompaniesData();
        }

        // Contract combo provider
        public DataTable Contracts()
        {
            return DAL.Do.FetchContractsData();
        }

    }
}
