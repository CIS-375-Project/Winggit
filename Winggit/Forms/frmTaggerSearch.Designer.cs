namespace Winggit.Forms
{
    partial class frmTaggerSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaggerSearch));
            this.btnCancelTaggerSearch = new System.Windows.Forms.Button();
            this.grpByLocation = new System.Windows.Forms.GroupBox();
            this.lblSearchCountry = new System.Windows.Forms.Label();
            this.lblSearchStateProv = new System.Windows.Forms.Label();
            this.lblSearchCity = new System.Windows.Forms.Label();
            this.cmbSearchCountry = new System.Windows.Forms.ComboBox();
            this.cmbSearchStateProv = new System.Windows.Forms.ComboBox();
            this.txtSearchCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpByTaggerInfo = new System.Windows.Forms.GroupBox();
            this.lblSearchTaggerID = new System.Windows.Forms.Label();
            this.txtSearchTaggerID = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.dgdTaggerSearchResults = new System.Windows.Forms.DataGridView();
            this.lblTaggerSearchResults = new System.Windows.Forms.Label();
            this.rdoSearchByLocation = new System.Windows.Forms.RadioButton();
            this.rdoSearchByTaggerInfo = new System.Windows.Forms.RadioButton();
            this.grpSearchBy = new System.Windows.Forms.GroupBox();
            this.grpByLocation.SuspendLayout();
            this.grpByTaggerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdTaggerSearchResults)).BeginInit();
            this.grpSearchBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelTaggerSearch
            // 
            this.btnCancelTaggerSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelTaggerSearch.Location = new System.Drawing.Point(658, 245);
            this.btnCancelTaggerSearch.Name = "btnCancelTaggerSearch";
            this.btnCancelTaggerSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCancelTaggerSearch.TabIndex = 2;
            this.btnCancelTaggerSearch.Text = "Cancel";
            this.btnCancelTaggerSearch.UseVisualStyleBackColor = true;
            this.btnCancelTaggerSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // grpByLocation
            // 
            this.grpByLocation.Controls.Add(this.lblSearchCountry);
            this.grpByLocation.Controls.Add(this.lblSearchStateProv);
            this.grpByLocation.Controls.Add(this.lblSearchCity);
            this.grpByLocation.Controls.Add(this.cmbSearchCountry);
            this.grpByLocation.Controls.Add(this.cmbSearchStateProv);
            this.grpByLocation.Controls.Add(this.txtSearchCity);
            this.grpByLocation.Location = new System.Drawing.Point(12, 12);
            this.grpByLocation.Name = "grpByLocation";
            this.grpByLocation.Size = new System.Drawing.Size(313, 108);
            this.grpByLocation.TabIndex = 3;
            this.grpByLocation.TabStop = false;
            this.grpByLocation.Text = "Search by Location";
            // 
            // lblSearchCountry
            // 
            this.lblSearchCountry.AutoSize = true;
            this.lblSearchCountry.Location = new System.Drawing.Point(6, 78);
            this.lblSearchCountry.Name = "lblSearchCountry";
            this.lblSearchCountry.Size = new System.Drawing.Size(46, 13);
            this.lblSearchCountry.TabIndex = 20;
            this.lblSearchCountry.Text = "Country:";
            // 
            // lblSearchStateProv
            // 
            this.lblSearchStateProv.AutoSize = true;
            this.lblSearchStateProv.Location = new System.Drawing.Point(6, 48);
            this.lblSearchStateProv.Name = "lblSearchStateProv";
            this.lblSearchStateProv.Size = new System.Drawing.Size(82, 13);
            this.lblSearchStateProv.TabIndex = 18;
            this.lblSearchStateProv.Text = "State/Province:";
            // 
            // lblSearchCity
            // 
            this.lblSearchCity.AutoSize = true;
            this.lblSearchCity.Location = new System.Drawing.Point(6, 22);
            this.lblSearchCity.Name = "lblSearchCity";
            this.lblSearchCity.Size = new System.Drawing.Size(27, 13);
            this.lblSearchCity.TabIndex = 16;
            this.lblSearchCity.Text = "City:";
            // 
            // cmbSearchCountry
            // 
            this.cmbSearchCountry.FormattingEnabled = true;
            this.cmbSearchCountry.Location = new System.Drawing.Point(101, 75);
            this.cmbSearchCountry.Name = "cmbSearchCountry";
            this.cmbSearchCountry.Size = new System.Drawing.Size(201, 21);
            this.cmbSearchCountry.TabIndex = 21;
            this.cmbSearchCountry.SelectedIndexChanged += new System.EventHandler(this.cmbSearchCountry_SelectedIndexChanged);
            // 
            // cmbSearchStateProv
            // 
            this.cmbSearchStateProv.Enabled = false;
            this.cmbSearchStateProv.FormattingEnabled = true;
            this.cmbSearchStateProv.Location = new System.Drawing.Point(101, 45);
            this.cmbSearchStateProv.Name = "cmbSearchStateProv";
            this.cmbSearchStateProv.Size = new System.Drawing.Size(201, 21);
            this.cmbSearchStateProv.TabIndex = 19;
            this.cmbSearchStateProv.SelectedIndexChanged += new System.EventHandler(this.cmbSearchStateProv_SelectedIndexChanged);
            // 
            // txtSearchCity
            // 
            this.txtSearchCity.Location = new System.Drawing.Point(101, 19);
            this.txtSearchCity.Name = "txtSearchCity";
            this.txtSearchCity.Size = new System.Drawing.Size(201, 20);
            this.txtSearchCity.TabIndex = 17;
            this.txtSearchCity.TextChanged += new System.EventHandler(this.txtSearchCity_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 245);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpByTaggerInfo
            // 
            this.grpByTaggerInfo.Controls.Add(this.lblSearchTaggerID);
            this.grpByTaggerInfo.Controls.Add(this.txtSearchTaggerID);
            this.grpByTaggerInfo.Controls.Add(this.lblSearchName);
            this.grpByTaggerInfo.Controls.Add(this.txtSearchName);
            this.grpByTaggerInfo.Enabled = false;
            this.grpByTaggerInfo.Location = new System.Drawing.Point(12, 126);
            this.grpByTaggerInfo.Name = "grpByTaggerInfo";
            this.grpByTaggerInfo.Size = new System.Drawing.Size(313, 76);
            this.grpByTaggerInfo.TabIndex = 5;
            this.grpByTaggerInfo.TabStop = false;
            this.grpByTaggerInfo.Text = "Search by Tagger Info";
            // 
            // lblSearchTaggerID
            // 
            this.lblSearchTaggerID.AutoSize = true;
            this.lblSearchTaggerID.Location = new System.Drawing.Point(6, 45);
            this.lblSearchTaggerID.Name = "lblSearchTaggerID";
            this.lblSearchTaggerID.Size = new System.Drawing.Size(58, 13);
            this.lblSearchTaggerID.TabIndex = 3;
            this.lblSearchTaggerID.Text = "Tagger ID:";
            // 
            // txtSearchTaggerID
            // 
            this.txtSearchTaggerID.Location = new System.Drawing.Point(101, 42);
            this.txtSearchTaggerID.MaxLength = 9;
            this.txtSearchTaggerID.Name = "txtSearchTaggerID";
            this.txtSearchTaggerID.ShortcutsEnabled = false;
            this.txtSearchTaggerID.Size = new System.Drawing.Size(201, 20);
            this.txtSearchTaggerID.TabIndex = 2;
            this.txtSearchTaggerID.TextChanged += new System.EventHandler(this.txtSearchTaggerID_TextChanged);
            this.txtSearchTaggerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchTaggerID_KeyPress);
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(6, 19);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(38, 13);
            this.lblSearchName.TabIndex = 1;
            this.lblSearchName.Text = "Name:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(101, 16);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(201, 20);
            this.txtSearchName.TabIndex = 0;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // dgdTaggerSearchResults
            // 
            this.dgdTaggerSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdTaggerSearchResults.Location = new System.Drawing.Point(331, 26);
            this.dgdTaggerSearchResults.Name = "dgdTaggerSearchResults";
            this.dgdTaggerSearchResults.Size = new System.Drawing.Size(402, 213);
            this.dgdTaggerSearchResults.TabIndex = 6;
            // 
            // lblTaggerSearchResults
            // 
            this.lblTaggerSearchResults.AutoSize = true;
            this.lblTaggerSearchResults.Location = new System.Drawing.Point(331, 9);
            this.lblTaggerSearchResults.Name = "lblTaggerSearchResults";
            this.lblTaggerSearchResults.Size = new System.Drawing.Size(49, 13);
            this.lblTaggerSearchResults.TabIndex = 7;
            this.lblTaggerSearchResults.Text = "Taggers:";
            // 
            // rdoSearchByLocation
            // 
            this.rdoSearchByLocation.AutoSize = true;
            this.rdoSearchByLocation.Checked = true;
            this.rdoSearchByLocation.Location = new System.Drawing.Point(6, 19);
            this.rdoSearchByLocation.Name = "rdoSearchByLocation";
            this.rdoSearchByLocation.Size = new System.Drawing.Size(66, 17);
            this.rdoSearchByLocation.TabIndex = 8;
            this.rdoSearchByLocation.TabStop = true;
            this.rdoSearchByLocation.Text = "Location";
            this.rdoSearchByLocation.UseVisualStyleBackColor = true;
            this.rdoSearchByLocation.CheckedChanged += new System.EventHandler(this.rdoSearchByLocation_CheckedChanged);
            // 
            // rdoSearchByTaggerInfo
            // 
            this.rdoSearchByTaggerInfo.AutoSize = true;
            this.rdoSearchByTaggerInfo.Location = new System.Drawing.Point(6, 42);
            this.rdoSearchByTaggerInfo.Name = "rdoSearchByTaggerInfo";
            this.rdoSearchByTaggerInfo.Size = new System.Drawing.Size(80, 17);
            this.rdoSearchByTaggerInfo.TabIndex = 9;
            this.rdoSearchByTaggerInfo.Text = "Tagger Info";
            this.rdoSearchByTaggerInfo.UseVisualStyleBackColor = true;
            this.rdoSearchByTaggerInfo.CheckedChanged += new System.EventHandler(this.rdoSearchByTaggerInfo_CheckedChanged);
            // 
            // grpSearchBy
            // 
            this.grpSearchBy.Controls.Add(this.rdoSearchByLocation);
            this.grpSearchBy.Controls.Add(this.rdoSearchByTaggerInfo);
            this.grpSearchBy.Location = new System.Drawing.Point(180, 221);
            this.grpSearchBy.Name = "grpSearchBy";
            this.grpSearchBy.Size = new System.Drawing.Size(110, 73);
            this.grpSearchBy.TabIndex = 10;
            this.grpSearchBy.TabStop = false;
            this.grpSearchBy.Text = "Search By:";
            // 
            // frmTaggerSearch
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelTaggerSearch;
            this.ClientSize = new System.Drawing.Size(745, 304);
            this.Controls.Add(this.grpSearchBy);
            this.Controls.Add(this.lblTaggerSearchResults);
            this.Controls.Add(this.dgdTaggerSearchResults);
            this.Controls.Add(this.grpByTaggerInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpByLocation);
            this.Controls.Add(this.btnCancelTaggerSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaggerSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search for Local Taggers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTaggerSearch_FormClosing);
            this.Load += new System.EventHandler(this.frmTaggerSearch_Load);
            this.grpByLocation.ResumeLayout(false);
            this.grpByLocation.PerformLayout();
            this.grpByTaggerInfo.ResumeLayout(false);
            this.grpByTaggerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdTaggerSearchResults)).EndInit();
            this.grpSearchBy.ResumeLayout(false);
            this.grpSearchBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelTaggerSearch;
        private System.Windows.Forms.GroupBox grpByLocation;
        private System.Windows.Forms.Label lblSearchCountry;
        private System.Windows.Forms.Label lblSearchStateProv;
        private System.Windows.Forms.Label lblSearchCity;
        private System.Windows.Forms.ComboBox cmbSearchCountry;
        private System.Windows.Forms.ComboBox cmbSearchStateProv;
        private System.Windows.Forms.TextBox txtSearchCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpByTaggerInfo;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblSearchTaggerID;
        private System.Windows.Forms.TextBox txtSearchTaggerID;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.DataGridView dgdTaggerSearchResults;
        private System.Windows.Forms.Label lblTaggerSearchResults;
        private System.Windows.Forms.RadioButton rdoSearchByLocation;
        private System.Windows.Forms.RadioButton rdoSearchByTaggerInfo;
        private System.Windows.Forms.GroupBox grpSearchBy;
    }
}