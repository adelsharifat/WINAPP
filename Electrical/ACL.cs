using CMISNewSecurity;
using CMISNewSecurity.Infrastructre.CustomAttribute;
using Electrical;
using Electrical.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrical
{
    [Schema(Bundle.SCHEMA)]
    public class ACL : CMISPolicy
    {

        [AclPolicy("Allow access to specific companies", "Companies")]
        public const string Company = nameof(Company);

        [AclPolicy("Allow access to specific contracts", "Contracts")]
        public const string Contract = nameof(Contract);

        [AclPolicy("Allow access to specific vendros", "Companies")]
        public const string Vendor = nameof(Vendor);

        [AclPolicy("Allow access to Save itemcode")]
        public const string SaveItemCode = nameof(SaveItemCode);

        [AclPolicy("Allow access to Edit itemcode")]
        public const string EditItemCode = nameof(EditItemCode);

        [AclPolicy("Allow access to delete itemcode")]
        public const string DeleteItemCode = nameof(DeleteItemCode);

        [AclPolicy("Allow access to show itemcode list")]
        public const string ShowItemCodeList = nameof(ShowItemCodeList);



        [AclPolicy("Allow access to show category list")]
        public const string ShowCategoriesList = nameof(ShowCategoriesList);

        [AclPolicy("Allow access to Save caegory")]
        public const string SaveCategory = nameof(SaveCategory);

        [AclPolicy("Allow access to Epdit caegory")]
        public const string EditCategory = nameof(EditCategory);

        [AclPolicy("Allow access to delete category")]
        public const string DeleteCategory = nameof(DeleteCategory);




        #region Packing
        [AclPolicy("Allow access to View Packing")]
        public const string ViewPLDocument = nameof(ViewPLDocument);

        [AclPolicy("Allow access to Edit Packing")]
        public const string EditPLDocument = nameof(EditPLDocument);

        [AclPolicy("Allow access to Delete Packing")]
        public const string DeletePLDocument = nameof(DeletePLDocument);

        [AclPolicy("Allow access to Save Packing")]
        public const string SavePLDocument = nameof(SavePLDocument);

        [AclPolicy("Allow access to Post PL Document")]
        public const string PostPLDocument = nameof(PostPLDocument);

        [AclPolicy("Allow access to can show all pl document document for ex deleted or norlmal document")]
        public const string ShowAllPLDocument = nameof(ShowAllPLDocument);
        #endregion

        #region MIV
        [AclPolicy("Allow access to View MIV")]
        public const string ViewMIVDocument = nameof(ViewMIVDocument);

        [AclPolicy("Allow access to Save MIV")]
        public const string SaveMIVDocument = nameof(SaveMIVDocument);

        [AclPolicy("Allow access to Edit MIV Document")]
        public const string EditMIVDocument = nameof(EditMIVDocument);

        [AclPolicy("Allow access to Delete MIV Document")]
        public const string DeleteMIVDocument = nameof(DeleteMIVDocument);

        [AclPolicy("Allow access to Post MIV Document")]
        public const string PostMIVDocument = nameof(PostMIVDocument);
        #endregion


        #region MTO
        [AclPolicy("Allow access to save MTO")]
        public const string SaveMTO = nameof(SaveMTO);
        [AclPolicy("Allow access to delete MTO")]
        public const string DeleteMTO = nameof(DeleteMTO);
        [AclPolicy("Allow access to edit MTO")]
        public const string EditMTO = nameof(EditMTO);
        #endregion

        #region Signs
        [AclPolicy("Allow access to Sign Role PLCreator")]
        public const string PLCreator = nameof(PLCreator);

        [AclPolicy("Allow access to Sign Role MIVCre")]
        public const string MIVCreator = nameof(MIVCreator);
        #endregion



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
