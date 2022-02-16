using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMISUIHelper.UserControls;
using CMISUIHelper.Infrastructure.Helpers;
using DevExpress.XtraBars;
using CMISUIHelper.Infrastructure.Enums;
using Electrical.Data;
using Security;
using CMISUtils.Extentions;
using CMISUIHelper.Infrastructure.Contracts.CustomException;
using DevExpress.XtraGrid.Views.Grid;
using CMISUtils;

namespace Electrical.View
{
    public partial class MTO : ViewTab
    {
        private int? mtoId = null;
        private BarItem btnNew, btnSave, btnEdit, btnDelete;

        public MTO()
        {
            InitializeComponent();
            ViewTitle = "MTO";
            ShowRefreshItem = true;
            Grid = grcMTO;
        }

        private void MTO_BeforeViewLoad(object sender, EventArgs e)
        {

        }

        private void MTO_ViewLoaded(object sender, EventArgs e)
        {
            try
            {
                FillMtoGrid();
                FillCboUnit();
                FillCboItemCode();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void MTO_ViewRefresh(object sender, EventArgs e)
        {

        }

        private void MTO_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            btnNew = e.RibbonPage.AddNewFormActionTool(this);
            btnSave = e.RibbonPage.AddSaveFormActionTool(this);
            btnEdit = e.RibbonPage.AddEditFormActionTool(this);
            btnDelete = e.RibbonPage.AddDeleteFormActionTool(this);

            e.RibbonPage.AddGridTools(this);
            e.RibbonPage.AddExcelExportTool(this);


            btnNew.ItemClick += BtnNew_ItemClick;
            btnSave.ItemClick += BtnSave_ItemClick;
            btnEdit.ItemClick += BtnEdit_ItemClick;
            btnDelete.ItemClick += BtnDelete_ItemClick;


        }

        private void ResetForm()
        {
            try
            {
                FormMode = FormState.Save;
                this.mtoId = null;
                cboUnit.SelectItem(0);
                cboItemCode.SelectItem(0);
                txtMTOQty.Text = "0.00";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ChangeFormState()
        {
            try
            {
                if(FormMode == FormState.View)
                {

                }

                if (FormMode == FormState.Edit)
                {

                }

                if (FormMode == FormState.Save)
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ResetForm();
        }
        
        private void BtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //Validation Form
                if (String.IsNullOrEmpty(txtMTOQty.Text) || txtMTOQty.Text.ToDecimal() == 0m) throw new CMISException("MtoQty field invalid!");
                if (Msg.Confirm("Are you sure to save data?") == DialogResult.No) return;
                var result = DAL.Do.SaveMTO(mtoId,LoginInfo.ProjectId, LoginInfo.Id,cboUnit.EditValue.ToInt(), cboItemCode.EditValue.ToInt(), txtMTOQty.Text.ToDecimal());
                if (result <= 0) throw new CMISException("Operation faild!");
                Msg.Show("Operation succeded!");
                ResetForm();
                FillMtoGrid();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void BtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(GridDefaultView.GetFocusedDataRow() is DataRow dr)
            {
                var deleted = dr?.IsDelete();
                if (deleted == null || deleted == true) return;
                this.mtoId = dr?.Id("MtoId");                
                if (this.mtoId == null) return;
                var dbMtoRow = DAL.Do.GetMtos(this.mtoId) as DataRow;
                if (dbMtoRow == null) return;
                cboItemCode.EditValue = dbMtoRow["ItemCodeId"].ToInt();
                cboUnit.EditValue = dbMtoRow["UnitId"].ToInt();
                txtMTOQty.Text = dbMtoRow["MtoQty"].ToDecimal().ToString();
            }
        }

        private void BtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                
                if(grvMTO.GetFocusedDataRow() is DataRow dr)
                {
                    if (dr.IsDelete()) return;
                    if (Msg.Confirm("Are you sure to delete selected mto data") == DialogResult.No) return;
                    var result = DAL.Do.DeleteMTO(LoginInfo.ProjectId, LoginInfo.Id, dr.Id("MtoId"));
                    if (result <= 0) throw new CMISException("Operation Faild!");
                    Msg.Show("Operation Secceded!");
                    FillMtoGrid();
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }


        private void grvMTO_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                //if((sender as GridView).GetDataRow(e.FocusedRowHandle) is DataRow dr)
                //{
                //    txtMTOQty.Text = dr["MtoQty"]?.ToDecimal().ToString();
                //    cboItemCode.EditValue = dr["ItemCodeId"].ToInt();
                //    cboUnit.EditValue = dr["UnitId"].ToInt();
                //}
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        delegate void SetDataCallback();
        private void FillMtoGrid()
        {
            try
            {
                var data = DAL.Do.GetMtos();

                grcMTO.SetDataSource(() => data);
                GridDefaultView.SetConditionRowFormat("IsDelete", "[IsDelete]=1", new DevExpress.Utils.AppearanceDefault { BackColor = System.Drawing.Color.FromArgb(255, 224, 234), Font = new System.Drawing.Font(Font, System.Drawing.FontStyle.Italic) });

            }
            catch (Exception)
            {
                throw;
            }
        }


        private void FillCboItemCode()
        {
            try
            {
                var data = DAL.Do.GetItemCodesCombo();
                cboItemCode.Fill(data, "ItemCode", "Id").SelectItem(0);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void FillCboUnit()
        {
            try
            {
                var data = CMISDAL.Common.CommonDals.Do.AreaUnit.FetchAreaUnitCombo(LoginInfo.ProjectId);
                cboUnit.Fill(data,"FullName","Id").SelectItem(0);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
