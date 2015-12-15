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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.btnCancelReports = new System.Windows.Forms.Button();
            this.dgdReportTable = new System.Windows.Forms.DataGridView();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.tbcReportType = new System.Windows.Forms.TabControl();
            this.tabTags = new System.Windows.Forms.TabPage();
            this.lblTagRptCity = new System.Windows.Forms.Label();
            this.txtTagRptCity = new System.Windows.Forms.TextBox();
            this.lblTagRptStateProv = new System.Windows.Forms.Label();
            this.cmbTagRptStateProv = new System.Windows.Forms.ComboBox();
            this.lblTagRptCountry = new System.Windows.Forms.Label();
            this.cmbTagsRptCountry = new System.Windows.Forms.ComboBox();
            this.calTagsRptDate = new System.Windows.Forms.MonthCalendar();
            this.tabSightings = new System.Windows.Forms.TabPage();
            this.lblSightRptCity = new System.Windows.Forms.Label();
            this.txtSightRptCity = new System.Windows.Forms.TextBox();
            this.lblSightRptStateProv = new System.Windows.Forms.Label();
            this.cmbSightRptStateProv = new System.Windows.Forms.ComboBox();
            this.lblSightRptCountry = new System.Windows.Forms.Label();
            this.cmbSightRptCountry = new System.Windows.Forms.ComboBox();
            this.calSightingsRptDate = new System.Windows.Forms.MonthCalendar();
            this.tabRoutes = new System.Windows.Forms.TabPage();
            this.lblReportRouteID = new System.Windows.Forms.Label();
            this.txtReportRouteID = new System.Windows.Forms.TextBox();
            this.tabPeaks = new System.Windows.Forms.TabPage();
            this.lblPeaksID = new System.Windows.Forms.Label();
            this.txtPeaksID = new System.Windows.Forms.TextBox();
            this.tabHeatmap = new System.Windows.Forms.TabPage();
            this.btnOutput = new System.Windows.Forms.Button();
            this.cTags = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgdReportTable)).BeginInit();
            this.tbcReportType.SuspendLayout();
            this.tabTags.SuspendLayout();
            this.tabSightings.SuspendLayout();
            this.tabRoutes.SuspendLayout();
            this.tabPeaks.SuspendLayout();
            this.tabHeatmap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTags)).BeginInit();
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
            // dgdReportTable
            // 
            this.dgdReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdReportTable.Location = new System.Drawing.Point(16, 12);
            this.dgdReportTable.Name = "dgdReportTable";
            this.dgdReportTable.Size = new System.Drawing.Size(485, 131);
            this.dgdReportTable.TabIndex = 3;
            // 
            // btnGetReport
            // 
            this.btnGetReport.Enabled = false;
            this.btnGetReport.Location = new System.Drawing.Point(12, 366);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(75, 23);
            this.btnGetReport.TabIndex = 5;
            this.btnGetReport.Text = "Get Report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // tbcReportType
            // 
            this.tbcReportType.Controls.Add(this.tabTags);
            this.tbcReportType.Controls.Add(this.tabSightings);
            this.tbcReportType.Controls.Add(this.tabRoutes);
            this.tbcReportType.Controls.Add(this.tabPeaks);
            this.tbcReportType.Controls.Add(this.tabHeatmap);
            this.tbcReportType.Location = new System.Drawing.Point(16, 149);
            this.tbcReportType.Name = "tbcReportType";
            this.tbcReportType.SelectedIndex = 0;
            this.tbcReportType.Size = new System.Drawing.Size(482, 211);
            this.tbcReportType.TabIndex = 6;
            this.tbcReportType.SelectedIndexChanged += new System.EventHandler(this.tbcReportType_SelectedIndexChanged);
            // 
            // tabTags
            // 
            this.tabTags.Controls.Add(this.lblTagRptCity);
            this.tabTags.Controls.Add(this.txtTagRptCity);
            this.tabTags.Controls.Add(this.lblTagRptStateProv);
            this.tabTags.Controls.Add(this.cmbTagRptStateProv);
            this.tabTags.Controls.Add(this.lblTagRptCountry);
            this.tabTags.Controls.Add(this.cmbTagsRptCountry);
            this.tabTags.Controls.Add(this.calTagsRptDate);
            this.tabTags.Location = new System.Drawing.Point(4, 22);
            this.tabTags.Name = "tabTags";
            this.tabTags.Padding = new System.Windows.Forms.Padding(3);
            this.tabTags.Size = new System.Drawing.Size(474, 185);
            this.tabTags.TabIndex = 0;
            this.tabTags.Text = "Tags";
            this.tabTags.UseVisualStyleBackColor = true;
            // 
            // lblTagRptCity
            // 
            this.lblTagRptCity.AutoSize = true;
            this.lblTagRptCity.Location = new System.Drawing.Point(282, 109);
            this.lblTagRptCity.Name = "lblTagRptCity";
            this.lblTagRptCity.Size = new System.Drawing.Size(27, 13);
            this.lblTagRptCity.TabIndex = 6;
            this.lblTagRptCity.Text = "City:";
            // 
            // txtTagRptCity
            // 
            this.txtTagRptCity.Location = new System.Drawing.Point(282, 128);
            this.txtTagRptCity.Name = "txtTagRptCity";
            this.txtTagRptCity.Size = new System.Drawing.Size(121, 20);
            this.txtTagRptCity.TabIndex = 5;
            this.txtTagRptCity.TextChanged += new System.EventHandler(this.txtTagRptCity_TextChanged);
            // 
            // lblTagRptStateProv
            // 
            this.lblTagRptStateProv.AutoSize = true;
            this.lblTagRptStateProv.Location = new System.Drawing.Point(282, 58);
            this.lblTagRptStateProv.Name = "lblTagRptStateProv";
            this.lblTagRptStateProv.Size = new System.Drawing.Size(82, 13);
            this.lblTagRptStateProv.TabIndex = 4;
            this.lblTagRptStateProv.Text = "State/Province:";
            // 
            // cmbTagRptStateProv
            // 
            this.cmbTagRptStateProv.Enabled = false;
            this.cmbTagRptStateProv.FormattingEnabled = true;
            this.cmbTagRptStateProv.Location = new System.Drawing.Point(282, 77);
            this.cmbTagRptStateProv.Name = "cmbTagRptStateProv";
            this.cmbTagRptStateProv.Size = new System.Drawing.Size(121, 21);
            this.cmbTagRptStateProv.TabIndex = 3;
            // 
            // lblTagRptCountry
            // 
            this.lblTagRptCountry.AutoSize = true;
            this.lblTagRptCountry.Location = new System.Drawing.Point(282, 6);
            this.lblTagRptCountry.Name = "lblTagRptCountry";
            this.lblTagRptCountry.Size = new System.Drawing.Size(46, 13);
            this.lblTagRptCountry.TabIndex = 2;
            this.lblTagRptCountry.Text = "Country:";
            // 
            // cmbTagsRptCountry
            // 
            this.cmbTagsRptCountry.FormattingEnabled = true;
            this.cmbTagsRptCountry.Location = new System.Drawing.Point(282, 25);
            this.cmbTagsRptCountry.Name = "cmbTagsRptCountry";
            this.cmbTagsRptCountry.Size = new System.Drawing.Size(121, 21);
            this.cmbTagsRptCountry.TabIndex = 1;
            this.cmbTagsRptCountry.SelectedIndexChanged += new System.EventHandler(this.cmbTagsRptCountry_SelectedIndexChanged);
            // 
            // calTagsRptDate
            // 
            this.calTagsRptDate.Location = new System.Drawing.Point(12, 9);
            this.calTagsRptDate.MaxDate = new System.DateTime(2015, 12, 13, 0, 0, 0, 0);
            this.calTagsRptDate.MaxSelectionCount = 1;
            this.calTagsRptDate.Name = "calTagsRptDate";
            this.calTagsRptDate.TabIndex = 0;
            this.calTagsRptDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calTagsRptDate_DateSelected);
            // 
            // tabSightings
            // 
            this.tabSightings.Controls.Add(this.lblSightRptCity);
            this.tabSightings.Controls.Add(this.txtSightRptCity);
            this.tabSightings.Controls.Add(this.lblSightRptStateProv);
            this.tabSightings.Controls.Add(this.cmbSightRptStateProv);
            this.tabSightings.Controls.Add(this.lblSightRptCountry);
            this.tabSightings.Controls.Add(this.cmbSightRptCountry);
            this.tabSightings.Controls.Add(this.calSightingsRptDate);
            this.tabSightings.Location = new System.Drawing.Point(4, 22);
            this.tabSightings.Name = "tabSightings";
            this.tabSightings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSightings.Size = new System.Drawing.Size(474, 185);
            this.tabSightings.TabIndex = 1;
            this.tabSightings.Text = "Sightings";
            this.tabSightings.UseVisualStyleBackColor = true;
            // 
            // lblSightRptCity
            // 
            this.lblSightRptCity.AutoSize = true;
            this.lblSightRptCity.Location = new System.Drawing.Point(278, 117);
            this.lblSightRptCity.Name = "lblSightRptCity";
            this.lblSightRptCity.Size = new System.Drawing.Size(27, 13);
            this.lblSightRptCity.TabIndex = 12;
            this.lblSightRptCity.Text = "City:";
            // 
            // txtSightRptCity
            // 
            this.txtSightRptCity.Location = new System.Drawing.Point(278, 136);
            this.txtSightRptCity.Name = "txtSightRptCity";
            this.txtSightRptCity.Size = new System.Drawing.Size(121, 20);
            this.txtSightRptCity.TabIndex = 11;
            this.txtSightRptCity.TextChanged += new System.EventHandler(this.txtSightRptCity_TextChanged);
            // 
            // lblSightRptStateProv
            // 
            this.lblSightRptStateProv.AutoSize = true;
            this.lblSightRptStateProv.Location = new System.Drawing.Point(278, 66);
            this.lblSightRptStateProv.Name = "lblSightRptStateProv";
            this.lblSightRptStateProv.Size = new System.Drawing.Size(82, 13);
            this.lblSightRptStateProv.TabIndex = 10;
            this.lblSightRptStateProv.Text = "State/Province:";
            // 
            // cmbSightRptStateProv
            // 
            this.cmbSightRptStateProv.Enabled = false;
            this.cmbSightRptStateProv.FormattingEnabled = true;
            this.cmbSightRptStateProv.Location = new System.Drawing.Point(278, 85);
            this.cmbSightRptStateProv.Name = "cmbSightRptStateProv";
            this.cmbSightRptStateProv.Size = new System.Drawing.Size(121, 21);
            this.cmbSightRptStateProv.TabIndex = 9;
            // 
            // lblSightRptCountry
            // 
            this.lblSightRptCountry.AutoSize = true;
            this.lblSightRptCountry.Location = new System.Drawing.Point(278, 14);
            this.lblSightRptCountry.Name = "lblSightRptCountry";
            this.lblSightRptCountry.Size = new System.Drawing.Size(46, 13);
            this.lblSightRptCountry.TabIndex = 8;
            this.lblSightRptCountry.Text = "Country:";
            // 
            // cmbSightRptCountry
            // 
            this.cmbSightRptCountry.FormattingEnabled = true;
            this.cmbSightRptCountry.Location = new System.Drawing.Point(278, 33);
            this.cmbSightRptCountry.Name = "cmbSightRptCountry";
            this.cmbSightRptCountry.Size = new System.Drawing.Size(121, 21);
            this.cmbSightRptCountry.TabIndex = 7;
            this.cmbSightRptCountry.SelectedIndexChanged += new System.EventHandler(this.cmbSightRptCountry_SelectedIndexChanged);
            // 
            // calSightingsRptDate
            // 
            this.calSightingsRptDate.Location = new System.Drawing.Point(12, 11);
            this.calSightingsRptDate.MaxDate = new System.DateTime(2015, 12, 13, 0, 0, 0, 0);
            this.calSightingsRptDate.MaxSelectionCount = 1;
            this.calSightingsRptDate.Name = "calSightingsRptDate";
            this.calSightingsRptDate.TabIndex = 0;
            this.calSightingsRptDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calSightingsRptDate_DateSelected);
            // 
            // tabRoutes
            // 
            this.tabRoutes.Controls.Add(this.lblReportRouteID);
            this.tabRoutes.Controls.Add(this.txtReportRouteID);
            this.tabRoutes.Location = new System.Drawing.Point(4, 22);
            this.tabRoutes.Name = "tabRoutes";
            this.tabRoutes.Size = new System.Drawing.Size(474, 185);
            this.tabRoutes.TabIndex = 2;
            this.tabRoutes.Text = "Migration Routes";
            this.tabRoutes.UseVisualStyleBackColor = true;
            // 
            // lblReportRouteID
            // 
            this.lblReportRouteID.AutoSize = true;
            this.lblReportRouteID.Location = new System.Drawing.Point(13, 7);
            this.lblReportRouteID.Name = "lblReportRouteID";
            this.lblReportRouteID.Size = new System.Drawing.Size(43, 13);
            this.lblReportRouteID.TabIndex = 1;
            this.lblReportRouteID.Text = "Tag ID:";
            // 
            // txtReportRouteID
            // 
            this.txtReportRouteID.Location = new System.Drawing.Point(13, 26);
            this.txtReportRouteID.Name = "txtReportRouteID";
            this.txtReportRouteID.Size = new System.Drawing.Size(100, 20);
            this.txtReportRouteID.TabIndex = 0;
            this.txtReportRouteID.TextChanged += new System.EventHandler(this.txtReportRouteID_TextChanged);
            this.txtReportRouteID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReportRouteID_KeyPress);
            // 
            // tabPeaks
            // 
            this.tabPeaks.Controls.Add(this.lblPeaksID);
            this.tabPeaks.Controls.Add(this.txtPeaksID);
            this.tabPeaks.Location = new System.Drawing.Point(4, 22);
            this.tabPeaks.Name = "tabPeaks";
            this.tabPeaks.Size = new System.Drawing.Size(474, 185);
            this.tabPeaks.TabIndex = 3;
            this.tabPeaks.Text = "Migration Peaks";
            this.tabPeaks.UseVisualStyleBackColor = true;
            // 
            // lblPeaksID
            // 
            this.lblPeaksID.AutoSize = true;
            this.lblPeaksID.Location = new System.Drawing.Point(15, 11);
            this.lblPeaksID.Name = "lblPeaksID";
            this.lblPeaksID.Size = new System.Drawing.Size(43, 13);
            this.lblPeaksID.TabIndex = 3;
            this.lblPeaksID.Text = "Tag ID:";
            // 
            // txtPeaksID
            // 
            this.txtPeaksID.Location = new System.Drawing.Point(15, 30);
            this.txtPeaksID.Name = "txtPeaksID";
            this.txtPeaksID.Size = new System.Drawing.Size(100, 20);
            this.txtPeaksID.TabIndex = 2;
            this.txtPeaksID.TextChanged += new System.EventHandler(this.txtPeaksID_TextChanged);
            this.txtPeaksID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeaksID_KeyPress);
            // 
            // tabHeatmap
            // 
            this.tabHeatmap.Controls.Add(this.cTags);
            this.tabHeatmap.Location = new System.Drawing.Point(4, 22);
            this.tabHeatmap.Name = "tabHeatmap";
            this.tabHeatmap.Size = new System.Drawing.Size(474, 185);
            this.tabHeatmap.TabIndex = 4;
            this.tabHeatmap.Text = "Heatmap";
            this.tabHeatmap.UseVisualStyleBackColor = true;
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(212, 366);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(84, 23);
            this.btnOutput.TabIndex = 7;
            this.btnOutput.Text = "Output to File";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // cTags
            // 
            chartArea1.Name = "ChartArea1";
            this.cTags.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cTags.Legends.Add(legend1);
            this.cTags.Location = new System.Drawing.Point(4, 3);
            this.cTags.Name = "cTags";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tags";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Sightings";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "All";
            this.cTags.Series.Add(series1);
            this.cTags.Series.Add(series2);
            this.cTags.Series.Add(series3);
            this.cTags.Size = new System.Drawing.Size(379, 179);
            this.cTags.TabIndex = 0;
            this.cTags.Text = "chart1";
            // 
            // frmReports
            // 
            this.AcceptButton = this.btnGetReport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelReports;
            this.ClientSize = new System.Drawing.Size(510, 401);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.tbcReportType);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.dgdReportTable);
            this.Controls.Add(this.btnCancelReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Reports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReports_FormClosing);
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdReportTable)).EndInit();
            this.tbcReportType.ResumeLayout(false);
            this.tabTags.ResumeLayout(false);
            this.tabTags.PerformLayout();
            this.tabSightings.ResumeLayout(false);
            this.tabSightings.PerformLayout();
            this.tabRoutes.ResumeLayout(false);
            this.tabRoutes.PerformLayout();
            this.tabPeaks.ResumeLayout(false);
            this.tabPeaks.PerformLayout();
            this.tabHeatmap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTags)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelReports;
        private System.Windows.Forms.DataGridView dgdReportTable;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.TabControl tbcReportType;
        private System.Windows.Forms.TabPage tabTags;
        private System.Windows.Forms.TabPage tabSightings;
        private System.Windows.Forms.TabPage tabRoutes;
        private System.Windows.Forms.TabPage tabPeaks;
        private System.Windows.Forms.TabPage tabHeatmap;
        private System.Windows.Forms.Label lblReportRouteID;
        private System.Windows.Forms.TextBox txtReportRouteID;
        private System.Windows.Forms.MonthCalendar calSightingsRptDate;
        private System.Windows.Forms.MonthCalendar calTagsRptDate;
        private System.Windows.Forms.ComboBox cmbTagsRptCountry;
        private System.Windows.Forms.Label lblTagRptCountry;
        private System.Windows.Forms.ComboBox cmbTagRptStateProv;
        private System.Windows.Forms.Label lblTagRptStateProv;
        private System.Windows.Forms.Label lblTagRptCity;
        private System.Windows.Forms.TextBox txtTagRptCity;
        private System.Windows.Forms.Label lblSightRptCity;
        private System.Windows.Forms.TextBox txtSightRptCity;
        private System.Windows.Forms.Label lblSightRptStateProv;
        private System.Windows.Forms.ComboBox cmbSightRptStateProv;
        private System.Windows.Forms.Label lblSightRptCountry;
        private System.Windows.Forms.ComboBox cmbSightRptCountry;
        private System.Windows.Forms.Label lblPeaksID;
        private System.Windows.Forms.TextBox txtPeaksID;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart cTags;
    }
}