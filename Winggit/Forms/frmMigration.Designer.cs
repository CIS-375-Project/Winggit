namespace Winggit.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMigration));
            this.btnCancelMigration = new System.Windows.Forms.Button();
            this.txtMigrationTagID = new System.Windows.Forms.TextBox();
            this.lblMigrationTagID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelMigration
            // 
            this.btnCancelMigration.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelMigration.Location = new System.Drawing.Point(500, 378);
            this.btnCancelMigration.Name = "btnCancelMigration";
            this.btnCancelMigration.Size = new System.Drawing.Size(75, 23);
            this.btnCancelMigration.TabIndex = 0;
            this.btnCancelMigration.Text = "Cancel";
            this.btnCancelMigration.UseVisualStyleBackColor = true;
            this.btnCancelMigration.Click += new System.EventHandler(this.btnCancelMigration_Click);
            // 
            // txtMigrationTagID
            // 
            this.txtMigrationTagID.Location = new System.Drawing.Point(25, 55);
            this.txtMigrationTagID.Name = "txtMigrationTagID";
            this.txtMigrationTagID.Size = new System.Drawing.Size(100, 20);
            this.txtMigrationTagID.TabIndex = 1;
            this.txtMigrationTagID.TextChanged += new System.EventHandler(this.txtMigrationTagID_TextChanged);
            this.txtMigrationTagID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMigrationTagID_KeyPress);
            // 
            // lblMigrationTagID
            // 
            this.lblMigrationTagID.AutoSize = true;
            this.lblMigrationTagID.Location = new System.Drawing.Point(25, 36);
            this.lblMigrationTagID.Name = "lblMigrationTagID";
            this.lblMigrationTagID.Size = new System.Drawing.Size(81, 13);
            this.lblMigrationTagID.TabIndex = 2;
            this.lblMigrationTagID.Text = "Butterfly Tag ID";
            // 
            // frmMigration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelMigration;
            this.ClientSize = new System.Drawing.Size(591, 413);
            this.Controls.Add(this.lblMigrationTagID);
            this.Controls.Add(this.txtMigrationTagID);
            this.Controls.Add(this.btnCancelMigration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMigration";
            this.Text = "Migration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelMigration;
        private System.Windows.Forms.TextBox txtMigrationTagID;
        private System.Windows.Forms.Label lblMigrationTagID;
    }
}