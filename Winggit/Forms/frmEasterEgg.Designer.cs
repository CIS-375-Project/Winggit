namespace Winggit.Forms
{
    partial class frmEasterEgg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEasterEgg));
            this.btnItDepends = new System.Windows.Forms.Button();
            this.picPCFire = new System.Windows.Forms.PictureBox();
            this.lblAcceptanceLevel = new System.Windows.Forms.Label();
            this.btnTerrible = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPCFire)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItDepends
            // 
            this.btnItDepends.Location = new System.Drawing.Point(258, 278);
            this.btnItDepends.Name = "btnItDepends";
            this.btnItDepends.Size = new System.Drawing.Size(75, 23);
            this.btnItDepends.TabIndex = 0;
            this.btnItDepends.Text = "It Depends";
            this.btnItDepends.UseVisualStyleBackColor = true;
            this.btnItDepends.Click += new System.EventHandler(this.btnItDepends_Click);
            // 
            // picPCFire
            // 
            this.picPCFire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPCFire.Image = ((System.Drawing.Image)(resources.GetObject("picPCFire.Image")));
            this.picPCFire.Location = new System.Drawing.Point(12, 12);
            this.picPCFire.Name = "picPCFire";
            this.picPCFire.Size = new System.Drawing.Size(322, 236);
            this.picPCFire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPCFire.TabIndex = 1;
            this.picPCFire.TabStop = false;
            // 
            // lblAcceptanceLevel
            // 
            this.lblAcceptanceLevel.AutoSize = true;
            this.lblAcceptanceLevel.Location = new System.Drawing.Point(121, 283);
            this.lblAcceptanceLevel.Name = "lblAcceptanceLevel";
            this.lblAcceptanceLevel.Size = new System.Drawing.Size(102, 13);
            this.lblAcceptanceLevel.TabIndex = 2;
            this.lblAcceptanceLevel.Text = "Acceptability Level?";
            // 
            // btnTerrible
            // 
            this.btnTerrible.Location = new System.Drawing.Point(12, 278);
            this.btnTerrible.Name = "btnTerrible";
            this.btnTerrible.Size = new System.Drawing.Size(75, 23);
            this.btnTerrible.TabIndex = 3;
            this.btnTerrible.Text = "Terrible!";
            this.btnTerrible.UseVisualStyleBackColor = true;
            this.btnTerrible.Click += new System.EventHandler(this.btnTerrible_Click);
            // 
            // frmEasterEgg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnItDepends;
            this.ClientSize = new System.Drawing.Size(345, 313);
            this.Controls.Add(this.btnTerrible);
            this.Controls.Add(this.lblAcceptanceLevel);
            this.Controls.Add(this.picPCFire);
            this.Controls.Add(this.btnItDepends);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEasterEgg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smoke Test";
            ((System.ComponentModel.ISupportInitialize)(this.picPCFire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnItDepends;
        private System.Windows.Forms.PictureBox picPCFire;
        private System.Windows.Forms.Label lblAcceptanceLevel;
        private System.Windows.Forms.Button btnTerrible;
    }
}