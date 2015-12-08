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
            this.txtSightingTagID = new System.Windows.Forms.TextBox();
            this.chkNewTag = new System.Windows.Forms.CheckBox();
            this.tbcLocationPicker = new System.Windows.Forms.TabControl();
            this.tabLatLong = new System.Windows.Forms.TabPage();
            this.grpEastWest = new System.Windows.Forms.GroupBox();
            this.rdoEast = new System.Windows.Forms.RadioButton();
            this.rdoWest = new System.Windows.Forms.RadioButton();
            this.grpNorthSouth = new System.Windows.Forms.GroupBox();
            this.rdoNorth = new System.Windows.Forms.RadioButton();
            this.rdoSouth = new System.Windows.Forms.RadioButton();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbcLocationPicker.SuspendLayout();
            this.tabLatLong.SuspendLayout();
            this.grpEastWest.SuspendLayout();
            this.grpNorthSouth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLatitude)).BeginInit();
            this.tabLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updTemperature)).BeginInit();
            this.grpTempSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelSightings
            // 
            this.btnCancelSightings.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelSightings.Location = new System.Drawing.Point(467, 237);
            this.btnCancelSightings.Name = "btnCancelSightings";
            this.btnCancelSightings.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSightings.TabIndex = 0;
            this.btnCancelSightings.Text = "Cancel";
            this.btnCancelSightings.UseVisualStyleBackColor = true;
            this.btnCancelSightings.Click += new System.EventHandler(this.btnCancelSightings_Click);
            // 
            // btnFinishTagSighting
            // 
            this.btnFinishTagSighting.Enabled = false;
            this.btnFinishTagSighting.Location = new System.Drawing.Point(12, 237);
            this.btnFinishTagSighting.Name = "btnFinishTagSighting";
            this.btnFinishTagSighting.Size = new System.Drawing.Size(75, 23);
            this.btnFinishTagSighting.TabIndex = 1;
            this.btnFinishTagSighting.Text = "Finish";
            this.btnFinishTagSighting.UseVisualStyleBackColor = true;
            this.btnFinishTagSighting.Click += new System.EventHandler(this.btnFinishTagSighting_Click);
            // 
            // calSightingDate
            // 
            this.calSightingDate.Location = new System.Drawing.Point(309, 31);
            this.calSightingDate.MaxDate = new System.DateTime(2015, 12, 7, 0, 0, 0, 0);
            this.calSightingDate.MaxSelectionCount = 1;
            this.calSightingDate.Name = "calSightingDate";
            this.calSightingDate.TabIndex = 2;
            // 
            // lblSightingTagID
            // 
            this.lblSightingTagID.AutoSize = true;
            this.lblSightingTagID.Location = new System.Drawing.Point(12, 9);
            this.lblSightingTagID.Name = "lblSightingTagID";
            this.lblSightingTagID.Size = new System.Drawing.Size(84, 13);
            this.lblSightingTagID.TabIndex = 3;
            this.lblSightingTagID.Text = "Butterfly Tag ID:";
            // 
            // lblSightingDate
            // 
            this.lblSightingDate.AutoSize = true;
            this.lblSightingDate.Location = new System.Drawing.Point(306, 9);
            this.lblSightingDate.Name = "lblSightingDate";
            this.lblSightingDate.Size = new System.Drawing.Size(86, 13);
            this.lblSightingDate.TabIndex = 4;
            this.lblSightingDate.Text = "Date of Sighting:";
            // 
            // txtSightingTagID
            // 
            this.txtSightingTagID.Location = new System.Drawing.Point(12, 25);
            this.txtSightingTagID.Name = "txtSightingTagID";
            this.txtSightingTagID.ShortcutsEnabled = false;
            this.txtSightingTagID.Size = new System.Drawing.Size(100, 20);
            this.txtSightingTagID.TabIndex = 5;
            this.txtSightingTagID.TextChanged += new System.EventHandler(this.txtSightingTagID_TextChanged);
            this.txtSightingTagID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSightingTagID_KeyPress);
            // 
            // chkNewTag
            // 
            this.chkNewTag.AutoSize = true;
            this.chkNewTag.Location = new System.Drawing.Point(118, 27);
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
            this.tbcLocationPicker.Location = new System.Drawing.Point(12, 52);
            this.tbcLocationPicker.Name = "tbcLocationPicker";
            this.tbcLocationPicker.SelectedIndex = 0;
            this.tbcLocationPicker.Size = new System.Drawing.Size(285, 125);
            this.tbcLocationPicker.TabIndex = 7;
            this.tbcLocationPicker.TabIndexChanged += new System.EventHandler(this.tbcLocationPicker_TabIndexChanged);
            // 
            // tabLatLong
            // 
            this.tabLatLong.Controls.Add(this.grpEastWest);
            this.tabLatLong.Controls.Add(this.grpNorthSouth);
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
            // grpEastWest
            // 
            this.grpEastWest.Controls.Add(this.rdoEast);
            this.grpEastWest.Controls.Add(this.rdoWest);
            this.grpEastWest.Location = new System.Drawing.Point(121, 50);
            this.grpEastWest.Name = "grpEastWest";
            this.grpEastWest.Size = new System.Drawing.Size(85, 40);
            this.grpEastWest.TabIndex = 8;
            this.grpEastWest.TabStop = false;
            this.grpEastWest.Text = "East/West:";
            // 
            // rdoEast
            // 
            this.rdoEast.AutoSize = true;
            this.rdoEast.Enabled = false;
            this.rdoEast.Location = new System.Drawing.Point(6, 17);
            this.rdoEast.Name = "rdoEast";
            this.rdoEast.Size = new System.Drawing.Size(32, 17);
            this.rdoEast.TabIndex = 1;
            this.rdoEast.TabStop = true;
            this.rdoEast.Text = "E";
            this.rdoEast.UseVisualStyleBackColor = true;
            // 
            // rdoWest
            // 
            this.rdoWest.AutoSize = true;
            this.rdoWest.Enabled = false;
            this.rdoWest.Location = new System.Drawing.Point(44, 17);
            this.rdoWest.Name = "rdoWest";
            this.rdoWest.Size = new System.Drawing.Size(36, 17);
            this.rdoWest.TabIndex = 1;
            this.rdoWest.TabStop = true;
            this.rdoWest.Text = "W";
            this.rdoWest.UseVisualStyleBackColor = true;
            // 
            // grpNorthSouth
            // 
            this.grpNorthSouth.Controls.Add(this.rdoNorth);
            this.grpNorthSouth.Controls.Add(this.rdoSouth);
            this.grpNorthSouth.Location = new System.Drawing.Point(121, 6);
            this.grpNorthSouth.Name = "grpNorthSouth";
            this.grpNorthSouth.Size = new System.Drawing.Size(85, 38);
            this.grpNorthSouth.TabIndex = 8;
            this.grpNorthSouth.TabStop = false;
            this.grpNorthSouth.Text = "North/South:";
            // 
            // rdoNorth
            // 
            this.rdoNorth.AutoSize = true;
            this.rdoNorth.Enabled = false;
            this.rdoNorth.Location = new System.Drawing.Point(6, 15);
            this.rdoNorth.Name = "rdoNorth";
            this.rdoNorth.Size = new System.Drawing.Size(33, 17);
            this.rdoNorth.TabIndex = 0;
            this.rdoNorth.TabStop = true;
            this.rdoNorth.Text = "N";
            this.rdoNorth.UseVisualStyleBackColor = true;
            // 
            // rdoSouth
            // 
            this.rdoSouth.AutoSize = true;
            this.rdoSouth.Enabled = false;
            this.rdoSouth.Location = new System.Drawing.Point(44, 15);
            this.rdoSouth.Name = "rdoSouth";
            this.rdoSouth.Size = new System.Drawing.Size(32, 17);
            this.rdoSouth.TabIndex = 0;
            this.rdoSouth.TabStop = true;
            this.rdoSouth.Text = "S";
            this.rdoSouth.UseVisualStyleBackColor = true;
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
            this.updLongitude.DecimalPlaces = 1;
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
            this.updLongitude.Name = "updLongitude";
            this.updLongitude.Size = new System.Drawing.Size(49, 20);
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
            this.updLatitude.DecimalPlaces = 1;
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
            this.updLatitude.Name = "updLatitude";
            this.updLatitude.Size = new System.Drawing.Size(49, 20);
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
            // 
            // updTemperature
            // 
            this.updTemperature.Location = new System.Drawing.Point(12, 202);
            this.updTemperature.Name = "updTemperature";
            this.updTemperature.Size = new System.Drawing.Size(75, 20);
            this.updTemperature.TabIndex = 8;
            // 
            // lblSightingTemperature
            // 
            this.lblSightingTemperature.AutoSize = true;
            this.lblSightingTemperature.Location = new System.Drawing.Point(17, 183);
            this.lblSightingTemperature.Name = "lblSightingTemperature";
            this.lblSightingTemperature.Size = new System.Drawing.Size(70, 13);
            this.lblSightingTemperature.TabIndex = 9;
            this.lblSightingTemperature.Text = "Temperature:";
            // 
            // grpTempSystem
            // 
            this.grpTempSystem.Controls.Add(this.rdoCelcius);
            this.grpTempSystem.Controls.Add(this.rdoFahrenheit);
            this.grpTempSystem.Location = new System.Drawing.Point(93, 183);
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
            this.rdoCelcius.TabStop = true;
            this.rdoCelcius.Text = "°C";
            this.rdoCelcius.UseVisualStyleBackColor = true;
            // 
            // rdoFahrenheit
            // 
            this.rdoFahrenheit.AutoSize = true;
            this.rdoFahrenheit.Location = new System.Drawing.Point(6, 19);
            this.rdoFahrenheit.Name = "rdoFahrenheit";
            this.rdoFahrenheit.Size = new System.Drawing.Size(35, 17);
            this.rdoFahrenheit.TabIndex = 0;
            this.rdoFahrenheit.TabStop = true;
            this.rdoFahrenheit.Text = "°F";
            this.rdoFahrenheit.UseVisualStyleBackColor = true;
            // 
            // frmSightings
            // 
            this.AcceptButton = this.btnFinishTagSighting;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelSightings;
            this.ClientSize = new System.Drawing.Size(554, 272);
            this.Controls.Add(this.grpTempSystem);
            this.Controls.Add(this.lblSightingTemperature);
            this.Controls.Add(this.updTemperature);
            this.Controls.Add(this.tbcLocationPicker);
            this.Controls.Add(this.chkNewTag);
            this.Controls.Add(this.txtSightingTagID);
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
            this.tbcLocationPicker.ResumeLayout(false);
            this.tabLatLong.ResumeLayout(false);
            this.tabLatLong.PerformLayout();
            this.grpEastWest.ResumeLayout(false);
            this.grpEastWest.PerformLayout();
            this.grpNorthSouth.ResumeLayout(false);
            this.grpNorthSouth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLatitude)).EndInit();
            this.tabLoc.ResumeLayout(false);
            this.tabLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updTemperature)).EndInit();
            this.grpTempSystem.ResumeLayout(false);
            this.grpTempSystem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelSightings;
        private System.Windows.Forms.Button btnFinishTagSighting;
        private System.Windows.Forms.MonthCalendar calSightingDate;
        private System.Windows.Forms.Label lblSightingTagID;
        private System.Windows.Forms.Label lblSightingDate;
        private System.Windows.Forms.TextBox txtSightingTagID;
        private System.Windows.Forms.CheckBox chkNewTag;
        private System.Windows.Forms.TabControl tbcLocationPicker;
        private System.Windows.Forms.TabPage tabLatLong;
        private System.Windows.Forms.NumericUpDown updLatitude;
        private System.Windows.Forms.RadioButton rdoWest;
        private System.Windows.Forms.RadioButton rdoEast;
        private System.Windows.Forms.RadioButton rdoSouth;
        private System.Windows.Forms.RadioButton rdoNorth;
        private System.Windows.Forms.TabPage tabLoc;
        private System.Windows.Forms.NumericUpDown updLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.GroupBox grpEastWest;
        private System.Windows.Forms.GroupBox grpNorthSouth;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}