namespace Winggit.Forms
{
    partial class frmReports
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.btnCancelReports = new System.Windows.Forms.Button();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelReports
            // 
            this.btnCancelReports.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelReports.Location = new System.Drawing.Point(423, 366);
            this.btnCancelReports.Name = "btnCancelReports";
            this.btnCancelReports.Size = new System.Drawing.Size(75, 23);
            this.btnCancelReports.TabIndex = 0;
            this.btnCancelReports.Text = "Cancel";
            this.btnCancelReports.UseVisualStyleBackColor = true;
            this.btnCancelReports.Click += new System.EventHandler(this.btnCancelReports_Click);
            // 
            // rptViewer
            // 
            this.rptViewer.Location = new System.Drawing.Point(12, 31);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.Size = new System.Drawing.Size(486, 180);
            this.rptViewer.TabIndex = 1;
            // 
            // cmbReportType
            // 
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Location = new System.Drawing.Point(12, 217);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(121, 21);
            this.cmbReportType.TabIndex = 2;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelReports;
            this.ClientSize = new System.Drawing.Size(510, 401);
            this.Controls.Add(this.cmbReportType);
            this.Controls.Add(this.rptViewer);
            this.Controls.Add(this.btnCancelReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelReports;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private System.Windows.Forms.ComboBox cmbReportType;
    }
}