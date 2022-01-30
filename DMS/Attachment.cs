using CMISDAL.Base;
using CMISUIHelper.Infrastructure.Helpers;
using CMISUtils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS
{
    public class Attachment:APPDAL
    {
        public static Attachment Do { get; private set; } = new Attachment();

        private const string OFD_FILTER_EXTENTION = "Ms Word 2007 (*.docx)|*.docx,Ms Word 2003 (*.doc)|*.doc,Rich Text Format (RTF)|*.rtf";
        private const string FILE_ATTACHMENT_LABEL_DESCRIPTION = "[No files attached]";
        #region FileHandler
        public DataRow GetFileContentFromDb(string procedure, string fileTableName, int attachmentId)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@FileTableName",fileTableName),
                    new SqlParameter("@AttachmentId",attachmentId),
                };

                var dt = DoQueryReader(procedure, parameters);

                if (dt != null)
                    return dt.Rows[0];

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public byte[] GetByteFromFile(string filePath)
        {
            try
            {
                return File.ReadAllBytes(filePath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private const FileOptions FILE_FLAG_NO_BUFFERING = (FileOptions)0x20000000;

        public void RunAttachment(byte[] fileByte, string fileName, string startPath)
        {
            Process proc = null;
            try
            {

                var fullPath = Path.Combine(startPath, $"{Guid.NewGuid().ToString("N").Substring(1, 10)}-{fileName}");
                File.WriteAllBytes(fullPath, fileByte);

                if (proc == null)
                    proc = new Process();

                proc.StartInfo.FileName = fullPath;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        public void RunFromLocal(string fullPath)
        {
            Process proc = new Process();
            try
            {

                if (!File.Exists(fullPath))
                    return;

                proc.StartInfo.FileName = fullPath;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        public DataTable GetAttchment(string procedureName, int projectId, string objectName, int objectId, string fileTableName)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@ProjectId",projectId),
                    new SqlParameter("@ObjectName",objectName),
                    new SqlParameter("@ObjectId",objectId),
                    new SqlParameter("@FileTableName",fileTableName)
                };
                return DoQueryReader(procedureName, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAttchmentwithFileColumn(int projectId, string objectName, int objectId, string fileTableName)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@ProjectId",projectId),
                    new SqlParameter("@ObjectName",objectName),
                    new SqlParameter("@ObjectId",objectId),
                    new SqlParameter("@FileTableName",fileTableName)
                };
                return DoQueryReader("CM.NewFetchAttachments", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Attachment Handler    
        public GridControl AddAttachmentToGrid(
            List<FileAttachmentViewModel> fileAttachmentList,
            GridControl attachmentGrid,
            string filePath,
            string userFullName,
            string fileName,
            string remark,
            string customType,
            string type,
            string showLable = "Show"
            )
        {
            try
            {
                var fileExtention = Path.GetExtension(filePath);
                fileName = fileName + fileExtention;
                FileAttachmentViewModel fileAttachment = new FileAttachmentViewModel
                {
                    Id = 0,
                    stream_id = Guid.NewGuid(),
                    FileStream = GetByteFromFile(filePath),
                    FileName = fileName,
                    Remark = remark,
                    Type = type,
                    CustomType = customType,
                    CreatedDate = DateTime.Now,
                    User = userFullName,
                    FilePath = filePath,
                    File = showLable
                };

                fileAttachmentList.Add(fileAttachment);
                FillAttachmentGrid(fileAttachmentList, attachmentGrid);

                var grv = attachmentGrid.MainView as GridView;
                var showColumn = grv.Columns["File"] as GridColumn;
                showColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                return attachmentGrid;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void FillAttachmentGrid(List<FileAttachment> fileAttachmentList, GridControl gridControl)
        {
            try
            {
                if (fileAttachmentList.Count >= 0)
                {
                    gridControl.DataSource = fileAttachmentList.Select(x => new {
                        Id = x.Id,
                        FileName = x.FileName,
                        CustomType = x.CustomType,
                        Remark = x.Remark,
                        User = x.User,
                        CreatedDate = x.CreatedDate,
                        FilePath = x.FilePath,
                        FileTableName = x.FileTableName
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public GridControl FillAttachmentGrid(List<FileAttachmentViewModel> fileAttachmentList, GridControl gridControl)
        {
            try
            {
                if (fileAttachmentList.Count >= 0)
                {
                    gridControl.DataSource = fileAttachmentList.Select(x => new {
                        File = x.File,
                        Id = x.Id,
                        FileName = x.FileName,
                        CustomType = x.CustomType,
                        Remark = x.Remark,
                        User = x.User,
                        CreatedDate = x.CreatedDate,
                        FilePath = x.FilePath,
                        FileTableName = x.FileTableName

                    }).ToList();

                    RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit = new RepositoryItemHyperLinkEdit();
                    repositoryItemHyperLinkEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                    (gridControl.MainView as GridView).Columns["File"].ColumnEdit = repositoryItemHyperLinkEdit;
                }

                return gridControl;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ShowFileAttachment(string procedureName, RowCellClickEventArgs e, GridControl gridControl, string dumpFilesPath)
        {
            try
            {
                // Hey CMIS TEAm You can use this code for get temp folder of user ==> Path.GetTempPath() but you want use this path for static => C:/dump
                if (e.Column != null && (e.Column.Name == "ShowFile" || e.Column.Name == "colShowFile"))
                {
                    Application.UseWaitCursor = true;
                    var GV = gridControl.MainView as GridView;

                    var fileId = Convert.ToInt32(GV.GetCellValue("Id"));
                    if (fileId == 0)
                        RunFromLocal(GV.GetCellValue("FilePath").ToString());
                    else
                    {
                        string fileTableName = GV.GetCellValue("FileTableName").ToString();
                        var fileStreamFromDb = GetFileContentFromDb(procedureName, fileTableName, fileId);
                        if (fileStreamFromDb != null)
                        {
                            string fileName = GV.GetCellValue("FileName").ToString();
                            byte[] fileContent = fileStreamFromDb.ToByteArray("file_stream");
                            if (fileContent != null)
                            {
                                RunAttachment(fileContent, fileName, dumpFilesPath);
                                Application.UseWaitCursor = false;
                            }
                        }
                    }
                    Application.UseWaitCursor = false;
                }
            }
            catch (Exception ex)
            {
                Application.UseWaitCursor = false;
                throw ex;
            }
        }
        public void ShowAttachment(RowCellClickEventArgs e, GridControl gridControl, string dumpFilesPath)
        {
            try
            {
                // Hey CMIS TEAm You can use this code for get temp folder of user ==> Path.GetTempPath() but you want use this path for static => C:/dump
                if (e.Column != null && e.Column.FieldName == "File")
                {
                    Application.UseWaitCursor = true;
                    var GV = gridControl.MainView as GridView;

                    var fileId = Convert.ToInt32(GV.GetCellValue("Id"));
                    if (fileId == 0)
                        RunFromLocal(GV.GetCellValue("FilePath").ToString());
                    else
                    {
                        string fileTableName = GV.GetCellValue("FileTableName").ToString();
                        var fileStreamFromDb = GetFileContentFromDb("CM.FetchFileStream", fileTableName, fileId);
                        if (fileStreamFromDb != null)
                        {
                            string fileName = GV.GetCellValue("FileName").ToString();
                            byte[] fileContent = fileStreamFromDb.ToByteArray("file_stream");
                            if (fileContent != null)
                            {
                                RunAttachment(fileContent, fileName, dumpFilesPath);
                                Application.UseWaitCursor = false;
                            }
                        }
                    }
                    Application.UseWaitCursor = false;
                }
            }
            catch (Exception ex)
            {
                Application.UseWaitCursor = false;
                throw ex;
            }
        }
        public void ResetAttachmentControls(params Control[] controls)
        {
            foreach (var item in controls)
            {
                if (item is TextBox)
                    item.Text = String.Empty;

                if (item is System.Windows.Forms.ComboBox)
                    ((System.Windows.Forms.ComboBox)item).SelectedIndex = 0;

                if (item is TextEdit)
                    item.Text = String.Empty;
            }
        }
        public void OpenFileDialog(Control filePathTextBox,Control txtRemark = null,string additinalOpenFileDialogFilter = null)
        {
            try
            {
                string openFileDialogFilter = OFD_FILTER_EXTENTION;
                if (!String.IsNullOrEmpty(additinalOpenFileDialogFilter))
                {
                    openFileDialogFilter = $"{openFileDialogFilter},{additinalOpenFileDialogFilter}";
                }

                openFileDialogFilter = $"{openFileDialogFilter},{"All File(*.*)| *.*"}"; 
               var ofd = CMISUI.OpenFDG(openFileDialogFilter.Split(','));
                if (ofd != null)
                {
                    filePathTextBox.Text = ofd?.FileName;
                    if(txtRemark != null)
                    {
                        txtRemark.Text = Path.GetFileName(ofd?.FileName);
                        txtRemark.Select();
                        txtRemark.Focus();
                    }                        
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ClearAttachmentFromGrid(GridControl gc, List<FileAttachment> fileAttachmentList)
        {

            try
            {
                var gv = gc.MainView as GridView;
                if (gv.SelectedRowsCount > 0)
                {
                    if (Msg.Confirm("Are you sure to remove all the content from the below list?", "Confirm Message") == DialogResult.Yes)
                    {
                        var selectedRow = gv.GetSelectedRows();
                        foreach (var index in selectedRow)
                        {
                            var fileName = gv.GetRowCellValue(index, "FileName");
                            var fileAttachment = fileAttachmentList.FirstOrDefault(x => x.FileName == fileName.ToString());
                            fileAttachmentList.Remove(fileAttachment);
                        }
                        FillAttachmentGrid(fileAttachmentList, gc);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void ClearAttachmentFromGrid(GridControl gc, List<FileAttachmentViewModel> fileAttachmentList)
        {

            try
            {
                var gv = gc.MainView as GridView;
                if (gv.SelectedRowsCount > 0)
                {
                    if (Msg.Confirm("Are you sure to remove all the content from the below list?", "Confirm Message") == DialogResult.Yes)
                    {
                        var selectedRow = gv.GetSelectedRows();
                        foreach (var index in selectedRow)
                        {
                            var fileName = gv.GetRowCellValue(index, "FileName");
                            var fileAttachment = fileAttachmentList.FirstOrDefault(x => x.FileName == fileName.ToString());
                            fileAttachmentList.Remove(fileAttachment);
                        }
                        FillAttachmentGrid(fileAttachmentList, gc);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
    }
}
