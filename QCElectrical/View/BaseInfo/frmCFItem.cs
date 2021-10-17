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
using QCElectrical.Data;
using CMISUtils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.DragDrop;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Security;
using CMISUIHelper.Infrastructure.Contracts.CustomException;
using DevExpress.XtraBars;

namespace QCElectrical.View.BaseInfo
{
    public partial class frmCFItem : ViewTab
    {
        DataTable data = null;
        public frmCFItem()
        {
            InitializeComponent();
            ViewTitle = "CF Item";
        }

        private void frmCFItem_ViewLoaded(object sender, EventArgs e)
        {
            try
            {
                FillCmbCF();
                grvCFItem.SetConditionRowFormat("IsDelete", "[IsDelete] = 1", "Red Fill, Red Text");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void FillCmbCF()
        {
            try
            {
                var data = DAL.Do.FetchCFCombo();
                cmbCF.Fill(data, "Name", "Id").HideColumns("FullName,Description");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void cmbCF_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                FillList();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void FillList()
        {
            try
            {
                var cfFullName = cmbCF.GetColumnValue("FullName").ToString();
                lblSelectedCF.Text = $"{cfFullName}";
                data = DAL.Do.FetchCFItems(cmbCF.GetValue());
                grcCFItem.DataSource = data;

                grcCFItem.EditableColumns("Order").HideColumns("Id,CFTypeId,IsDelete,CreatedBy");
                grvCFItem.Columns["Order"].AppearanceCell.BackColor = Color.LightYellow;
                HandleBehaviorDragDropEvents();

            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void frmCFItem_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            try
            {
                Dictionary<string, BarItem> items = null;
                e.RibbonPage.AddFormTools(this,out items);

                items["save"].ItemClick += SaveItem_ItemClick;
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void SaveItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Msg.Show("Save Item Clicke worked!");
        }

        private void btnAddCFItemToList_Click(object sender, EventArgs e)
        {
            try
            {
                int order = grcCFItem.GetLastVisibleRowHandle() + 1;
                var cmbCFValue = cmbCF.GetValue();

                if (String.IsNullOrEmpty(txtName.Text)) throw new CMISException("The name field is required!");
                if (cmbCF.ItemIndex < 0) throw new CMISException("Please select CFItem from CF type list");
                
                
                if(data?.Rows?.Count > 0)
                    foreach (DataRow row in data.Rows)
                        if (row["Name"].ToString() == txtName.Text.Trim())
                            throw new CMISException($"The name already exist in the list!");

                data.Rows.Add(new object[] {"...", 0, LoginInfo.Id, 0, txtName.Text.Trim(), cmbCF.GetColumnValue("FullName").ToString(), order , LoginInfo.FullName, DateTime.Now });
                grcCFItem.DataSource = data;
                txtName.Reset();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }


        // drag and drop row for ordering
        public void HandleBehaviorDragDropEvents()
        {
            try
            {
                DragDropBehavior gridControlBehavior = behaviorManager.GetBehavior<DragDropBehavior>(this.grvCFItem);

                gridControlBehavior.DragDrop += Behavior_DragDrop;
                gridControlBehavior.DragOver += Behavior_DragOver;
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        private void Behavior_DragOver(object sender, DragOverEventArgs e)
        {
            try
            {
                DragOverGridEventArgs args = DragOverGridEventArgs.GetDragOverGridEventArgs(e);
                e.InsertType = args.InsertType;
                e.InsertIndicatorLocation = args.InsertIndicatorLocation;
                e.Action = args.Action;
                Cursor.Current = args.Cursor;
                args.Handled = true;
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        private void Behavior_DragDrop(object sender, DevExpress.Utils.DragDrop.DragDropEventArgs e)
        {
            try
            {
                GridView targetGrid = e.Target as GridView;
                GridView sourceGrid = e.Source as GridView;
                if (e.Action == DragDropActions.None || targetGrid != sourceGrid)
                    return;
                DataTable sourceTable = sourceGrid.GridControl.DataSource as DataTable;

                Point hitPoint = targetGrid.GridControl.PointToClient(Cursor.Position);
                GridHitInfo hitInfo = targetGrid.CalcHitInfo(hitPoint);

                int[] sourceHandles = e.GetData<int[]>();

                int targetRowHandle = hitInfo.RowHandle;
                int targetRowIndex = targetGrid.GetDataSourceRowIndex(targetRowHandle);

                List<DataRow> draggedRows = new List<DataRow>();
                foreach (int sourceHandle in sourceHandles)
                {
                    int oldRowIndex = sourceGrid.GetDataSourceRowIndex(sourceHandle);
                    DataRow oldRow = sourceTable.Rows[oldRowIndex];
                    draggedRows.Add(oldRow);
                }

                int newRowIndex;

                switch (e.InsertType)
                {
                    case InsertType.Before:
                        newRowIndex = targetRowIndex > sourceHandles[sourceHandles.Length - 1] ? targetRowIndex - 1 : targetRowIndex;
                        for (int i = draggedRows.Count - 1; i >= 0; i--)
                        {
                            DataRow oldRow = draggedRows[i];
                            DataRow newRow = sourceTable.NewRow();
                            newRow.ItemArray = oldRow.ItemArray;
                            sourceTable.Rows.Remove(oldRow);
                            sourceTable.Rows.InsertAt(newRow, newRowIndex);
                        }
                        break;
                    case InsertType.After:
                        newRowIndex = targetRowIndex < sourceHandles[0] ? targetRowIndex + 1 : targetRowIndex;
                        for (int i = 0; i < draggedRows.Count; i++)
                        {
                            DataRow oldRow = draggedRows[i];
                            DataRow newRow = sourceTable.NewRow();
                            newRow.ItemArray = oldRow.ItemArray;
                            sourceTable.Rows.Remove(oldRow);
                            sourceTable.Rows.InsertAt(newRow, newRowIndex);
                        }
                        break;
                    default:
                        newRowIndex = -1;
                        break;
                }
                int insertedIndex = targetGrid.GetRowHandle(newRowIndex);
                targetGrid.FocusedRowHandle = insertedIndex;
                targetGrid.SelectRow(targetGrid.FocusedRowHandle);

                GridViewInfo viewInfo = targetGrid.GetViewInfo() as GridViewInfo;
                int order = -1;
                foreach (GridRowInfo rowInfo in viewInfo.RowsInfo)
                {
                    order += 1;
                    targetGrid.SetRowCellValue(rowInfo.RowHandle, "Order", order);
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    btnAddCFItemToList_Click(sender, e);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void cmbCF_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (data != null && Msg.Confirm("Do you want to save change?") == DialogResult.Yes)
                    SaveCFItems();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void SaveCFItems()
        {
            // Save Logic
        }

        private void btnDeleteCFItemToolStrip_Click(object sender, EventArgs e)
        {
            try
            {
                var val = Convert.ToBoolean(grvCFItem.GetCellValue("IsDelete"));
                grvCFItem.SetRowCellValue(grvCFItem.FocusedRowHandle, "IsDelete", !val);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void frmCFItem_ViewRefresh(object sender, EventArgs e)
        {

        }
    }
}
