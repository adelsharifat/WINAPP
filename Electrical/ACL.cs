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

namespace Electrical
{
    [Schema(Bundle.SCHEMA)]
    public class ACL : CMISPolicy
    {

        [Permit("Allow access to specific companies", "Companies")]
        public const string Company = nameof(Company);

        [Permit("Allow access to specific contracts", "Contracts")]
        public const string Contract = nameof(Contract);

        [Permit("Allow access to specific vendros", "Companies")]
        public const string Vendor = nameof(Vendor);

        [Permit("Allow access to Save itemcode")]
        public const string SaveItemCode = nameof(SaveItemCode);

        [Permit("Allow access to Edit itemcode")]
        public const string EditItemCode = nameof(EditItemCode);

        [Permit("Allow access to delete itemcode")]
        public const string DeleteItemCode = nameof(DeleteItemCode);

        [Permit("Allow access to show itemcode list")]
        public const string ShowItemCodeList = nameof(ShowItemCodeList);



        [Permit("Allow access to show category list")]
        public const string ShowCategoriesList = nameof(ShowCategoriesList);

        [Permit("Allow access to Save caegory")]
        public const string SaveCategory = nameof(SaveCategory);

        [Permit("Allow access to Epdit caegory")]
        public const string EditCategory = nameof(EditCategory);

        [Permit("Allow access to delete category")]
        public const string DeleteCategory = nameof(DeleteCategory);




        #region Packing
        [Permit("Allow access to View Packing")]
        public const string ViewPLDocument = nameof(ViewPLDocument);

        [Permit("Allow access to Edit Packing")]
        public const string EditPLDocument = nameof(EditPLDocument);

        [Permit("Allow access to Delete Packing")]
        public const string DeletePLDocument = nameof(DeletePLDocument);

        [Permit("Allow access to Save Packing")]
        public const string SavePLDocument = nameof(SavePLDocument);

        [Permit("Allow access to Post PL Document")]
        public const string PostPLDocument = nameof(PostPLDocument);

        [Permit("Allow access to can show all pl document document for ex deleted or norlmal document")]
        public const string ShowAllPLDocument = nameof(ShowAllPLDocument);
        #endregion

        #region MIV
        [Permit("Allow access to View MIV")]
        public const string ViewMIVDocument = nameof(ViewMIVDocument);

        [Permit("Allow access to Save MIV")]
        public const string SaveMIVDocument = nameof(SaveMIVDocument);

        [Permit("Allow access to Edit MIV Document")]
        public const string EditMIVDocument = nameof(EditMIVDocument);

        [Permit("Allow access to Delete MIV Document")]
        public const string DeleteMIVDocument = nameof(DeleteMIVDocument);

        [Permit("Allow access to Post MIV Document")]
        public const string PostMIVDocument = nameof(PostMIVDocument);
        #endregion


        #region MTO
        [Permit("Allow access to save MTO")]
        public const string SaveMTO = nameof(SaveMTO);
        [Permit("Allow access to save MTO")]
        public const string DeleteMTO = nameof(DeleteMTO);
        #endregion

        #region Signs
        [Permit("Allow access to Sign Role PLCreator")]
        public const string PLCreator = nameof(PLCreator);

        [Permit("Allow access to Sign Role MIVCre")]
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
