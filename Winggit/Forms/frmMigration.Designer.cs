namespace Winggit
{
    partial class frmMigration
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
            this.btnCancelMigration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelMigration
            // 
            this.btnCancelMigration.Location = new System.Drawing.Point(1127, 378);
            this.btnCancelMigration.Name = "btnCancelMigration";
            this.btnCancelMigration.Size = new System.Drawing.Size(75, 23);
            this.btnCancelMigration.TabIndex = 0;
            this.btnCancelMigration.Text = "Cancel";
            this.btnCancelMigration.UseVisualStyleBackColor = true;
            this.btnCancelMigration.Click += new System.EventHandler(this.btnCancelMigration_Click);
            // 
            // frmMigration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 413);
            this.Controls.Add(this.btnCancelMigration);
            this.Name = "frmMigration";
            this.Text = "Migration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelMigration;
    }
}