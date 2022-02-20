using CMISDAL.Base;
using Electrical.Model;
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

        public int? SaveItemCode(int? id,int categoryId,int warehouseItemCodeId,string itemCode,string size,int qtyUnitId,string remark,int projectId, int userId)
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
                    new SqlParameter("Size",size),
                    new SqlParameter("QtyUnitId",qtyUnitId),
                    new SqlParameter("Remark",remark),
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

        public int DeletePLDocument(int projectId, int userId,int documentId)
        {
            var sqlParams = new SqlParameter[]
            {
                new SqlParameter("ProjectId",projectId),
                new SqlParameter("UserId",userId),
                new SqlParameter("DocumentId",documentId)
            };
            return DoMutation("EL.DeletePLDocument", sqlParams);
        }


        public int SavePLDocument(SavePLDocument savePLDoc)
        {
            var sqlParams = new SqlParameter[]
            {
                new SqlParameter("ProjectId",savePLDoc.ProjectId),
                new SqlParameter("CompanyId",savePLDoc.CompanyId),
                new SqlParameter("DocumentId",savePLDoc.DocumentId),
                new SqlParameter("UserId",savePLDoc.UserId),
                new SqlParameter("PackingItems",savePLDoc.PackingItems),
            };
            return DoMutation("EL.SavePLDocument", sqlParams);
        }
        public int SignPLDocument(SignPLDocument signPLDoc)
        {
            var sqlParams = new SqlParameter[]
               {
                new SqlParameter("SignRequestType",signPLDoc.SignType.ToString()),
                new SqlParameter("ProjectId",signPLDoc.ProjectId),
                new SqlParameter("UserId",signPLDoc.UserId),
                new SqlParameter("ObjectId",signPLDoc.ObjectId),
                new SqlParameter("NextRole",signPLDoc.NextRole),
                new SqlParameter("MachineName",signPLDoc.MachineName),
                new SqlParameter("ActiveDirectoryName",signPLDoc.ActiveDirectoryName),
                new SqlParameter("CompanyId",signPLDoc.CompanyId)
               };
            return DoMutation("EL.SignPLDocument", sqlParams);
        }

        public int SaveAndSignPLDocument(SavePLDocument savePLDoc,SignPLDocument signPLDoc)
        {
            var sqlParams = new SqlParameter[]
               {
                new SqlParameter("DocumentId",savePLDoc.DocumentId),
                new SqlParameter("ProjectId",savePLDoc.ProjectId),
                new SqlParameter("CompanyId",savePLDoc.CompanyId),
                new SqlParameter("UserId",savePLDoc.UserId),
                new SqlParameter("PackingItems",savePLDoc.PackingItems),
                new SqlParameter("SignRequestType",signPLDoc.SignType.ToString()),
                new SqlParameter("NextRole",signPLDoc.NextRole),
                new SqlParameter("MachineName",signPLDoc.MachineName),
                new SqlParameter("ActiveDirectoryName",signPLDoc.ActiveDirectoryName),
               };
            return DoMutation("EL.SignPLDocument", sqlParams);
        }



        #endregion

        #region MIV
        public DataTable GetMIVItemCodesCombo(int projectId,int? warehouseCompanyId)
            => DoQueryReader("EL.GetMIVItemCodesCombo", new[] { new SqlParameter("WarehouseCompanyId", warehouseCompanyId),new SqlParameter("ProjectId",projectId) });
        public dynamic GetMIVDocuments(int? documentId,int userId,int contractId,int projectId)
        {
            try
            {
                dynamic data = null;
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter("Id",documentId),
                    new SqlParameter("UserId",userId),
                    new SqlParameter("ContractId",contractId),
                    new SqlParameter("ProjectId",projectId),
                };
                data = DoQueryReader("EL.GetMIVDocuments", sqlParams);
                if (data.Rows.Count > 0 && documentId != null) return data.Rows[0] as DataRow;
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int DeleteMIVDocument(int projectId, int userId, int documentId)
        {
            var sqlParams = new SqlParameter[]
            {
                new SqlParameter("ProjectId",projectId),
                new SqlParameter("UserId",userId),
                new SqlParameter("DocumentId",documentId)
            };
            return DoMutation("EL.DeleteMIVDocument", sqlParams);
        }
        public int SaveMIVDocument(SaveMIV saveMIV)
        {
            try
            {
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter("DocumentId",saveMIV.DocumentId),
                    new SqlParameter("ProjectId",saveMIV.ProjectId),
                    new SqlParameter("UserId",saveMIV.UserId),
                    new SqlParameter("ContractId",saveMIV.ContractId),
                    new SqlParameter("CompanyId",saveMIV.CompanyId),
                    new SqlParameter("ContractorId",saveMIV.ContractorId),
                    new SqlParameter("Remark",saveMIV.Remark),
                    new SqlParameter("MIVItems",saveMIV.MIVItems)
                };
                return DoMutation("EL.SaveMIVDocument", sqlParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SignMIVDocument(SignMIV signMIV)
        {
            var sqlParams = new SqlParameter[]
               {
                new SqlParameter("SignRequestType",signMIV.SignType.ToString()),
                new SqlParameter("ProjectId",signMIV.ProjectId),
                new SqlParameter("UserId",signMIV.UserId),
                new SqlParameter("ObjectId",signMIV.ObjectId),
                new SqlParameter("NextRole",signMIV.NextRole),
                new SqlParameter("MachineName",signMIV.MachineName),
                new SqlParameter("ActiveDirectoryName",signMIV.ActiveDirectoryName),
                new SqlParameter("CompanyId",signMIV.CompanyId)
               };
            return DoMutation("EL.SignMIVDocument", sqlParams);
        }

        public int SaveAndSignMIVDocument(SaveMIV saveMIV, SignMIV signMIV)
        {
            var sqlParams = new SqlParameter[]
               {
                new SqlParameter("DocumentId",saveMIV.DocumentId),
                new SqlParameter("ProjectId",saveMIV.ProjectId),
                new SqlParameter("UserId",saveMIV.UserId),
                new SqlParameter("ContractId",saveMIV.ContractId),
                new SqlParameter("CompanyId",saveMIV.CompanyId),
                new SqlParameter("ContractorId",saveMIV.ContractorId),
                new SqlParameter("Remark",saveMIV.Remark),
                new SqlParameter("MIVItems", saveMIV.MIVItems),
                new SqlParameter("SignRequestType",signMIV.SignType.ToString()),
                new SqlParameter("NextRole",signMIV.NextRole),
                new SqlParameter("MachineName",signMIV.MachineName),
                new SqlParameter("ActiveDirectoryName",signMIV.ActiveDirectoryName)
               };
            return DoMutation("EL.SaveAndSignMIVDocument", sqlParams);
        }
        #endregion

        #region PackingList
        public dynamic GetPackingDocuments(int projectId,int userId,int companyId, int? id = null)
        {
            try
            {
                dynamic data = null;
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter("ProjectId",projectId),
                    new SqlParameter("UserId",userId),
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
        public DataTable GetMIVItemsByDocumentId(int? documentId)
        {
            try
            {
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter("DocumentId",documentId)
                };
                return DoQueryReader("EL.GetMIVItemsByDocumentId", sqlParams);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region MTO
        public dynamic GetMtos(int? mtoId = null)
        {
            try
            {
                dynamic data = null;
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter("Id",mtoId),
                };
                data = DoQueryReader("EL.GetMTOS", sqlParams);
                if (data.Rows.Count > 0 && mtoId != null) return data.Rows[0] as DataRow;
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }



        public int SaveMTO(int? id,int projectId, int userId,int unitId,int itemCodeId, decimal mtoQty,string description)
        {
            try
            {
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter("Id",id),
                    new SqlParameter("ProjectId",projectId),
                    new SqlParameter("UserId",userId),
                    new SqlParameter("UnitId",unitId),
                    new SqlParameter("ItemCodeId",itemCodeId),
                    new SqlParameter("MtoQty",mtoQty),
                    new SqlParameter("Description",description),
                };
                return DoMutation("EL.SaveMTO", sqlParams);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int DeleteMTO(int projectId, int userId,int mtoId)
        {
            try
            {
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter("Id",mtoId),
                    new SqlParameter("ProjectId",projectId),
                    new SqlParameter("UserId",userId),
                };
                return DoMutation("EL.DeleteMTO", sqlParams);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Monitoring
        public DataTable GetMonitoring(int projectId, int userId, int companyId)
        {
            try
            {
                var sqlParams = new SqlParameter[]
                {                    
                    new SqlParameter("ProjectId",projectId),
                    new SqlParameter("UserId",userId),
                    new SqlParameter("CompanyId",companyId)
                };
                return DoQueryReader("EL.GetMonitoring", sqlParams);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
