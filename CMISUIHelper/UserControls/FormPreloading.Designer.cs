
namespace CMISUIHelper.UserControls
{
    partial class FormPreloading
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrograssBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // PrograssBar
            // 
            this.PrograssBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrograssBar.Location = new System.Drawing.Point(0, 1);
            this.PrograssBar.Name = "PrograssBar";
            this.PrograssBar.Size = new System.Drawing.Size(150, 2);
            this.PrograssBar.Step = 1;
            this.PrograssBar.TabIndex = 1;
            this.PrograssBar.Visible = false;
            // 
            // FormPreloading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.PrograssBar);
            this.Name = "FormPreloading";
            this.Size = new System.Drawing.Size(153, 6);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar PrograssBar;
    }
}
