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


        public DataTable Companies()
        {
            return DAL.New.FetchCompaniesData();
        }

        public DataTable Contracts()
        {
            return DAL.New.FetchContractsData();
        }

    }
}
