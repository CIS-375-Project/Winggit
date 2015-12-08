namespace Winggit.Forms
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.btnCancelReg = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblRegName = new System.Windows.Forms.Label();
            this.txtRegName = new System.Windows.Forms.TextBox();
            this.lblRegPhoneNum = new System.Windows.Forms.Label();
            this.txtRegPhoneNum = new System.Windows.Forms.TextBox();
            this.txtRegHouseNumStreet = new System.Windows.Forms.TextBox();
            this.txtRegCity = new System.Windows.Forms.TextBox();
            this.cmbRegStateProv = new System.Windows.Forms.ComboBox();
            this.cmbRegCountry = new System.Windows.Forms.ComboBox();
            this.lblRegHouseNumStreet = new System.Windows.Forms.Label();
            this.lblRegCity = new System.Windows.Forms.Label();
            this.lblRegStateProv = new System.Windows.Forms.Label();
            this.lblRegCountry = new System.Windows.Forms.Label();
            this.grpRegAddress = new System.Windows.Forms.GroupBox();
            this.grpRegAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelReg
            // 
            this.btnCancelReg.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelReg.Location = new System.Drawing.Point(256, 208);
            this.btnCancelReg.Name = "btnCancelReg";
            this.btnCancelReg.Size = new System.Drawing.Size(75, 23);
            this.btnCancelReg.TabIndex = 0;
            this.btnCancelReg.Text = "Cancel";
            this.btnCancelReg.UseVisualStyleBackColor = true;
            this.btnCancelReg.Click += new System.EventHandler(this.btnCancelReg_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Enabled = false;
            this.btnRegister.Location = new System.Drawing.Point(11, 208);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblRegName
            // 
            this.lblRegName.AutoSize = true;
            this.lblRegName.Location = new System.Drawing.Point(17, 24);
            this.lblRegName.Name = "lblRegName";
            this.lblRegName.Size = new System.Drawing.Size(57, 13);
            this.lblRegName.TabIndex = 2;
            this.lblRegName.Text = "Full Name:";
            // 
            // txtRegName
            // 
            this.txtRegName.Location = new System.Drawing.Point(121, 21);
            this.txtRegName.Name = "txtRegName";
            this.txtRegName.Size = new System.Drawing.Size(201, 20);
            this.txtRegName.TabIndex = 3;
            this.txtRegName.TextChanged += new System.EventHandler(this.txtRegName_TextChanged);
            // 
            // lblRegPhoneNum
            // 
            this.lblRegPhoneNum.AutoSize = true;
            this.lblRegPhoneNum.Location = new System.Drawing.Point(17, 50);
            this.lblRegPhoneNum.Name = "lblRegPhoneNum";
            this.lblRegPhoneNum.Size = new System.Drawing.Size(81, 13);
            this.lblRegPhoneNum.TabIndex = 4;
            this.lblRegPhoneNum.Text = "Phone Number:";
            // 
            // txtRegPhoneNum
            // 
            this.txtRegPhoneNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRegPhoneNum.Location = new System.Drawing.Point(121, 47);
            this.txtRegPhoneNum.MaxLength = 10;
            this.txtRegPhoneNum.Name = "txtRegPhoneNum";
            this.txtRegPhoneNum.ShortcutsEnabled = false;
            this.txtRegPhoneNum.Size = new System.Drawing.Size(201, 20);
            this.txtRegPhoneNum.TabIndex = 5;
            this.txtRegPhoneNum.TextChanged += new System.EventHandler(this.txtRegPhoneNum_TextChanged);
            this.txtRegPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegPhoneNum_KeyPress);
            // 
            // txtRegHouseNumStreet
            // 
            this.txtRegHouseNumStreet.Location = new System.Drawing.Point(110, 19);
            this.txtRegHouseNumStreet.Name = "txtRegHouseNumStreet";
            this.txtRegHouseNumStreet.Size = new System.Drawing.Size(201, 20);
            this.txtRegHouseNumStreet.TabIndex = 9;
            this.txtRegHouseNumStreet.TextChanged += new System.EventHandler(this.txtRegHouseNumStreet_TextChanged);
            // 
            // txtRegCity
            // 
            this.txtRegCity.Location = new System.Drawing.Point(110, 49);
            this.txtRegCity.Name = "txtRegCity";
            this.txtRegCity.Size = new System.Drawing.Size(201, 20);
            this.txtRegCity.TabIndex = 11;
            this.txtRegCity.TextChanged += new System.EventHandler(this.txtRegCity_TextChanged);
            // 
            // cmbRegStateProv
            // 
            this.cmbRegStateProv.Enabled = false;
            this.cmbRegStateProv.FormattingEnabled = true;
            this.cmbRegStateProv.Location = new System.Drawing.Point(110, 75);
            this.cmbRegStateProv.Name = "cmbRegStateProv";
            this.cmbRegStateProv.Size = new System.Drawing.Size(201, 21);
            this.cmbRegStateProv.TabIndex = 13;
            this.cmbRegStateProv.SelectedIndexChanged += new System.EventHandler(this.cmbRegStateProv_SelectedIndexChanged);
            this.cmbRegStateProv.DataSourceChanged += new System.EventHandler(this.cmbRegStateProv_DataSourceChanged);
            // 
            // cmbRegCountry
            // 
            this.cmbRegCountry.FormattingEnabled = true;
            this.cmbRegCountry.Location = new System.Drawing.Point(110, 102);
            this.cmbRegCountry.Name = "cmbRegCountry";
            this.cmbRegCountry.Size = new System.Drawing.Size(201, 21);
            this.cmbRegCountry.TabIndex = 15;
            this.cmbRegCountry.SelectedIndexChanged += new System.EventHandler(this.cmbRegCountry_SelectedIndexChanged);
            // 
            // lblRegHouseNumStreet
            // 
            this.lblRegHouseNumStreet.AutoSize = true;
            this.lblRegHouseNumStreet.Location = new System.Drawing.Point(6, 22);
            this.lblRegHouseNumStreet.Name = "lblRegHouseNumStreet";
            this.lblRegHouseNumStreet.Size = new System.Drawing.Size(103, 13);
            this.lblRegHouseNumStreet.TabIndex = 8;
            this.lblRegHouseNumStreet.Text = "House # and Street:";
            // 
            // lblRegCity
            // 
            this.lblRegCity.AutoSize = true;
            this.lblRegCity.Location = new System.Drawing.Point(6, 52);
            this.lblRegCity.Name = "lblRegCity";
            this.lblRegCity.Size = new System.Drawing.Size(27, 13);
            this.lblRegCity.TabIndex = 10;
            this.lblRegCity.Text = "City:";
            // 
            // lblRegStateProv
            // 
            this.lblRegStateProv.AutoSize = true;
            this.lblRegStateProv.Location = new System.Drawing.Point(6, 78);
            this.lblRegStateProv.Name = "lblRegStateProv";
            this.lblRegStateProv.Size = new System.Drawing.Size(82, 13);
            this.lblRegStateProv.TabIndex = 12;
            this.lblRegStateProv.Text = "State/Province:";
            // 
            // lblRegCountry
            // 
            this.lblRegCountry.AutoSize = true;
            this.lblRegCountry.Location = new System.Drawing.Point(6, 105);
            this.lblRegCountry.Name = "lblRegCountry";
            this.lblRegCountry.Size = new System.Drawing.Size(46, 13);
            this.lblRegCountry.TabIndex = 14;
            this.lblRegCountry.Text = "Country:";
            // 
            // grpRegAddress
            // 
            this.grpRegAddress.Controls.Add(this.cmbRegCountry);
            this.grpRegAddress.Controls.Add(this.lblRegHouseNumStreet);
            this.grpRegAddress.Controls.Add(this.lblRegCountry);
            this.grpRegAddress.Controls.Add(this.cmbRegStateProv);
            this.grpRegAddress.Controls.Add(this.lblRegCity);
            this.grpRegAddress.Controls.Add(this.txtRegCity);
            this.grpRegAddress.Controls.Add(this.lblRegStateProv);
            this.grpRegAddress.Controls.Add(this.txtRegHouseNumStreet);
            this.grpRegAddress.Location = new System.Drawing.Point(11, 73);
            this.grpRegAddress.Name = "grpRegAddress";
            this.grpRegAddress.Size = new System.Drawing.Size(319, 129);
            this.grpRegAddress.TabIndex = 16;
            this.grpRegAddress.TabStop = false;
            this.grpRegAddress.Text = "Address";
            // 
            // frmRegister
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelReg;
            this.ClientSize = new System.Drawing.Size(343, 243);
            this.Controls.Add(this.grpRegAddress);
            this.Controls.Add(this.txtRegPhoneNum);
            this.Controls.Add(this.lblRegPhoneNum);
            this.Controls.Add(this.txtRegName);
            this.Controls.Add(this.lblRegName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancelReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.grpRegAddress.ResumeLayout(false);
            this.grpRegAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelReg;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblRegName;
        private System.Windows.Forms.TextBox txtRegName;
        private System.Windows.Forms.Label lblRegPhoneNum;
        private System.Windows.Forms.TextBox txtRegPhoneNum;
        private System.Windows.Forms.TextBox txtRegHouseNumStreet;
        private System.Windows.Forms.TextBox txtRegCity;
        private System.Windows.Forms.ComboBox cmbRegStateProv;
        private System.Windows.Forms.ComboBox cmbRegCountry;
        private System.Windows.Forms.GroupBox grpRegAddress;
        private System.Windows.Forms.Label lblRegCountry;
        private System.Windows.Forms.Label lblRegStateProv;
        private System.Windows.Forms.Label lblRegCity;
        private System.Windows.Forms.Label lblRegHouseNumStreet;
    }
}