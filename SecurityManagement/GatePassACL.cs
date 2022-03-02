using CMISNewSecurity;
using CMISNewSecurity.Infrastructre.CustomAttribute;
using SecurityManagement.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityManagement
{
    [Schema("GatePass")]
    public class GatePassACL:GuardPolicy
    {
        [AclPolicy("Allow access to specific companies", "Contracts")]
        public const string Company = nameof(Company);

        //Tiles Access List        
        [AclPolicy("Allow access to tile employee")]
        public const string TileEmployee = nameof(TileEmployee);

        [AclPolicy("Allow access to tile job position")]
        public const string TileJobPosition = nameof(TileJobPosition);

        [AclPolicy("Allow access to tile gate pass type")]
        public const string TileGatePassType = nameof(TileGatePassType);

        [AclPolicy("Allow access to tile face place")]
        public const string TileFacePlace = nameof(TileFacePlace);

        [AclPolicy("Allow access to tile city")]
        public const string TileCity = nameof(TileCity);

        [AclPolicy("Allow access to tile province")]
        public const string TileProvince = nameof(TileProvince);

        [AclPolicy("Allow access to tile country")]
        public const string TileCountry = nameof(TileCountry);

        [AclPolicy("Allow access to tile units")]
        public const string TileUnits = nameof(TileUnits);

        [AclPolicy("Allow access to tile settings")]
        public const string TileSettings = nameof(TileSettings);

        [AclPolicy("Allow access to tile new request")]
        public const string TileNewRequest = nameof(TileNewRequest);

        [AclPolicy("Allow access to tile request list")]
        public const string TileRequestList = nameof(TileRequestList);

        [AclPolicy("Allow access to tile report companyWise list")]
        public const string TileReportCompanyWise = nameof(TileReportCompanyWise);

        [AclPolicy("Allow access to tile NewSattisfactionLetter")]
        public const string TileNewSattisfactionLetter = nameof(TileNewSattisfactionLetter);

        [AclPolicy("Allow access to tile SattisfactionLetterList")]
        public const string TileSattisfactionLetterList = nameof(TileSattisfactionLetterList);


        [AclPolicy("Allow access to tile Reserve Person Code")]
        public const string TileReservePersonCode = nameof(TileReservePersonCode);


        //EmployeeForm
        [AclPolicy("Allow access to new Person")]
        public const string ButtonNewPerson = nameof(ButtonNewPerson);

        [AclPolicy("Allow access to view Person")]
        public const string ButtonViewPerson = nameof(ButtonViewPerson);

        [AclPolicy("Allow access to update Person")]
        public const string ButtonEditPerson = nameof(ButtonEditPerson);

        [AclPolicy("Allow access to delete Person")]
        public const string ButtonDeletePerson = nameof(ButtonDeletePerson);

        [AclPolicy("Allow access to revoke gate pass")]
        public const string ButtonRevokeGatePass = nameof(ButtonRevokeGatePass);


        //GatePassRequest HSE And Other Action On Request Follow
        [AclPolicy("Allow access to update attendance date and job position by HSE_Manager")]
        public const string ButtonHSEAction = nameof(ButtonHSEAction);

        [AclPolicy("Allow access to update job position by GatePassIssuer")]
        public const string ButtonGatePassIssuerAction = nameof(ButtonGatePassIssuerAction);

        [AclPolicy("Allow access to Button New Letter")]
        public const string ButtonNewLetter = nameof(ButtonNewLetter);

        [AclPolicy("Allow access to Button View Letter")]
        public const string ButtonViewLetter = nameof(ButtonViewLetter);

        [AclPolicy("Allow access to Button Save Letter")]
        public const string ButtonSaveLetter = nameof(ButtonSaveLetter);

        [AclPolicy("Allow access to Button Edit Letter")]
        public const string ButtonEditLetter = nameof(ButtonEditLetter);

        [AclPolicy("Allow access to Button Delete Letter")]
        public const string ButtonDeleteLetter = nameof(ButtonDeleteLetter);

        [AclPolicy("Allow access to Button Post Letter")]
        public const string ButtonPostLetter = nameof(ButtonPostLetter);

        [AclPolicy("Allow access to Button Reject Letter")]
        public const string ButtonRejectLetter = nameof(ButtonRejectLetter);

        [AclPolicy("Allow access to Button Sign History Of Letter")]
        public const string ButtonSignHistoryOfLetter = nameof(ButtonSignHistoryOfLetter);

        // Request List Forms
        [AclPolicy("user can acess view gate passes")]
        public const string ButtonViewGatePass = nameof(ButtonViewGatePass);

        [AclPolicy("user can acess edit gate passes just in save mode")]
        public const string ButtonEditGatePass = nameof(ButtonEditGatePass);

        [AclPolicy("user can acess delete gate passes")]
        public const string ButtonDeleteGatePass = nameof(ButtonDeleteGatePass);


        [AclPolicy("Allow access to manage attachment on new or edit access of form")]
        public const string ButtonShowAttachment = nameof(ButtonShowAttachment);

        [AclPolicy("Allow access to manage attachment on new or edit access of form")]
        public const string ButtonShowHistory = nameof(ButtonShowHistory);


        [AclPolicy("Allow access for create new request gatepass")]
        public const string Expert = nameof(Expert);

        [AclPolicy("Allow access head of unit or contractor defined employee")]
        public const string HeadOfUnit = nameof(HeadOfUnit);

        [AclPolicy("Allow access security manager to gate pass document")]
        public const string Security_Manager = nameof(Security_Manager);

        [AclPolicy("Allow access ODCC/SEI manager to gate pass document")]
        public const string ODCC_SEI_Manager = nameof(ODCC_SEI_Manager);

        [AclPolicy("Allow access human resource manager to gate pass document")]
        public const string HR_Manager = nameof(HR_Manager);

        [AclPolicy("Allow access HSE manager to gate pass document")]
        public const string HSE_Manager = nameof(HSE_Manager);

        [AclPolicy("Allow access NIOEC manager to gate pass document")]
        public const string NIOEC_Manager = nameof(NIOEC_Manager);


        [AclPolicy("Allow access Contractor create and send sattisfaction letter")]
        public const string Contractor = nameof(Contractor);

        [AclPolicy("Allow access GatePassIssuer for finalizing document")]
        public const string GatePassIssuer = nameof(GatePassIssuer);


        [AclPolicy("Allow access user can show already attachmentd for person")]
        public const string ShowAllAttachment = nameof(ShowAllAttachment);

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
