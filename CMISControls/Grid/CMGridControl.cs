using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace CMISControls.Grid
{
    public class CMGridControl:GridControl
    {
        public event EventHandler DataLoaded;


        BackgroundWorker AnimationBW = new BackgroundWorker();
        BackgroundWorker DataThread = new BackgroundWorker();
        int currentAngle = 0;
        private bool ShowLoading = false;
        public CMGridControl()
        {
            this.GetType().GetMethod("SetStyle",
            System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.NonPublic).Invoke(this,
                new object[]
            {
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.DoubleBuffer, true
            });

            AnimationBW.DoWork += AnimationBW_DoWork;
            DataThread.DoWork += DataThread_DoWork;
            DataThread.RunWorkerCompleted += DataThread_RunWorkerCompleted;

        }
        private void DataThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowLoading = false;
            Invalidate();
        }

        private void AnimationBW_DoWork(object sender, DoWorkEventArgs e)
        {
            while(ShowLoading){
                currentAngle += 30;
                PaintLoadingProgress();
                Thread.Sleep(100);
            }
        }

        private void DataThread_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] argumants = (object[])e.Argument;
            Func<object> action = (Func<object>)argumants[0];
            var data = action.Invoke();
            Thread thread = new Thread(() => {               
                if (this.InvokeRequired)
                    this.Invoke(new Action(() => { 
                        this.DataSource = data;
                        OnDataLoaded(this, EventArgs.Empty);
                    }));
            });
            thread.Start();
        }

        public void OnDataLoaded(object sender,EventArgs e)
        {
            this.DataLoaded?.Invoke(sender,e);
        }

        private void PaintLoadingProgress()
        {
            using (Graphics graphic = CreateGraphics()) {
                int cursorSize = 50;
                int cursorX = (Width / 2) - (cursorSize / 2);
                int cursorY = (Height / 2) - (cursorSize / 2);
                int brushWidth = 4;              
                graphic.SmoothingMode = SmoothingMode.AntiAlias;
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(235, 235, 235)))
                {
                    using (Pen pen = new Pen(brush, brushWidth))
                    {
                        graphic.DrawArc(pen, cursorX, cursorY, cursorSize, cursorSize, 0, 360);
                    }
                }

                using (SolidBrush brush = new SolidBrush(this.LoadingColor))
                {
                    if(this.LoadingStyle == LoadingStyle.Solid)
                    {
                        using (Pen pen = new Pen(brush, brushWidth - 1))
                        {
                            graphic.DrawArc(pen, cursorX, cursorY, cursorSize, cursorSize, currentAngle, 135);
                        }
                    }
                    if (this.LoadingStyle == LoadingStyle.Dashed)
                    {
                        using (Pen pen = new Pen(brush, brushWidth))
                        {
                            pen.DashStyle = DashStyle.Dash;
                            pen.DashPattern = new float[] { 0.5F, 0.8F, 0.5F, 0.8F, 0.5F, 0.8F, 0.5F, 0.8F };
                            graphic.DrawArc(pen, cursorX, cursorY, cursorSize, cursorSize, currentAngle, 135);
                        }
                    }
                }

                using (SolidBrush drawBrush = new SolidBrush(LoadingColor))
                {
                    String drawString = "CMIS";
                    Font drawFont = new Font("Times New Roman", 10);
                    StringFormat drawFormat = new StringFormat();
                    graphic.DrawString(drawString, drawFont, drawBrush, cursorX+6, cursorY+18, drawFormat);
                }

            }
        }

        public void SetDataSource(Func<object> actionData)
        {
            ShowLoading = true;
            AnimationBW.RunWorkerAsync();
            object[] args = new object[] { actionData };
            DataThread.RunWorkerAsync(args);
            
        }


        private LoadingStyle loadingStyle;

        public LoadingStyle LoadingStyle
        {
            get { return loadingStyle; }
            set { loadingStyle = value; }
        }

        private Color loadingColor = Color.Black;

        public Color LoadingColor
        {
            get {
                return loadingColor;
            }
            set { loadingColor = value; }
        }


    }
}
