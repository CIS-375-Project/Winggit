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
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.dgdReportTable = new System.Windows.Forms.DataGridView();
            this.lblReportType = new System.Windows.Forms.Label();
            this.btnGetReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdReportTable)).BeginInit();
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
            // cmbReportType
            // 
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Location = new System.Drawing.Point(12, 217);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(121, 21);
            this.cmbReportType.TabIndex = 2;
            // 
            // dgdReportTable
            // 
            this.dgdReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdReportTable.Location = new System.Drawing.Point(16, 12);
            this.dgdReportTable.Name = "dgdReportTable";
            this.dgdReportTable.Size = new System.Drawing.Size(485, 156);
            this.dgdReportTable.TabIndex = 3;
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Location = new System.Drawing.Point(13, 198);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(66, 13);
            this.lblReportType.TabIndex = 4;
            this.lblReportType.Text = "Report Type";
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(12, 366);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(75, 23);
            this.btnGetReport.TabIndex = 5;
            this.btnGetReport.Text = "Get Report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelReports;
            this.ClientSize = new System.Drawing.Size(510, 401);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.dgdReportTable);
            this.Controls.Add(this.cmbReportType);
            this.Controls.Add(this.btnCancelReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdReportTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelReports;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.DataGridView dgdReportTable;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.Button btnGetReport;
    }
}