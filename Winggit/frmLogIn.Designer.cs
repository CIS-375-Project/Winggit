namespace Winggit
{
    partial class frmLogIn
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
            this.btnCancelLogIn = new System.Windows.Forms.Button();
            this.lblLogInID = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtLogInID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelLogIn
            // 
            this.btnCancelLogIn.Location = new System.Drawing.Point(127, 61);
            this.btnCancelLogIn.Name = "btnCancelLogIn";
            this.btnCancelLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnCancelLogIn.TabIndex = 0;
            this.btnCancelLogIn.Text = "Cancel";
            this.btnCancelLogIn.UseVisualStyleBackColor = true;
            this.btnCancelLogIn.Click += new System.EventHandler(this.btnCancelLogIn_Click);
            // 
            // lblLogInID
            // 
            this.lblLogInID.AutoSize = true;
            this.lblLogInID.Location = new System.Drawing.Point(12, 21);
            this.lblLogInID.Name = "lblLogInID";
            this.lblLogInID.Size = new System.Drawing.Size(58, 13);
            this.lblLogInID.TabIndex = 1;
            this.lblLogInID.Text = "Tagger ID:";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Enabled = false;
            this.btnLogIn.Location = new System.Drawing.Point(15, 61);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtLogInID
            // 
            this.txtLogInID.Location = new System.Drawing.Point(76, 18);
            this.txtLogInID.Name = "txtLogInID";
            this.txtLogInID.Size = new System.Drawing.Size(100, 20);
            this.txtLogInID.TabIndex = 3;
            this.txtLogInID.TextChanged += new System.EventHandler(this.txtLogInID_TextChanged);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 90);
            this.Controls.Add(this.txtLogInID);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lblLogInID);
            this.Controls.Add(this.btnCancelLogIn);
            this.Name = "frmLogIn";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelLogIn;
        private System.Windows.Forms.Label lblLogInID;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtLogInID;
    }
}