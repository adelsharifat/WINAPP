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
        public const string ButtonSaveItemCode = nameof(ButtonSaveItemCode);

        [Permit("Allow access to delete itemcode")]
        public const string ButtonDeleteItemCode = nameof(ButtonDeleteItemCode);

        [Permit("Allow access to show itemcode list")]
        public const string ShowItemCodeList = nameof(ShowItemCodeList);



        [Permit("Allow access to show category list")]
        public const string ShowCategoriesList = nameof(ShowCategoriesList);

        [Permit("Allow access to Save caegory")]
        public const string ButtonSaveCategory = nameof(ButtonSaveCategory);

        [Permit("Allow access to delete category")]
        public const string ButtonDeleteCategory = nameof(ButtonDeleteCategory);




        #region Packing
        [Permit("Allow access to View Packing")]
        public const string ButtonViewPLDocument = nameof(ButtonViewPLDocument);

        [Permit("Allow access to Edit Packing")]
        public const string ButtonEditPLDocument = nameof(ButtonEditPLDocument);

        [Permit("Allow access to Delete Packing")]
        public const string ButtonDeletePLDocument = nameof(ButtonDeletePLDocument);

        [Permit("Allow access to Save Packing")]
        public const string ButtonSavePLDocument = nameof(ButtonSavePLDocument);

        [Permit("Allow access to Post PL Document")]
        public const string ButtonPostPLDocument = nameof(ButtonPostPLDocument);
        #endregion

        #region MIV
        [Permit("Allow access to View MIV")]
        public const string ButtonViewMIVDocument = nameof(ButtonViewMIVDocument);

        [Permit("Allow access to Save MIV")]
        public const string ButtonSaveMIVDocument = nameof(ButtonSaveMIVDocument);

        [Permit("Allow access to Edit MIV Document")]
        public const string ButtonEditMIVDocument = nameof(ButtonEditMIVDocument);

        [Permit("Allow access to Delete MIV Document")]
        public const string ButtonDeleteMIVDocument = nameof(ButtonDeleteMIVDocument);

        [Permit("Allow access to Post MIV Document")]
        public const string ButtonPostMIVDocument = nameof(ButtonPostMIVDocument);
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
