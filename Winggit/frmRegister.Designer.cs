namespace Winggit
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
            this.btnCancelReg = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblRegName = new System.Windows.Forms.Label();
            this.txtRegName = new System.Windows.Forms.TextBox();
            this.lblRegPhoneNum = new System.Windows.Forms.Label();
            this.txtRegPhoneNum = new System.Windows.Forms.TextBox();
            this.lblRegAddress = new System.Windows.Forms.Label();
            this.lblRegHouseNumStreet = new System.Windows.Forms.Label();
            this.txtRegHouseNumStreet = new System.Windows.Forms.TextBox();
            this.lblRegCity = new System.Windows.Forms.Label();
            this.txtRegCity = new System.Windows.Forms.TextBox();
            this.lblRegStateProv = new System.Windows.Forms.Label();
            this.cmbRegStateProv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRegCountry = new System.Windows.Forms.ComboBox();
            this.pnlRegAddress = new System.Windows.Forms.Panel();
            this.pnlRegAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelReg
            // 
            this.btnCancelReg.Location = new System.Drawing.Point(247, 208);
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
            // 
            // lblRegName
            // 
            this.lblRegName.AutoSize = true;
            this.lblRegName.Location = new System.Drawing.Point(12, 24);
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
            this.lblRegPhoneNum.Location = new System.Drawing.Point(12, 49);
            this.lblRegPhoneNum.Name = "lblRegPhoneNum";
            this.lblRegPhoneNum.Size = new System.Drawing.Size(51, 13);
            this.lblRegPhoneNum.TabIndex = 4;
            this.lblRegPhoneNum.Text = "Phone #:";
            // 
            // txtRegPhoneNum
            // 
            this.txtRegPhoneNum.Location = new System.Drawing.Point(121, 47);
            this.txtRegPhoneNum.Name = "txtRegPhoneNum";
            this.txtRegPhoneNum.ShortcutsEnabled = false;
            this.txtRegPhoneNum.Size = new System.Drawing.Size(201, 20);
            this.txtRegPhoneNum.TabIndex = 5;
            this.txtRegPhoneNum.TextChanged += new System.EventHandler(this.txtRegPhoneNum_TextChanged);
            this.txtRegPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegPhoneNum_KeyPress);
            // 
            // lblRegAddress
            // 
            this.lblRegAddress.AutoSize = true;
            this.lblRegAddress.Location = new System.Drawing.Point(12, 74);
            this.lblRegAddress.Name = "lblRegAddress";
            this.lblRegAddress.Size = new System.Drawing.Size(48, 13);
            this.lblRegAddress.TabIndex = 7;
            this.lblRegAddress.Text = "Address:";
            // 
            // lblRegHouseNumStreet
            // 
            this.lblRegHouseNumStreet.AutoSize = true;
            this.lblRegHouseNumStreet.Location = new System.Drawing.Point(3, 9);
            this.lblRegHouseNumStreet.Name = "lblRegHouseNumStreet";
            this.lblRegHouseNumStreet.Size = new System.Drawing.Size(103, 13);
            this.lblRegHouseNumStreet.TabIndex = 8;
            this.lblRegHouseNumStreet.Text = "House # and Street:";
            // 
            // txtRegHouseNumStreet
            // 
            this.txtRegHouseNumStreet.Location = new System.Drawing.Point(121, 97);
            this.txtRegHouseNumStreet.Name = "txtRegHouseNumStreet";
            this.txtRegHouseNumStreet.Size = new System.Drawing.Size(201, 20);
            this.txtRegHouseNumStreet.TabIndex = 9;
            this.txtRegHouseNumStreet.TextChanged += new System.EventHandler(this.txtRegHouseNumStreet_TextChanged);
            // 
            // lblRegCity
            // 
            this.lblRegCity.AutoSize = true;
            this.lblRegCity.Location = new System.Drawing.Point(3, 36);
            this.lblRegCity.Name = "lblRegCity";
            this.lblRegCity.Size = new System.Drawing.Size(27, 13);
            this.lblRegCity.TabIndex = 10;
            this.lblRegCity.Text = "City:";
            // 
            // txtRegCity
            // 
            this.txtRegCity.Location = new System.Drawing.Point(121, 123);
            this.txtRegCity.Name = "txtRegCity";
            this.txtRegCity.Size = new System.Drawing.Size(201, 20);
            this.txtRegCity.TabIndex = 11;
            this.txtRegCity.TextChanged += new System.EventHandler(this.txtRegCity_TextChanged);
            // 
            // lblRegStateProv
            // 
            this.lblRegStateProv.AutoSize = true;
            this.lblRegStateProv.Location = new System.Drawing.Point(3, 62);
            this.lblRegStateProv.Name = "lblRegStateProv";
            this.lblRegStateProv.Size = new System.Drawing.Size(82, 13);
            this.lblRegStateProv.TabIndex = 12;
            this.lblRegStateProv.Text = "State/Province:";
            // 
            // cmbRegStateProv
            // 
            this.cmbRegStateProv.Enabled = false;
            this.cmbRegStateProv.FormattingEnabled = true;
            this.cmbRegStateProv.Location = new System.Drawing.Point(121, 149);
            this.cmbRegStateProv.Name = "cmbRegStateProv";
            this.cmbRegStateProv.Size = new System.Drawing.Size(201, 21);
            this.cmbRegStateProv.TabIndex = 13;
            this.cmbRegStateProv.SelectedIndexChanged += new System.EventHandler(this.cmbRegStateProv_SelectedIndexChanged);
            this.cmbRegStateProv.DataSourceChanged += new System.EventHandler(this.cmbRegStateProv_DataSourceChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Country:";
            // 
            // cmbRegCountry
            // 
            this.cmbRegCountry.FormattingEnabled = true;
            this.cmbRegCountry.Location = new System.Drawing.Point(121, 176);
            this.cmbRegCountry.Name = "cmbRegCountry";
            this.cmbRegCountry.Size = new System.Drawing.Size(201, 21);
            this.cmbRegCountry.TabIndex = 15;
            this.cmbRegCountry.SelectedIndexChanged += new System.EventHandler(this.cmbRegCountry_SelectedIndexChanged);
            // 
            // pnlRegAddress
            // 
            this.pnlRegAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegAddress.Controls.Add(this.label1);
            this.pnlRegAddress.Controls.Add(this.lblRegStateProv);
            this.pnlRegAddress.Controls.Add(this.lblRegCity);
            this.pnlRegAddress.Controls.Add(this.lblRegHouseNumStreet);
            this.pnlRegAddress.Location = new System.Drawing.Point(11, 90);
            this.pnlRegAddress.Name = "pnlRegAddress";
            this.pnlRegAddress.Size = new System.Drawing.Size(320, 112);
            this.pnlRegAddress.TabIndex = 16;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 243);
            this.Controls.Add(this.cmbRegCountry);
            this.Controls.Add(this.cmbRegStateProv);
            this.Controls.Add(this.txtRegCity);
            this.Controls.Add(this.txtRegHouseNumStreet);
            this.Controls.Add(this.lblRegAddress);
            this.Controls.Add(this.txtRegPhoneNum);
            this.Controls.Add(this.lblRegPhoneNum);
            this.Controls.Add(this.txtRegName);
            this.Controls.Add(this.lblRegName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancelReg);
            this.Controls.Add(this.pnlRegAddress);
            this.Name = "frmRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.pnlRegAddress.ResumeLayout(false);
            this.pnlRegAddress.PerformLayout();
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
        private System.Windows.Forms.Label lblRegAddress;
        private System.Windows.Forms.Label lblRegHouseNumStreet;
        private System.Windows.Forms.TextBox txtRegHouseNumStreet;
        private System.Windows.Forms.Label lblRegCity;
        private System.Windows.Forms.TextBox txtRegCity;
        private System.Windows.Forms.Label lblRegStateProv;
        private System.Windows.Forms.ComboBox cmbRegStateProv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRegCountry;
        private System.Windows.Forms.Panel pnlRegAddress;
    }
}