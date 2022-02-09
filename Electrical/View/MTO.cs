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

namespace Electrical.View
{
    public partial class MTO : ViewTab
    {
        private BarItem btnNew, btnSave, btnEdit, btnDelete;

        public MTO()
        {
            InitializeComponent();
            ViewTitle = "MTO";
            ShowRefreshItem = true;
        }

        private void MTO_BeforeViewLoad(object sender, EventArgs e)
        {

        }

        private void MTO_ViewLoaded(object sender, EventArgs e)
        {

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
            throw new NotImplementedException();
        }

        private void BtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
