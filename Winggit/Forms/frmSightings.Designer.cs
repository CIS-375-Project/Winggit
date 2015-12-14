namespace Winggit.Forms
{
    partial class frmSightings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSightings));
            this.btnCancelSightings = new System.Windows.Forms.Button();
            this.btnFinishTagSighting = new System.Windows.Forms.Button();
            this.calSightingDate = new System.Windows.Forms.MonthCalendar();
            this.lblSightingTagID = new System.Windows.Forms.Label();
            this.lblSightingDate = new System.Windows.Forms.Label();
            this.txtTagID = new System.Windows.Forms.TextBox();
            this.chkNewTag = new System.Windows.Forms.CheckBox();
            this.tbcLocationPicker = new System.Windows.Forms.TabControl();
            this.tabLatLong = new System.Windows.Forms.TabPage();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.updLongitude = new System.Windows.Forms.NumericUpDown();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.updLatitude = new System.Windows.Forms.NumericUpDown();
            this.tabLoc = new System.Windows.Forms.TabPage();
            this.lblSightingStateProv = new System.Windows.Forms.Label();
            this.cmbSightingStateProv = new System.Windows.Forms.ComboBox();
            this.lblSightingCountry = new System.Windows.Forms.Label();
            this.cmbSightingCountry = new System.Windows.Forms.ComboBox();
            this.lblSightingCity = new System.Windows.Forms.Label();
            this.txtSightingCity = new System.Windows.Forms.TextBox();
            this.updTemperature = new System.Windows.Forms.NumericUpDown();
            this.lblSightingTemperature = new System.Windows.Forms.Label();
            this.grpTempSystem = new System.Windows.Forms.GroupBox();
            this.rdoCelcius = new System.Windows.Forms.RadioButton();
            this.rdoFahrenheit = new System.Windows.Forms.RadioButton();
            this.txtSightingSpecies = new System.Windows.Forms.TextBox();
            this.lblSightingSpecies = new System.Windows.Forms.Label();
            this.btnSightingGeocode = new System.Windows.Forms.Button();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoUnknown = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.updWingspan = new System.Windows.Forms.NumericUpDown();
            this.lblWingspan = new System.Windows.Forms.Label();
            this.btnLoadInfo = new System.Windows.Forms.Button();
            this.tbcLocationPicker.SuspendLayout();
            this.tabLatLong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLatitude)).BeginInit();
            this.tabLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updTemperature)).BeginInit();
            this.grpTempSystem.SuspendLayout();
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updWingspan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelSightings
            // 
            this.btnCancelSightings.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelSightings.Location = new System.Drawing.Point(504, 237);
            this.btnCancelSightings.Name = "btnCancelSightings";
            this.btnCancelSightings.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSightings.TabIndex = 0;
            this.btnCancelSightings.Text = "Cancel";
            this.btnCancelSightings.UseVisualStyleBackColor = true;
            // 
            // btnFinishTagSighting
            // 
            this.btnFinishTagSighting.Enabled = false;
            this.btnFinishTagSighting.Location = new System.Drawing.Point(12, 268);
            this.btnFinishTagSighting.Name = "btnFinishTagSighting";
            this.btnFinishTagSighting.Size = new System.Drawing.Size(75, 23);
            this.btnFinishTagSighting.TabIndex = 1;
            this.btnFinishTagSighting.Text = "Finish";
            this.btnFinishTagSighting.UseVisualStyleBackColor = true;
            this.btnFinishTagSighting.Click += new System.EventHandler(this.btnFinishTagSighting_Click);
            // 
            // calSightingDate
            // 
            this.calSightingDate.Location = new System.Drawing.Point(332, 27);
            this.calSightingDate.MaxDate = new System.DateTime(2015, 12, 11, 0, 0, 0, 0);
            this.calSightingDate.MaxSelectionCount = 1;
            this.calSightingDate.Name = "calSightingDate";
            this.calSightingDate.TabIndex = 2;
            // 
            // lblSightingTagID
            // 
            this.lblSightingTagID.AutoSize = true;
            this.lblSightingTagID.Location = new System.Drawing.Point(12, 9);
            this.lblSightingTagID.Name = "lblSightingTagID";
            this.lblSightingTagID.Size = new System.Drawing.Size(43, 13);
            this.lblSightingTagID.TabIndex = 3;
            this.lblSightingTagID.Text = "Tag ID:";
            // 
            // lblSightingDate
            // 
            this.lblSightingDate.AutoSize = true;
            this.lblSightingDate.Location = new System.Drawing.Point(329, 9);
            this.lblSightingDate.Name = "lblSightingDate";
            this.lblSightingDate.Size = new System.Drawing.Size(86, 13);
            this.lblSightingDate.TabIndex = 4;
            this.lblSightingDate.Text = "Date of Sighting:";
            // 
            // txtTagID
            // 
            this.txtTagID.Location = new System.Drawing.Point(12, 25);
            this.txtTagID.Name = "txtTagID";
            this.txtTagID.ShortcutsEnabled = false;
            this.txtTagID.Size = new System.Drawing.Size(100, 20);
            this.txtTagID.TabIndex = 5;
            this.txtTagID.TextChanged += new System.EventHandler(this.txtTagID_TextChanged);
            this.txtTagID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSightingTagID_KeyPress);
            // 
            // chkNewTag
            // 
            this.chkNewTag.AutoSize = true;
            this.chkNewTag.Location = new System.Drawing.Point(228, 27);
            this.chkNewTag.Name = "chkNewTag";
            this.chkNewTag.Size = new System.Drawing.Size(92, 17);
            this.chkNewTag.TabIndex = 6;
            this.chkNewTag.Text = "Add New Tag";
            this.chkNewTag.UseVisualStyleBackColor = true;
            this.chkNewTag.CheckedChanged += new System.EventHandler(this.chkNewTag_CheckedChanged);
            // 
            // tbcLocationPicker
            // 
            this.tbcLocationPicker.Controls.Add(this.tabLatLong);
            this.tbcLocationPicker.Controls.Add(this.tabLoc);
            this.tbcLocationPicker.Location = new System.Drawing.Point(12, 51);
            this.tbcLocationPicker.Name = "tbcLocationPicker";
            this.tbcLocationPicker.SelectedIndex = 0;
            this.tbcLocationPicker.Size = new System.Drawing.Size(285, 125);
            this.tbcLocationPicker.TabIndex = 7;
            this.tbcLocationPicker.SelectedIndexChanged += new System.EventHandler(this.tbcLocationPicker_SelectedIndexChanged);
            // 
            // tabLatLong
            // 
            this.tabLatLong.Controls.Add(this.lblLongitude);
            this.tabLatLong.Controls.Add(this.updLongitude);
            this.tabLatLong.Controls.Add(this.lblLatitude);
            this.tabLatLong.Controls.Add(this.updLatitude);
            this.tabLatLong.Location = new System.Drawing.Point(4, 22);
            this.tabLatLong.Name = "tabLatLong";
            this.tabLatLong.Padding = new System.Windows.Forms.Padding(3);
            this.tabLatLong.Size = new System.Drawing.Size(277, 99);
            this.tabLatLong.TabIndex = 0;
            this.tabLatLong.Text = "Latitude/Longitude";
            this.tabLatLong.UseVisualStyleBackColor = true;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(6, 69);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(57, 13);
            this.lblLongitude.TabIndex = 5;
            this.lblLongitude.Text = "Longitude:";
            // 
            // updLongitude
            // 
            this.updLongitude.DecimalPlaces = 7;
            this.updLongitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.updLongitude.Location = new System.Drawing.Point(66, 67);
            this.updLongitude.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.updLongitude.Minimum = new decimal(new int[] {
            1799999999,
            0,
            0,
            -2147024896});
            this.updLongitude.Name = "updLongitude";
            this.updLongitude.Size = new System.Drawing.Size(85, 20);
            this.updLongitude.TabIndex = 4;
            this.updLongitude.ValueChanged += new System.EventHandler(this.updLongitude_ValueChanged);
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(15, 23);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(48, 13);
            this.lblLatitude.TabIndex = 3;
            this.lblLatitude.Text = "Latitude:";
            // 
            // updLatitude
            // 
            this.updLatitude.DecimalPlaces = 7;
            this.updLatitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.updLatitude.Location = new System.Drawing.Point(66, 21);
            this.updLatitude.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.updLatitude.Minimum = new decimal(new int[] {
            899999999,
            0,
            0,
            -2147024896});
            this.updLatitude.Name = "updLatitude";
            this.updLatitude.Size = new System.Drawing.Size(85, 20);
            this.updLatitude.TabIndex = 2;
            this.updLatitude.ValueChanged += new System.EventHandler(this.updLatitude_ValueChanged);
            // 
            // tabLoc
            // 
            this.tabLoc.Controls.Add(this.lblSightingStateProv);
            this.tabLoc.Controls.Add(this.cmbSightingStateProv);
            this.tabLoc.Controls.Add(this.lblSightingCountry);
            this.tabLoc.Controls.Add(this.cmbSightingCountry);
            this.tabLoc.Controls.Add(this.lblSightingCity);
            this.tabLoc.Controls.Add(this.txtSightingCity);
            this.tabLoc.Location = new System.Drawing.Point(4, 22);
            this.tabLoc.Name = "tabLoc";
            this.tabLoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoc.Size = new System.Drawing.Size(277, 99);
            this.tabLoc.TabIndex = 1;
            this.tabLoc.Text = "Location";
            this.tabLoc.UseVisualStyleBackColor = true;
            // 
            // lblSightingStateProv
            // 
            this.lblSightingStateProv.AutoSize = true;
            this.lblSightingStateProv.Location = new System.Drawing.Point(127, 3);
            this.lblSightingStateProv.Name = "lblSightingStateProv";
            this.lblSightingStateProv.Size = new System.Drawing.Size(82, 13);
            this.lblSightingStateProv.TabIndex = 5;
            this.lblSightingStateProv.Text = "State/Province:";
            // 
            // cmbSightingStateProv
            // 
            this.cmbSightingStateProv.Enabled = false;
            this.cmbSightingStateProv.FormattingEnabled = true;
            this.cmbSightingStateProv.Location = new System.Drawing.Point(127, 19);
            this.cmbSightingStateProv.Name = "cmbSightingStateProv";
            this.cmbSightingStateProv.Size = new System.Drawing.Size(131, 21);
            this.cmbSightingStateProv.TabIndex = 4;
            this.cmbSightingStateProv.SelectedIndexChanged += new System.EventHandler(this.cmbSightingStateProv_SelectedIndexChanged);
            // 
            // lblSightingCountry
            // 
            this.lblSightingCountry.AutoSize = true;
            this.lblSightingCountry.Location = new System.Drawing.Point(9, 53);
            this.lblSightingCountry.Name = "lblSightingCountry";
            this.lblSightingCountry.Size = new System.Drawing.Size(46, 13);
            this.lblSightingCountry.TabIndex = 3;
            this.lblSightingCountry.Text = "Country:";
            // 
            // cmbSightingCountry
            // 
            this.cmbSightingCountry.FormattingEnabled = true;
            this.cmbSightingCountry.Location = new System.Drawing.Point(6, 72);
            this.cmbSightingCountry.Name = "cmbSightingCountry";
            this.cmbSightingCountry.Size = new System.Drawing.Size(131, 21);
            this.cmbSightingCountry.TabIndex = 2;
            this.cmbSightingCountry.SelectedIndexChanged += new System.EventHandler(this.cmbSightingCountry_SelectedIndexChanged);
            // 
            // lblSightingCity
            // 
            this.lblSightingCity.AutoSize = true;
            this.lblSightingCity.Location = new System.Drawing.Point(6, 3);
            this.lblSightingCity.Name = "lblSightingCity";
            this.lblSightingCity.Size = new System.Drawing.Size(27, 13);
            this.lblSightingCity.TabIndex = 1;
            this.lblSightingCity.Text = "City:";
            // 
            // txtSightingCity
            // 
            this.txtSightingCity.Location = new System.Drawing.Point(9, 19);
            this.txtSightingCity.Name = "txtSightingCity";
            this.txtSightingCity.Size = new System.Drawing.Size(112, 20);
            this.txtSightingCity.TabIndex = 0;
            this.txtSightingCity.TextChanged += new System.EventHandler(this.txtSightingCity_TextChanged);
            // 
            // updTemperature
            // 
            this.updTemperature.Location = new System.Drawing.Point(348, 224);
            this.updTemperature.Name = "updTemperature";
            this.updTemperature.Size = new System.Drawing.Size(75, 20);
            this.updTemperature.TabIndex = 8;
            // 
            // lblSightingTemperature
            // 
            this.lblSightingTemperature.AutoSize = true;
            this.lblSightingTemperature.Location = new System.Drawing.Point(353, 205);
            this.lblSightingTemperature.Name = "lblSightingTemperature";
            this.lblSightingTemperature.Size = new System.Drawing.Size(70, 13);
            this.lblSightingTemperature.TabIndex = 9;
            this.lblSightingTemperature.Text = "Temperature:";
            // 
            // grpTempSystem
            // 
            this.grpTempSystem.Controls.Add(this.rdoCelcius);
            this.grpTempSystem.Controls.Add(this.rdoFahrenheit);
            this.grpTempSystem.Location = new System.Drawing.Point(438, 205);
            this.grpTempSystem.Name = "grpTempSystem";
            this.grpTempSystem.Size = new System.Drawing.Size(60, 65);
            this.grpTempSystem.TabIndex = 10;
            this.grpTempSystem.TabStop = false;
            this.grpTempSystem.Text = "System:";
            // 
            // rdoCelcius
            // 
            this.rdoCelcius.AutoSize = true;
            this.rdoCelcius.Location = new System.Drawing.Point(6, 42);
            this.rdoCelcius.Name = "rdoCelcius";
            this.rdoCelcius.Size = new System.Drawing.Size(36, 17);
            this.rdoCelcius.TabIndex = 1;
            this.rdoCelcius.Text = "°C";
            this.rdoCelcius.UseVisualStyleBackColor = true;
            this.rdoCelcius.CheckedChanged += new System.EventHandler(this.rdoCelcius_CheckedChanged);
            // 
            // rdoFahrenheit
            // 
            this.rdoFahrenheit.AutoSize = true;
            this.rdoFahrenheit.Checked = true;
            this.rdoFahrenheit.Location = new System.Drawing.Point(6, 19);
            this.rdoFahrenheit.Name = "rdoFahrenheit";
            this.rdoFahrenheit.Size = new System.Drawing.Size(35, 17);
            this.rdoFahrenheit.TabIndex = 0;
            this.rdoFahrenheit.TabStop = true;
            this.rdoFahrenheit.Text = "°F";
            this.rdoFahrenheit.UseVisualStyleBackColor = true;
            this.rdoFahrenheit.CheckedChanged += new System.EventHandler(this.rdoFahrenheit_CheckedChanged);
            // 
            // txtSightingSpecies
            // 
            this.txtSightingSpecies.Enabled = false;
            this.txtSightingSpecies.Location = new System.Drawing.Point(122, 25);
            this.txtSightingSpecies.Name = "txtSightingSpecies";
            this.txtSightingSpecies.Size = new System.Drawing.Size(100, 20);
            this.txtSightingSpecies.TabIndex = 11;
            this.txtSightingSpecies.TextChanged += new System.EventHandler(this.txtSightingSpecies_TextChanged);
            // 
            // lblSightingSpecies
            // 
            this.lblSightingSpecies.AutoSize = true;
            this.lblSightingSpecies.Location = new System.Drawing.Point(119, 9);
            this.lblSightingSpecies.Name = "lblSightingSpecies";
            this.lblSightingSpecies.Size = new System.Drawing.Size(48, 13);
            this.lblSightingSpecies.TabIndex = 12;
            this.lblSightingSpecies.Text = "Species:";
            // 
            // btnSightingGeocode
            // 
            this.btnSightingGeocode.Location = new System.Drawing.Point(93, 268);
            this.btnSightingGeocode.Name = "btnSightingGeocode";
            this.btnSightingGeocode.Size = new System.Drawing.Size(92, 23);
            this.btnSightingGeocode.TabIndex = 13;
            this.btnSightingGeocode.Text = "Autofill Location";
            this.btnSightingGeocode.UseVisualStyleBackColor = true;
            this.btnSightingGeocode.Click += new System.EventHandler(this.btnSightingGeocode_Click);
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdoUnknown);
            this.grpGender.Controls.Add(this.rdoFemale);
            this.grpGender.Controls.Add(this.rdoMale);
            this.grpGender.Location = new System.Drawing.Point(15, 183);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(207, 48);
            this.grpGender.TabIndex = 14;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender:";
            // 
            // rdoUnknown
            // 
            this.rdoUnknown.AutoSize = true;
            this.rdoUnknown.Checked = true;
            this.rdoUnknown.Location = new System.Drawing.Point(122, 20);
            this.rdoUnknown.Name = "rdoUnknown";
            this.rdoUnknown.Size = new System.Drawing.Size(71, 17);
            this.rdoUnknown.TabIndex = 2;
            this.rdoUnknown.TabStop = true;
            this.rdoUnknown.Text = "Unknown";
            this.rdoUnknown.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(64, 20);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(10, 20);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // updWingspan
            // 
            this.updWingspan.Location = new System.Drawing.Point(228, 203);
            this.updWingspan.Name = "updWingspan";
            this.updWingspan.Size = new System.Drawing.Size(91, 20);
            this.updWingspan.TabIndex = 15;
            // 
            // lblWingspan
            // 
            this.lblWingspan.AutoSize = true;
            this.lblWingspan.Location = new System.Drawing.Point(228, 179);
            this.lblWingspan.Name = "lblWingspan";
            this.lblWingspan.Size = new System.Drawing.Size(83, 13);
            this.lblWingspan.TabIndex = 16;
            this.lblWingspan.Text = "Wingspan (mm):";
            // 
            // btnLoadInfo
            // 
            this.btnLoadInfo.Location = new System.Drawing.Point(191, 268);
            this.btnLoadInfo.Name = "btnLoadInfo";
            this.btnLoadInfo.Size = new System.Drawing.Size(75, 23);
            this.btnLoadInfo.TabIndex = 17;
            this.btnLoadInfo.Text = "Load Info";
            this.btnLoadInfo.UseVisualStyleBackColor = true;
            this.btnLoadInfo.Click += new System.EventHandler(this.btnLoadInfo_Click);
            // 
            // frmSightings
            // 
            this.AcceptButton = this.btnFinishTagSighting;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelSightings;
            this.ClientSize = new System.Drawing.Size(591, 303);
            this.Controls.Add(this.btnLoadInfo);
            this.Controls.Add(this.lblWingspan);
            this.Controls.Add(this.updWingspan);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.btnSightingGeocode);
            this.Controls.Add(this.lblSightingSpecies);
            this.Controls.Add(this.txtSightingSpecies);
            this.Controls.Add(this.grpTempSystem);
            this.Controls.Add(this.lblSightingTemperature);
            this.Controls.Add(this.updTemperature);
            this.Controls.Add(this.tbcLocationPicker);
            this.Controls.Add(this.chkNewTag);
            this.Controls.Add(this.txtTagID);
            this.Controls.Add(this.lblSightingDate);
            this.Controls.Add(this.lblSightingTagID);
            this.Controls.Add(this.calSightingDate);
            this.Controls.Add(this.btnFinishTagSighting);
            this.Controls.Add(this.btnCancelSightings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSightings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Sighting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSightings_FormClosing);
            this.Load += new System.EventHandler(this.frmSightings_Load);
            this.tbcLocationPicker.ResumeLayout(false);
            this.tabLatLong.ResumeLayout(false);
            this.tabLatLong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLatitude)).EndInit();
            this.tabLoc.ResumeLayout(false);
            this.tabLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updTemperature)).EndInit();
            this.grpTempSystem.ResumeLayout(false);
            this.grpTempSystem.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updWingspan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelSightings;
        private System.Windows.Forms.Button btnFinishTagSighting;
        private System.Windows.Forms.MonthCalendar calSightingDate;
        private System.Windows.Forms.Label lblSightingTagID;
        private System.Windows.Forms.Label lblSightingDate;
        private System.Windows.Forms.TextBox txtTagID;
        private System.Windows.Forms.CheckBox chkNewTag;
        private System.Windows.Forms.TabControl tbcLocationPicker;
        private System.Windows.Forms.TabPage tabLatLong;
        private System.Windows.Forms.NumericUpDown updLatitude;
        private System.Windows.Forms.TabPage tabLoc;
        private System.Windows.Forms.NumericUpDown updLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.NumericUpDown updTemperature;
        private System.Windows.Forms.Label lblSightingTemperature;
        private System.Windows.Forms.GroupBox grpTempSystem;
        private System.Windows.Forms.RadioButton rdoCelcius;
        private System.Windows.Forms.RadioButton rdoFahrenheit;
        private System.Windows.Forms.Label lblSightingCountry;
        private System.Windows.Forms.ComboBox cmbSightingCountry;
        private System.Windows.Forms.Label lblSightingCity;
        private System.Windows.Forms.TextBox txtSightingCity;
        private System.Windows.Forms.Label lblSightingStateProv;
        private System.Windows.Forms.ComboBox cmbSightingStateProv;
        private System.Windows.Forms.TextBox txtSightingSpecies;
        private System.Windows.Forms.Label lblSightingSpecies;
        private System.Windows.Forms.Button btnSightingGeocode;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdoUnknown;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.NumericUpDown updWingspan;
        private System.Windows.Forms.Label lblWingspan;
        private System.Windows.Forms.Button btnLoadInfo;
    }
}