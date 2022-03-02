using CMISNewSecurity;
using CMISNewSecurity.Infrastructre.CustomAttribute;
using Security;
using SecurityManagement.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityManagement
{
    [Schema("JobReport")]
    public class JobReportACL: GuardPolicy
    {

        //Tiles
        [AclPolicy("Allow access to tile new report")]
        public const string TileNewReport = nameof(TileNewReport);

        [AclPolicy("Allow access to tile list report")]
        public const string TileReportList = nameof(TileReportList);

        [AclPolicy("Allow access to tile sent list")]
        public const string TileArchive = nameof(TileArchive);

        [AclPolicy("Allow access to tile inbox list")]
        public const string TileInbox = nameof(TileInbox);



        //ItemsButton
        [AclPolicy("Allow to new report")]
        public const string NewReport = nameof(NewReport);

        [AclPolicy("Allow to edit report")]
        public const string EditReport = nameof(EditReport);

        [AclPolicy("Allow to delete report")]
        public const string DeleteReport = nameof(DeleteReport);

        [AclPolicy("Allow to save report")]
        public const string SaveReport = nameof(SaveReport);

        [AclPolicy("Allow to View report")]
        public const string ViewReport = nameof(ViewReport);

        [AclPolicy("Allow to post report")]
        public const string AcceptReport = nameof(AcceptReport);

        [AclPolicy("Allow to reject report")]
        public const string RejectReport = nameof(RejectReport);

        [AclPolicy("Allow to sign history")]
        public const string SignHistory = nameof(SignHistory);



        [AclPolicy("Company acl for cmisacl app acls", "GetCompanies")]
        public const string Company = nameof(Company);

        [AclPolicy("Dsicipline acl for cmisacl app acls", "GetDisciplines")]
        public const string Discipline = nameof(Discipline);


        [AclPolicy("Dsicipline acl for cmisacl app acls")]
        public const string ShowAll = nameof(ShowAll);


        //SignConfig Roles
        [AclPolicy("Allow the expert role send and post document to head role")]
        public const string Expert_To_Head = nameof(Expert_To_Head);

        [AclPolicy("Allow the head role for recive document from expert role and post to complete")]
        public const string Head_To_Complete = nameof(Head_To_Complete);

        [AclPolicy("Allow the Head role send and post document to Manager role")]
        public const string Head_To_Manager = nameof(Head_To_Manager);

        [AclPolicy("Allow the Manager role for recive document from Head role and post to complete")]
        public const string Manager_To_Complete = nameof(Manager_To_Complete);



        public DataTable GetDisciplines()
        {
            return DAL.Do.FetchDisciplineForAcls(LoginInfo.ProjectId);
        }

        public DataTable GetCompanies()
        {
            return DAL.Do.FetchCompaniesData();
        }
    }
}
