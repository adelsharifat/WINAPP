using CMISSecurity;
using CMISSecurity.Infrastructre.CustomAttribute;
using SecurityManagement.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCC_WinApplication.NewFolder1.NewFolder1.NewFolder1
{
    [Schema("JobReport")]
    public class CMISACL : CMISPolicy
    {

        //Tiles
        [Permit("Allow access to tile new report")]
        public const string TileNewReport = nameof(TileNewReport);

        [Permit("Allow access to tile list report")]
        public const string TileReportList = nameof(TileReportList);

        [Permit("Allow access to tile sent list")]
        public const string TileArchive = nameof(TileArchive);

        [Permit("Allow access to tile inbox list")]
        public const string TileInbox = nameof(TileInbox);



        //ItemsButton
        [Permit("Allow to new report")]
        public const string NewReport = nameof(NewReport);

        [Permit("Allow to edit report")]
        public const string EditReport = nameof(EditReport);

        [Permit("Allow to delete report")]
        public const string DeleteReport = nameof(DeleteReport);

        [Permit("Allow to save report")]
        public const string SaveReport = nameof(SaveReport);

        [Permit("Allow to View report")]
        public const string ViewReport = nameof(ViewReport);

        [Permit("Allow to post report")]
        public const string AcceptReport = nameof(AcceptReport);

        [Permit("Allow to reject report")]
        public const string RejectReport = nameof(RejectReport);

        [Permit("Allow to sign history")]
        public const string SignHistory = nameof(SignHistory);



        [Permit("Company acl for cmisacl app acls", "GetCompanies")]
        public const string Company = nameof(Company);

        [Permit("Dsicipline acl for cmisacl app acls", "GetDisciplines")]
        public const string Discipline = nameof(Discipline);


        [Permit("Dsicipline acl for cmisacl app acls")]
        public const string ShowAll = nameof(ShowAll);


        //SignConfig Roles
        [Permit("Allow the expert role send and post document to head role")]
        public const string Expert_To_Head = nameof(Expert_To_Head);

        [Permit("Allow the head role for recive document from expert role and post to complete")]
        public const string Head_To_Complete = nameof(Head_To_Complete);

        [Permit("Allow the Head role send and post document to Manager role")]
        public const string Head_To_Manager = nameof(Head_To_Manager);

        [Permit("Allow the Manager role for recive document from Head role and post to complete")]
        public const string Manager_To_Complete = nameof(Manager_To_Complete);



        public DataTable GetDisciplines()
        {
            //return CMDAL.SharedDAL.FetchDisciplineForAcls(1);
            return null;
        }

        public DataTable GetCompanies()
        {
            return DAL.New.FetchCompaniesData();
        }
    }
}
