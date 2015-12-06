namespace Winggit.Forms
{
    partial class frmLogInReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogInReg));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnGoToLogIn = new System.Windows.Forms.Button();
            this.btnGoToRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(77, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(116, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Please log in or register";
            // 
            // btnGoToLogIn
            // 
            this.btnGoToLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToLogIn.Location = new System.Drawing.Point(12, 46);
            this.btnGoToLogIn.Name = "btnGoToLogIn";
            this.btnGoToLogIn.Size = new System.Drawing.Size(86, 28);
            this.btnGoToLogIn.TabIndex = 1;
            this.btnGoToLogIn.Text = "Log In";
            this.btnGoToLogIn.UseVisualStyleBackColor = true;
            this.btnGoToLogIn.Click += new System.EventHandler(this.btnGoToLogIn_Click);
            // 
            // btnGoToRegister
            // 
            this.btnGoToRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToRegister.Location = new System.Drawing.Point(167, 46);
            this.btnGoToRegister.Name = "btnGoToRegister";
            this.btnGoToRegister.Size = new System.Drawing.Size(86, 28);
            this.btnGoToRegister.TabIndex = 1;
            this.btnGoToRegister.Text = "Register";
            this.btnGoToRegister.UseVisualStyleBackColor = true;
            this.btnGoToRegister.Click += new System.EventHandler(this.btnGoToRegister_Click);
            // 
            // frmLogInReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 86);
            this.Controls.Add(this.btnGoToRegister);
            this.Controls.Add(this.btnGoToLogIn);
            this.Controls.Add(this.lblWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogInReg";
            this.Text = "Welcome to Winggit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnGoToLogIn;
        private System.Windows.Forms.Button btnGoToRegister;
    }
}

