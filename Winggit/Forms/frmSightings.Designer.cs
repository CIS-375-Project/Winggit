namespace Winggit.Forms
{
    partial class frmSightings
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
            this.btnCancelSightings = new System.Windows.Forms.Button();
            this.btnGoToTagging = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelSightings
            // 
            this.btnCancelSightings.Location = new System.Drawing.Point(197, 226);
            this.btnCancelSightings.Name = "btnCancelSightings";
            this.btnCancelSightings.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSightings.TabIndex = 0;
            this.btnCancelSightings.Text = "Cancel";
            this.btnCancelSightings.UseVisualStyleBackColor = true;
            this.btnCancelSightings.Click += new System.EventHandler(this.btnCancelSightings_Click);
            // 
            // btnGoToTagging
            // 
            this.btnGoToTagging.Location = new System.Drawing.Point(13, 226);
            this.btnGoToTagging.Name = "btnGoToTagging";
            this.btnGoToTagging.Size = new System.Drawing.Size(75, 23);
            this.btnGoToTagging.TabIndex = 1;
            this.btnGoToTagging.Text = "New Tag";
            this.btnGoToTagging.UseVisualStyleBackColor = true;
            // 
            // frmSightings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGoToTagging);
            this.Controls.Add(this.btnCancelSightings);
            this.Name = "frmSightings";
            this.Text = "Report Sighting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelSightings;
        private System.Windows.Forms.Button btnGoToTagging;
    }
}