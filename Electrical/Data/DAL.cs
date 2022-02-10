using CMISDAL.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrical.Data
{
    public class DAL:APPDAL
    {
        public static DAL Do { get => new DAL(); }

        #region Common
        //Fetch compnies data for combo company
        public DataTable FetchCompaniesData()
        {
            try
            {
                return DoQueryReader("SecAcl.FetchCompaniesData");
            }
            catch (Exception)
            {
                throw;
            }
        }   
        
        //Fetch contract data for combo contract
        public DataTable FetchContractsData()
        {
            try
            {
                return DoQueryReader("SecAcl.FetchContractsData");
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region ItemCode
        public DataTable GetWarehouseItemCodesCombo()
        {
            try
            {
                return DoQueryReader("EL.GetWarehouseItemCodesCombo");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public dynamic GetItemCodes(int projectId, int userId, int? id = null)
        {
            try
            {
                dynamic data = null;
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter("ProjectId",projectId),
                    new SqlParameter("UserId",userId),
                    new SqlParameter("Id",id)
                };
                if (id == null)
                    data = DoQueryReader("EL.GetItemCodes", sqlParams);
                else
                {
                    data = DoQueryReader("EL.GetItemCodes", sqlParams);
                    if (data.Rows.Count > 0) return data.Rows[0] as DataRow;
                }
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int? SaveItemCode(int? id,int categoryId,int warehouseItemCodeId,string itemCode,int projectId, int userId)
        {
            try
            {
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter
                    {
                        ParameterName = "Id",
                        Value = id,
                        Direction = ParameterDirection.InputOutput,
                        SqlDbType = SqlDbType.Int,
                        DbType = DbType.Int32,
                        Size = 0
                    },
                    new SqlParameter("CategoryId",categoryId),
                    new SqlParameter("WarehouseItemCodeId",warehouseItemCodeId),
                    new SqlParameter("ItemCode",itemCode),
                    new SqlParameter("ProjectId",projectId),
                    new SqlParameter("UserId",userId)
                };
                DoMutation("EL.SaveItemCode", sqlParams);
                var outParam = sqlParams.FirstOrDefault(x => x.ParameterName == "Id");
                return outParam.Value == DBNull.Value ? null :(int?)Convert.ToInt32(outParam.Value);                
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int? DeleteItemCode(int id,int projectId, int userId)
        {
            try
            {
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter("Id",id),
                    new SqlParameter("ProjectId",projectId),
                    new SqlParameter("UserId",userId)
                };
                
                return DoMutation("EL.DeleteItemCode", sqlParams);

            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Category
        public DataTable GetCategoriesCombo(bool all = true)
        {
            try
            {
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter("All",all)
                };
                return DoQueryReader("EL.GetCategoriesCombo",sqlParams);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable GetSubCategoriesCombo(int categoryId)
        {
            try
            {
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter("CategoryId",categoryId)
                };
                return DoQueryReader("EL.GetSubCategoriesCombo",sqlParams);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public dynamic GetCategories(int projectId, int userId, int? id = null)
        {
            try
            {
                dynamic data = null;
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter("ProjectId",projectId),
                    new SqlParameter("UserId",userId),
                    new SqlParameter("Id",id)
                };
                data = DoQueryReader("EL.GetCategories", sqlParams);
                if (data.Rows.Count > 0 && id != null) return data.Rows[0] as DataRow;
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int? SaveCategory(int projectId,int userId,int? categoryId, int? parentCategoryId, string category)
        {
            try
            {
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter
                    {
                        ParameterName = "Id",
                        Value = categoryId,
                        Direction = ParameterDirection.InputOutput,
                        SqlDbType = SqlDbType.Int,
                        DbType = DbType.Int32,
                        Size = 0
                    },
                    new SqlParameter("ProjectId",projectId),
                    new SqlParameter("UserId",userId),
                    new SqlParameter("ParentCategoryId",parentCategoryId),
                    new SqlParameter("Category",category),
                };
                DoMutation("EL.SaveCategory", sqlParams);
                var outParam = sqlParams.FirstOrDefault(x => x.ParameterName == "Id");
                return outParam.Value == DBNull.Value ? null : (int?)Convert.ToInt32(outParam.Value);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int? DeleteCategory(int id, int projectId, int userId)
        {
            try
            {
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter("Id",id),
                    new SqlParameter("ProjectId",projectId),
                    new SqlParameter("UserId",userId)
                };

                return DoMutation("EL.DeleteCategory", sqlParams);

            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Packing
        public DataTable GetPackingItemsByDocumentId(int? documentId)
        {
            try
            {
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter("DocumentId",documentId)
                };
                return DoQueryReader("EL.GetPackingItemsByDocumentId",sqlParams);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable GetPLQtyUnit()
        {
            try
            {
                return DoQueryReader("EL.GetPLQtyUnit");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable GetItemCodesCombo(int? categoryId = null)
        {
            try
            {
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter("CategoryId",categoryId)
                };
                return DoQueryReader("EL.GetItemCodesCombo", sqlParams);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int SavePacking(int projectId,int companyId, int? documentId, int userId,string reportNo, DataTable packingItems)
        {
            var sqlParams = new SqlParameter[]
            {
                new SqlParameter("ProjectId",projectId),
                new SqlParameter("CompanyId",companyId),
                new SqlParameter("DocumentId",documentId),
                new SqlParameter("UserId",userId),
                new SqlParameter("ReportNo",reportNo),
                new SqlParameter("PackingItems",packingItems),
            };
            return DoMutation("EL.SavePacking", sqlParams);
        }
        public int SignPLDocument(string signtype,int projectId, int userId, int objectId,string nextRole,string machineName,string activeDirectoryName,int companyId)
        {
            var sqlParams = new SqlParameter[]
               {
                new SqlParameter("SignRequestType",signtype),
                new SqlParameter("ProjectId",projectId),
                new SqlParameter("UserId",userId),
                new SqlParameter("ObjectId",objectId),
                new SqlParameter("NextRole",nextRole),
                new SqlParameter("MachineName",machineName),
                new SqlParameter("ActiveDirectoryName",activeDirectoryName),
                new SqlParameter("CompanyId",companyId)
               };
            return DoMutation("EL.SignPLDocument", sqlParams);
        }



        #endregion

        #region MIV
        public DataTable GetMIVItemCodesCombo()
            => DoQueryReader("EL.GetMIVItemCodesCombo");

        #endregion


        #region PackingList
        public dynamic GetPackingDocuments(int projectId, int companyId, int? id = null)
        {
            try
            {
                dynamic data = null;
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter("ProjectId",projectId),
                    new SqlParameter("CompanyId",companyId),
                    new SqlParameter("Id",id)
                };
                data = DoQueryReader("EL.GetPackingDocuments", sqlParams);
                if (data.Rows.Count > 0 && id != null) return data.Rows[0] as DataRow;
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
