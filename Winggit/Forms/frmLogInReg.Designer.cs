﻿namespace Winggit.Forms
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
            this.btnExitLogInReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(91, 9);
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
            this.btnGoToRegister.Location = new System.Drawing.Point(104, 46);
            this.btnGoToRegister.Name = "btnGoToRegister";
            this.btnGoToRegister.Size = new System.Drawing.Size(86, 28);
            this.btnGoToRegister.TabIndex = 1;
            this.btnGoToRegister.Text = "Register";
            this.btnGoToRegister.UseVisualStyleBackColor = true;
            this.btnGoToRegister.Click += new System.EventHandler(this.btnGoToRegister_Click);
            // 
            // btnExitLogInReg
            // 
            this.btnExitLogInReg.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitLogInReg.Location = new System.Drawing.Point(196, 46);
            this.btnExitLogInReg.Name = "btnExitLogInReg";
            this.btnExitLogInReg.Size = new System.Drawing.Size(86, 28);
            this.btnExitLogInReg.TabIndex = 2;
            this.btnExitLogInReg.Text = "Exit";
            this.btnExitLogInReg.UseVisualStyleBackColor = true;
            this.btnExitLogInReg.Click += new System.EventHandler(this.btnExitLogInReg_Click);
            // 
            // frmLogInReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExitLogInReg;
            this.ClientSize = new System.Drawing.Size(294, 86);
            this.Controls.Add(this.btnExitLogInReg);
            this.Controls.Add(this.btnGoToRegister);
            this.Controls.Add(this.btnGoToLogIn);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogInReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Winggit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogInReg_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnGoToLogIn;
        private System.Windows.Forms.Button btnGoToRegister;
        private System.Windows.Forms.Button btnExitLogInReg;
    }
}

