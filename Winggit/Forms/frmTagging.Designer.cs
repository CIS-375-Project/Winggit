namespace Winggit.Forms
{
    partial class frmTagging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTagging));
            this.btnCancelTag = new System.Windows.Forms.Button();
            this.btnEnterTag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelTag
            // 
            this.btnCancelTag.Location = new System.Drawing.Point(237, 148);
            this.btnCancelTag.Name = "btnCancelTag";
            this.btnCancelTag.Size = new System.Drawing.Size(75, 23);
            this.btnCancelTag.TabIndex = 0;
            this.btnCancelTag.Text = "Cancel";
            this.btnCancelTag.UseVisualStyleBackColor = true;
            this.btnCancelTag.Click += new System.EventHandler(this.btnCancelTag_Click);
            // 
            // btnEnterTag
            // 
            this.btnEnterTag.Enabled = false;
            this.btnEnterTag.Location = new System.Drawing.Point(12, 148);
            this.btnEnterTag.Name = "btnEnterTag";
            this.btnEnterTag.Size = new System.Drawing.Size(75, 23);
            this.btnEnterTag.TabIndex = 1;
            this.btnEnterTag.Text = "Enter Tag";
            this.btnEnterTag.UseVisualStyleBackColor = true;
            // 
            // frmTagging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 183);
            this.Controls.Add(this.btnEnterTag);
            this.Controls.Add(this.btnCancelTag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTagging";
            this.Text = "Enter New Tag Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelTag;
        private System.Windows.Forms.Button btnEnterTag;
    }
}