using CMISSecurity;
using CMISSecurity.Infrastructre.CustomAttribute;
using QCElectrical.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCElectrical
{
    [Schema(Bundle.SCHEMA)]
    public class Permision : CMISPolicy
    {

        [Permit("Allow access to specific companies", "Companies")]
        public const string Company = nameof(Company);

        [Permit("Allow access to specific contracts", "Contracts")]
        public const string Contract = nameof(Contract);

        [Permit("Allow access to Role SUBCONTRACTOR")]
        public const string SubContractor = nameof(SubContractor);

        [Permit("Allow access to Role CONSERTIUM")]
        public const string Consertium = nameof(Consertium);

        [Permit("Allow access to Role NIOEC")]
        public const string NIOEC = nameof(NIOEC);


        public DataTable Companies()
        {
            return DAL.Do.FetchCompaniesData();
        }

        public DataTable Contracts()
        {
            return DAL.Do.FetchContractsData();
        }

    }
}
