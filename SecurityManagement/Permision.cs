using CMISSecurity;
using CMISSecurity.Infrastructre.CustomAttribute;
using SecurityManagement.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityManagement
{
    [Schema(Bundle.SCHEMA)]
    public class Permision : CMISPolicy
    {

        [Permit("Allow access to specific companies", "Companies")]
        public const string Company = nameof(Company);

        //Tiles Access List        
        [Permit("Allow access to tile employee")]
        public const string TileEmployee = nameof(TileEmployee);

        [Permit("Allow access to tile job position")]
        public const string TileJobPosition = nameof(TileJobPosition);

        [Permit("Allow access to tile gate pass type")]
        public const string TileGatePassType = nameof(TileGatePassType);

        [Permit("Allow access to tile face place")]
        public const string TileFacePlace = nameof(TileFacePlace);

        [Permit("Allow access to tile city")]
        public const string TileCity = nameof(TileCity);

        [Permit("Allow access to tile province")]
        public const string TileProvince = nameof(TileProvince);

        [Permit("Allow access to tile country")]
        public const string TileCountry = nameof(TileCountry);

        [Permit("Allow access to tile units")]
        public const string TileUnits = nameof(TileUnits);

        [Permit("Allow access to tile new request")]
        public const string TileNewRequest = nameof(TileNewRequest);

        [Permit("Allow access to tile request list")]
        public const string TileRequestList = nameof(TileRequestList);

        [Permit("Allow access to tile report companyWise list")]
        public const string TileReportCompanyWise = nameof(TileReportCompanyWise);







        //EmployeeForm
        [Permit("Allow access to save new Employee")]
        public const string ButtonSaveEmployee = nameof(ButtonSaveEmployee);

        [Permit("Allow access to update Employee")]
        public const string ButtonUpdateEmployee = nameof(ButtonUpdateEmployee);

        [Permit("Allow access to delete Employee")]
        public const string ButtonDeleteEmployee = nameof(ButtonDeleteEmployee);


        [Permit("Allow access to revoke gate pass")]
        public const string ButtonRevokeGatePass = nameof(ButtonRevokeGatePass);



        //JobPosition Form
        [Permit("Allow access to save new jobPosition")]
        public const string ButtonSaveJobPosition = nameof(ButtonSaveJobPosition);

        [Permit("Allow access to update jobPosition")]
        public const string ButtonUpdateJobPosition = nameof(ButtonUpdateJobPosition);

        [Permit("Allow access to delete jobPositions")]
        public const string ButtonDeleteJobPosition = nameof(ButtonDeleteJobPosition);



        // GatePassType Form

        [Permit("Allow access to save new GatePassType")]
        public const string ButtonSaveGatePassType = nameof(ButtonSaveGatePassType);

        [Permit("Allow access to update GatePassType")]
        public const string ButtonUpdateGatePassType = nameof(ButtonUpdateGatePassType);

        [Permit("Allow access to delete GatePassType")]
        public const string ButtonDeleteGatePassTypes = nameof(ButtonDeleteGatePassTypes);


        // Face Identification Place Form
        [Permit("Allow access to save new FaceIdentificationPlace")]
        public const string ButtonSaveFaceIdentificationPlace = nameof(ButtonSaveFaceIdentificationPlace);

        [Permit("Allow access to update FaceIdentificationPlace")]
        public const string ButtonUpdateFaceIdentificationPlace = nameof(ButtonUpdateFaceIdentificationPlace);

        [Permit("Allow access to delete FaceIdentificationPlace")]
        public const string ButtonDeleteFaceIdentificationPlaces = nameof(ButtonDeleteFaceIdentificationPlaces);


        // City Form
        [Permit("Allow access to save new city")]
        public const string ButtonSaveCity = nameof(ButtonSaveCity);

        [Permit("Allow access to update city")]
        public const string ButtonUpdateCity = nameof(ButtonUpdateCity);

        [Permit("Allow access to delete cities")]
        public const string ButtonDeleteCities = nameof(ButtonDeleteCities);


        // New Request Form
        [Permit("Allow access to specific company for set to employee", "Companies")]
        public const string EmployeeCompany = nameof(EmployeeCompany);



        // Request List Forms
        [Permit("user can acess view gate passes")]
        public const string ButtonViewGatePass = nameof(ButtonViewGatePass);

        [Permit("user can acess edit gate passes just in save mode")]
        public const string ButtonEditGatePass = nameof(ButtonEditGatePass);

        [Permit("user can acess delete gate passes")]
        public const string ButtonDeleteGatePass = nameof(ButtonDeleteGatePass);



        [Permit("user can confirm has not expired gate pass")]
        public const string SkipSckewDay = nameof(SkipSckewDay);


        [Permit("Allow access to manage attachment on new or edit access of form")]
        public const string ButtonShowAttachment = nameof(ButtonShowAttachment);

        [Permit("Allow access to manage attachment on new or edit access of form")]
        public const string ButtonShowHistory = nameof(ButtonShowHistory);



        //Report




        [Permit("Allow access for create new request gatepass")]
        public const string Expert = nameof(Expert);

        [Permit("Allow access head of unit or contractor defined employee")]
        public const string HeadOfUnit = nameof(HeadOfUnit);

        [Permit("Allow access security manager to gate pass document")]
        public const string Security_Manager = nameof(Security_Manager);

        [Permit("Allow access ODCC/SEI manager to gate pass document")]
        public const string ODCC_SEI_Manager = nameof(ODCC_SEI_Manager);

        [Permit("Allow access human resource manager to gate pass document")]
        public const string HR_Manager = nameof(HR_Manager);

        [Permit("Allow access HSE manager to gate pass document")]
        public const string HSE_Manager = nameof(HSE_Manager);

        [Permit("Allow access NIOEC manager to gate pass document")]
        public const string NIOEC_Manager = nameof(NIOEC_Manager);

        [Permit("Allow access NIOEC_Guard_Manager manager to gate pass document")]
        public const string NIOEC_Guard_Manager = nameof(NIOEC_Guard_Manager);


        public DataTable Companies()
        {
            return DAL.New.FetchCompaniesData();
        }

    }
}
