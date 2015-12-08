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
            this.btnSeeMigration = new System.Windows.Forms.Button();
            this.dgdMigrationTable = new System.Windows.Forms.DataGridView();
            this.lblMigrationTable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgdMigrationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelMigration
            // 
            this.btnCancelMigration.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelMigration.Location = new System.Drawing.Point(504, 184);
            this.btnCancelMigration.Name = "btnCancelMigration";
            this.btnCancelMigration.Size = new System.Drawing.Size(75, 23);
            this.btnCancelMigration.TabIndex = 0;
            this.btnCancelMigration.Text = "Cancel";
            this.btnCancelMigration.UseVisualStyleBackColor = true;
            this.btnCancelMigration.Click += new System.EventHandler(this.btnCancelMigration_Click);
            // 
            // txtMigrationTagID
            // 
            this.txtMigrationTagID.Location = new System.Drawing.Point(15, 28);
            this.txtMigrationTagID.Name = "txtMigrationTagID";
            this.txtMigrationTagID.ShortcutsEnabled = false;
            this.txtMigrationTagID.Size = new System.Drawing.Size(120, 20);
            this.txtMigrationTagID.TabIndex = 1;
            this.txtMigrationTagID.TextChanged += new System.EventHandler(this.txtMigrationTagID_TextChanged);
            this.txtMigrationTagID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMigrationTagID_KeyPress);
            // 
            // lblMigrationTagID
            // 
            this.lblMigrationTagID.AutoSize = true;
            this.lblMigrationTagID.Location = new System.Drawing.Point(12, 9);
            this.lblMigrationTagID.Name = "lblMigrationTagID";
            this.lblMigrationTagID.Size = new System.Drawing.Size(81, 13);
            this.lblMigrationTagID.TabIndex = 2;
            this.lblMigrationTagID.Text = "Butterfly Tag ID";
            // 
            // btnSeeMigration
            // 
            this.btnSeeMigration.Enabled = false;
            this.btnSeeMigration.Location = new System.Drawing.Point(15, 184);
            this.btnSeeMigration.Name = "btnSeeMigration";
            this.btnSeeMigration.Size = new System.Drawing.Size(94, 23);
            this.btnSeeMigration.TabIndex = 3;
            this.btnSeeMigration.Text = "See Migration";
            this.btnSeeMigration.UseVisualStyleBackColor = true;
            this.btnSeeMigration.Click += new System.EventHandler(this.btnSeeMigration_Click);
            // 
            // dgdMigrationTable
            // 
            this.dgdMigrationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdMigrationTable.Location = new System.Drawing.Point(339, 28);
            this.dgdMigrationTable.Name = "dgdMigrationTable";
            this.dgdMigrationTable.Size = new System.Drawing.Size(240, 150);
            this.dgdMigrationTable.TabIndex = 4;
            // 
            // lblMigrationTable
            // 
            this.lblMigrationTable.AutoSize = true;
            this.lblMigrationTable.Location = new System.Drawing.Point(336, 9);
            this.lblMigrationTable.Name = "lblMigrationTable";
            this.lblMigrationTable.Size = new System.Drawing.Size(50, 13);
            this.lblMigrationTable.TabIndex = 5;
            this.lblMigrationTable.Text = "Sightings";
            // 
            // frmMigration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelMigration;
            this.ClientSize = new System.Drawing.Size(591, 220);
            this.Controls.Add(this.lblMigrationTable);
            this.Controls.Add(this.dgdMigrationTable);
            this.Controls.Add(this.btnSeeMigration);
            this.Controls.Add(this.lblMigrationTagID);
            this.Controls.Add(this.txtMigrationTagID);
            this.Controls.Add(this.btnCancelMigration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMigration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Migration";
            ((System.ComponentModel.ISupportInitialize)(this.dgdMigrationTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelMigration;
        private System.Windows.Forms.TextBox txtMigrationTagID;
        private System.Windows.Forms.Label lblMigrationTagID;
        private System.Windows.Forms.Button btnSeeMigration;
        private System.Windows.Forms.DataGridView dgdMigrationTable;
        private System.Windows.Forms.Label lblMigrationTable;
    }
}