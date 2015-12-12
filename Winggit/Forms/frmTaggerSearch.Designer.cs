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
            this.grpSearchByLocation = new System.Windows.Forms.GroupBox();
            this.lblSearchCountry = new System.Windows.Forms.Label();
            this.lblSearchStateProv = new System.Windows.Forms.Label();
            this.lblSearchCity = new System.Windows.Forms.Label();
            this.cmbSearchCountry = new System.Windows.Forms.ComboBox();
            this.cmbSearchStateProv = new System.Windows.Forms.ComboBox();
            this.txtSearchCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSearchTaggerID = new System.Windows.Forms.Label();
            this.txtSearchTaggerID = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.dgdTaggerSearchResults = new System.Windows.Forms.DataGridView();
            this.lblTaggerSearchResults = new System.Windows.Forms.Label();
            this.grpSearchByLocation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdTaggerSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelTaggerSearch
            // 
            this.btnCancelTaggerSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelTaggerSearch.Location = new System.Drawing.Point(598, 245);
            this.btnCancelTaggerSearch.Name = "btnCancelTaggerSearch";
            this.btnCancelTaggerSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCancelTaggerSearch.TabIndex = 2;
            this.btnCancelTaggerSearch.Text = "Cancel";
            this.btnCancelTaggerSearch.UseVisualStyleBackColor = true;
            this.btnCancelTaggerSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // grpSearchByLocation
            // 
            this.grpSearchByLocation.Controls.Add(this.lblSearchCountry);
            this.grpSearchByLocation.Controls.Add(this.lblSearchStateProv);
            this.grpSearchByLocation.Controls.Add(this.lblSearchCity);
            this.grpSearchByLocation.Controls.Add(this.cmbSearchCountry);
            this.grpSearchByLocation.Controls.Add(this.cmbSearchStateProv);
            this.grpSearchByLocation.Controls.Add(this.txtSearchCity);
            this.grpSearchByLocation.Location = new System.Drawing.Point(12, 12);
            this.grpSearchByLocation.Name = "grpSearchByLocation";
            this.grpSearchByLocation.Size = new System.Drawing.Size(310, 108);
            this.grpSearchByLocation.TabIndex = 3;
            this.grpSearchByLocation.TabStop = false;
            this.grpSearchByLocation.Text = "Search by Location";
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
            // 
            // txtSearchCity
            // 
            this.txtSearchCity.Location = new System.Drawing.Point(101, 19);
            this.txtSearchCity.Name = "txtSearchCity";
            this.txtSearchCity.Size = new System.Drawing.Size(201, 20);
            this.txtSearchCity.TabIndex = 17;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSearchTaggerID);
            this.groupBox1.Controls.Add(this.txtSearchTaggerID);
            this.groupBox1.Controls.Add(this.lblSearchName);
            this.groupBox1.Controls.Add(this.txtSearchName);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by Tagger Info";
            // 
            // lblSearchTaggerID
            // 
            this.lblSearchTaggerID.AutoSize = true;
            this.lblSearchTaggerID.Location = new System.Drawing.Point(6, 48);
            this.lblSearchTaggerID.Name = "lblSearchTaggerID";
            this.lblSearchTaggerID.Size = new System.Drawing.Size(58, 13);
            this.lblSearchTaggerID.TabIndex = 3;
            this.lblSearchTaggerID.Text = "Tagger ID:";
            // 
            // txtSearchTaggerID
            // 
            this.txtSearchTaggerID.Location = new System.Drawing.Point(101, 45);
            this.txtSearchTaggerID.Name = "txtSearchTaggerID";
            this.txtSearchTaggerID.ShortcutsEnabled = false;
            this.txtSearchTaggerID.Size = new System.Drawing.Size(201, 20);
            this.txtSearchTaggerID.TabIndex = 2;
            this.txtSearchTaggerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchTaggerID_KeyPress);
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(6, 22);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(38, 13);
            this.lblSearchName.TabIndex = 1;
            this.lblSearchName.Text = "Name:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(101, 19);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(201, 20);
            this.txtSearchName.TabIndex = 0;
            // 
            // dgdTaggerSearchResults
            // 
            this.dgdTaggerSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdTaggerSearchResults.Location = new System.Drawing.Point(328, 25);
            this.dgdTaggerSearchResults.Name = "dgdTaggerSearchResults";
            this.dgdTaggerSearchResults.Size = new System.Drawing.Size(345, 213);
            this.dgdTaggerSearchResults.TabIndex = 6;
            // 
            // lblTaggerSearchResults
            // 
            this.lblTaggerSearchResults.AutoSize = true;
            this.lblTaggerSearchResults.Location = new System.Drawing.Point(328, 9);
            this.lblTaggerSearchResults.Name = "lblTaggerSearchResults";
            this.lblTaggerSearchResults.Size = new System.Drawing.Size(49, 13);
            this.lblTaggerSearchResults.TabIndex = 7;
            this.lblTaggerSearchResults.Text = "Taggers:";
            // 
            // frmTaggerSearch
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelTaggerSearch;
            this.ClientSize = new System.Drawing.Size(685, 280);
            this.Controls.Add(this.lblTaggerSearchResults);
            this.Controls.Add(this.dgdTaggerSearchResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpSearchByLocation);
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
            this.grpSearchByLocation.ResumeLayout(false);
            this.grpSearchByLocation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdTaggerSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelTaggerSearch;
        private System.Windows.Forms.GroupBox grpSearchByLocation;
        private System.Windows.Forms.Label lblSearchCountry;
        private System.Windows.Forms.Label lblSearchStateProv;
        private System.Windows.Forms.Label lblSearchCity;
        private System.Windows.Forms.ComboBox cmbSearchCountry;
        private System.Windows.Forms.ComboBox cmbSearchStateProv;
        private System.Windows.Forms.TextBox txtSearchCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblSearchTaggerID;
        private System.Windows.Forms.TextBox txtSearchTaggerID;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.DataGridView dgdTaggerSearchResults;
        private System.Windows.Forms.Label lblTaggerSearchResults;
    }
}