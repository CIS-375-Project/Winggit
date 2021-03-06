﻿namespace Winggit.Forms
{
    partial class frmComposeMsg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComposeMsg));
            this.btnCancelCompose = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.lblNewMsgRecipient = new System.Windows.Forms.Label();
            this.txtNewMsgRecipient = new System.Windows.Forms.TextBox();
            this.lblNewMsgSubject = new System.Windows.Forms.Label();
            this.txtNewMsgSubject = new System.Windows.Forms.TextBox();
            this.txtNewMsgBody = new System.Windows.Forms.TextBox();
            this.lblNewMsgBody = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelCompose
            // 
            this.btnCancelCompose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelCompose.Location = new System.Drawing.Point(274, 225);
            this.btnCancelCompose.Name = "btnCancelCompose";
            this.btnCancelCompose.Size = new System.Drawing.Size(75, 23);
            this.btnCancelCompose.TabIndex = 0;
            this.btnCancelCompose.Text = "Cancel";
            this.btnCancelCompose.UseVisualStyleBackColor = true;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Enabled = false;
            this.btnSendMsg.Location = new System.Drawing.Point(12, 225);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsg.TabIndex = 1;
            this.btnSendMsg.Text = "Send";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // lblNewMsgRecipient
            // 
            this.lblNewMsgRecipient.AutoSize = true;
            this.lblNewMsgRecipient.Location = new System.Drawing.Point(12, 9);
            this.lblNewMsgRecipient.Name = "lblNewMsgRecipient";
            this.lblNewMsgRecipient.Size = new System.Drawing.Size(55, 13);
            this.lblNewMsgRecipient.TabIndex = 2;
            this.lblNewMsgRecipient.Text = "Recipient:";
            // 
            // txtNewMsgRecipient
            // 
            this.txtNewMsgRecipient.Location = new System.Drawing.Point(73, 6);
            this.txtNewMsgRecipient.MaxLength = 9;
            this.txtNewMsgRecipient.Name = "txtNewMsgRecipient";
            this.txtNewMsgRecipient.Size = new System.Drawing.Size(276, 20);
            this.txtNewMsgRecipient.TabIndex = 3;
            this.txtNewMsgRecipient.TextChanged += new System.EventHandler(this.txtNewMsgRecipient_TextChanged);
            this.txtNewMsgRecipient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewMsgRecipient_KeyPress);
            // 
            // lblNewMsgSubject
            // 
            this.lblNewMsgSubject.AutoSize = true;
            this.lblNewMsgSubject.Location = new System.Drawing.Point(12, 35);
            this.lblNewMsgSubject.Name = "lblNewMsgSubject";
            this.lblNewMsgSubject.Size = new System.Drawing.Size(46, 13);
            this.lblNewMsgSubject.TabIndex = 4;
            this.lblNewMsgSubject.Text = "Subject:";
            // 
            // txtNewMsgSubject
            // 
            this.txtNewMsgSubject.Location = new System.Drawing.Point(73, 32);
            this.txtNewMsgSubject.Name = "txtNewMsgSubject";
            this.txtNewMsgSubject.Size = new System.Drawing.Size(276, 20);
            this.txtNewMsgSubject.TabIndex = 5;
            this.txtNewMsgSubject.TextChanged += new System.EventHandler(this.txtNewMsgSubject_TextChanged);
            // 
            // txtNewMsgBody
            // 
            this.txtNewMsgBody.Location = new System.Drawing.Point(73, 58);
            this.txtNewMsgBody.Multiline = true;
            this.txtNewMsgBody.Name = "txtNewMsgBody";
            this.txtNewMsgBody.Size = new System.Drawing.Size(276, 155);
            this.txtNewMsgBody.TabIndex = 6;
            this.txtNewMsgBody.TextChanged += new System.EventHandler(this.txtNewMsgBody_TextChanged);
            // 
            // lblNewMsgBody
            // 
            this.lblNewMsgBody.AutoSize = true;
            this.lblNewMsgBody.Location = new System.Drawing.Point(12, 61);
            this.lblNewMsgBody.Name = "lblNewMsgBody";
            this.lblNewMsgBody.Size = new System.Drawing.Size(34, 13);
            this.lblNewMsgBody.TabIndex = 7;
            this.lblNewMsgBody.Text = "Body:";
            // 
            // frmComposeMsg
            // 
            this.AcceptButton = this.btnSendMsg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelCompose;
            this.ClientSize = new System.Drawing.Size(360, 260);
            this.Controls.Add(this.lblNewMsgBody);
            this.Controls.Add(this.txtNewMsgBody);
            this.Controls.Add(this.txtNewMsgSubject);
            this.Controls.Add(this.lblNewMsgSubject);
            this.Controls.Add(this.txtNewMsgRecipient);
            this.Controls.Add(this.lblNewMsgRecipient);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.btnCancelCompose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmComposeMsg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compose New Message";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmComposeMsg_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelCompose;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.Label lblNewMsgRecipient;
        private System.Windows.Forms.TextBox txtNewMsgRecipient;
        private System.Windows.Forms.Label lblNewMsgSubject;
        private System.Windows.Forms.TextBox txtNewMsgSubject;
        private System.Windows.Forms.TextBox txtNewMsgBody;
        private System.Windows.Forms.Label lblNewMsgBody;
    }
}