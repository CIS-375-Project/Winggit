﻿namespace Winggit.Forms
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
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelReports;
            this.ClientSize = new System.Drawing.Size(510, 401);
            this.Controls.Add(this.btnCancelReports);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReports";
            this.Text = "Generate Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelReports;
    }
}