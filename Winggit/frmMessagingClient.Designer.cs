﻿namespace Winggit
{
    partial class frmMessagingClient
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
            this.btnCancelMessaging = new System.Windows.Forms.Button();
            this.btnCompose = new System.Windows.Forms.Button();
            this.txtMsgContents = new System.Windows.Forms.TextBox();
            this.lblMsgContents = new System.Windows.Forms.Label();
            this.lblMsgSender = new System.Windows.Forms.Label();
            this.txtMsgSender = new System.Windows.Forms.TextBox();
            this.lblMsgSubject = new System.Windows.Forms.Label();
            this.txtMsgSubject = new System.Windows.Forms.TextBox();
            this.lblMsgTimestamp = new System.Windows.Forms.Label();
            this.txtMsgTimestamp = new System.Windows.Forms.TextBox();
            this.btnDeleteMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelMessaging
            // 
            this.btnCancelMessaging.Location = new System.Drawing.Point(526, 322);
            this.btnCancelMessaging.Name = "btnCancelMessaging";
            this.btnCancelMessaging.Size = new System.Drawing.Size(75, 23);
            this.btnCancelMessaging.TabIndex = 0;
            this.btnCancelMessaging.Text = "Cancel";
            this.btnCancelMessaging.UseVisualStyleBackColor = true;
            // 
            // btnCompose
            // 
            this.btnCompose.Location = new System.Drawing.Point(12, 322);
            this.btnCompose.Name = "btnCompose";
            this.btnCompose.Size = new System.Drawing.Size(75, 23);
            this.btnCompose.TabIndex = 1;
            this.btnCompose.Text = "Compose";
            this.btnCompose.UseVisualStyleBackColor = true;
            // 
            // txtMsgContents
            // 
            this.txtMsgContents.Location = new System.Drawing.Point(325, 150);
            this.txtMsgContents.Multiline = true;
            this.txtMsgContents.Name = "txtMsgContents";
            this.txtMsgContents.ReadOnly = true;
            this.txtMsgContents.Size = new System.Drawing.Size(276, 155);
            this.txtMsgContents.TabIndex = 2;
            // 
            // lblMsgContents
            // 
            this.lblMsgContents.AutoSize = true;
            this.lblMsgContents.Location = new System.Drawing.Point(322, 131);
            this.lblMsgContents.Name = "lblMsgContents";
            this.lblMsgContents.Size = new System.Drawing.Size(52, 13);
            this.lblMsgContents.TabIndex = 3;
            this.lblMsgContents.Text = "Contents:";
            // 
            // lblMsgSender
            // 
            this.lblMsgSender.AutoSize = true;
            this.lblMsgSender.Location = new System.Drawing.Point(322, 9);
            this.lblMsgSender.Name = "lblMsgSender";
            this.lblMsgSender.Size = new System.Drawing.Size(44, 13);
            this.lblMsgSender.TabIndex = 4;
            this.lblMsgSender.Text = "Sender:";
            // 
            // txtMsgSender
            // 
            this.txtMsgSender.Location = new System.Drawing.Point(325, 25);
            this.txtMsgSender.Name = "txtMsgSender";
            this.txtMsgSender.ReadOnly = true;
            this.txtMsgSender.Size = new System.Drawing.Size(276, 20);
            this.txtMsgSender.TabIndex = 5;
            // 
            // lblMsgSubject
            // 
            this.lblMsgSubject.AutoSize = true;
            this.lblMsgSubject.Location = new System.Drawing.Point(322, 48);
            this.lblMsgSubject.Name = "lblMsgSubject";
            this.lblMsgSubject.Size = new System.Drawing.Size(46, 13);
            this.lblMsgSubject.TabIndex = 6;
            this.lblMsgSubject.Text = "Subject:";
            // 
            // txtMsgSubject
            // 
            this.txtMsgSubject.Location = new System.Drawing.Point(325, 65);
            this.txtMsgSubject.Name = "txtMsgSubject";
            this.txtMsgSubject.ReadOnly = true;
            this.txtMsgSubject.Size = new System.Drawing.Size(276, 20);
            this.txtMsgSubject.TabIndex = 7;
            // 
            // lblMsgTimestamp
            // 
            this.lblMsgTimestamp.AutoSize = true;
            this.lblMsgTimestamp.Location = new System.Drawing.Point(322, 88);
            this.lblMsgTimestamp.Name = "lblMsgTimestamp";
            this.lblMsgTimestamp.Size = new System.Drawing.Size(61, 13);
            this.lblMsgTimestamp.TabIndex = 8;
            this.lblMsgTimestamp.Text = "Timestamp:";
            // 
            // txtMsgTimestamp
            // 
            this.txtMsgTimestamp.Location = new System.Drawing.Point(325, 105);
            this.txtMsgTimestamp.Name = "txtMsgTimestamp";
            this.txtMsgTimestamp.ReadOnly = true;
            this.txtMsgTimestamp.Size = new System.Drawing.Size(276, 20);
            this.txtMsgTimestamp.TabIndex = 9;
            // 
            // btnDeleteMsg
            // 
            this.btnDeleteMsg.Enabled = false;
            this.btnDeleteMsg.Location = new System.Drawing.Point(93, 322);
            this.btnDeleteMsg.Name = "btnDeleteMsg";
            this.btnDeleteMsg.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMsg.TabIndex = 10;
            this.btnDeleteMsg.Text = "Delete";
            this.btnDeleteMsg.UseVisualStyleBackColor = true;
            // 
            // frmMessagingClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 357);
            this.Controls.Add(this.btnDeleteMsg);
            this.Controls.Add(this.txtMsgTimestamp);
            this.Controls.Add(this.lblMsgTimestamp);
            this.Controls.Add(this.txtMsgSubject);
            this.Controls.Add(this.lblMsgSubject);
            this.Controls.Add(this.txtMsgSender);
            this.Controls.Add(this.lblMsgSender);
            this.Controls.Add(this.lblMsgContents);
            this.Controls.Add(this.txtMsgContents);
            this.Controls.Add(this.btnCompose);
            this.Controls.Add(this.btnCancelMessaging);
            this.Name = "frmMessagingClient";
            this.Text = "Kaleidoscope Messaging";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelMessaging;
        private System.Windows.Forms.Button btnCompose;
        private System.Windows.Forms.TextBox txtMsgContents;
        private System.Windows.Forms.Label lblMsgContents;
        private System.Windows.Forms.Label lblMsgSender;
        private System.Windows.Forms.TextBox txtMsgSender;
        private System.Windows.Forms.Label lblMsgSubject;
        private System.Windows.Forms.TextBox txtMsgSubject;
        private System.Windows.Forms.Label lblMsgTimestamp;
        private System.Windows.Forms.TextBox txtMsgTimestamp;
        private System.Windows.Forms.Button btnDeleteMsg;
    }
}