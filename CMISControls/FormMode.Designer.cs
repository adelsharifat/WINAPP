namespace CMISControl
{
    partial class FormMode
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
            this.lblFormState = new System.Windows.Forms.Label();
            this.lblDraft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFormState
            // 
            this.lblFormState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFormState.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormState.Location = new System.Drawing.Point(0, 0);
            this.lblFormState.Name = "lblFormState";
            this.lblFormState.Size = new System.Drawing.Size(122, 35);
            this.lblFormState.TabIndex = 0;
            this.lblFormState.Text = "VIEW STATE";
            this.lblFormState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDraft
            // 
            this.lblDraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblDraft.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDraft.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraft.ForeColor = System.Drawing.Color.White;
            this.lblDraft.Location = new System.Drawing.Point(122, 0);
            this.lblDraft.Name = "lblDraft";
            this.lblDraft.Size = new System.Drawing.Size(98, 35);
            this.lblDraft.TabIndex = 1;
            this.lblDraft.Text = "DRAFT";
            this.lblDraft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDraft.Visible = false;
            // 
            // FormMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFormState);
            this.Controls.Add(this.lblDraft);
            this.Name = "FormMode";
            this.Size = new System.Drawing.Size(220, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormState;
        private System.Windows.Forms.Label lblDraft;
    }
}
