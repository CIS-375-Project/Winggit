namespace Winggit.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnOpenMessaging = new System.Windows.Forms.Button();
            this.btnOpenReports = new System.Windows.Forms.Button();
            this.btnEasterEgg = new System.Windows.Forms.Button();
            this.btnOpenSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWorkLife = new System.Windows.Forms.Label();
            this.lblSocialLife = new System.Windows.Forms.Label();
            this.btnOpenPokedex = new System.Windows.Forms.Button();
            this.btnOpenSightings = new System.Windows.Forms.Button();
            this.picBee = new System.Windows.Forms.PictureBox();
            this.btnOpenMigration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenMessaging
            // 
            this.btnOpenMessaging.Location = new System.Drawing.Point(279, 50);
            this.btnOpenMessaging.Name = "btnOpenMessaging";
            this.btnOpenMessaging.Size = new System.Drawing.Size(105, 23);
            this.btnOpenMessaging.TabIndex = 0;
            this.btnOpenMessaging.Text = "Messaging Client";
            this.btnOpenMessaging.UseVisualStyleBackColor = true;
            this.btnOpenMessaging.Click += new System.EventHandler(this.btnOpenMessaging_Click);
            // 
            // btnOpenReports
            // 
            this.btnOpenReports.Location = new System.Drawing.Point(12, 50);
            this.btnOpenReports.Name = "btnOpenReports";
            this.btnOpenReports.Size = new System.Drawing.Size(105, 23);
            this.btnOpenReports.TabIndex = 1;
            this.btnOpenReports.Text = "Reports";
            this.btnOpenReports.UseVisualStyleBackColor = true;
            this.btnOpenReports.Click += new System.EventHandler(this.btnOpenReports_Click);
            // 
            // btnEasterEgg
            // 
            this.btnEasterEgg.Location = new System.Drawing.Point(116, 145);
            this.btnEasterEgg.Name = "btnEasterEgg";
            this.btnEasterEgg.Size = new System.Drawing.Size(75, 23);
            this.btnEasterEgg.TabIndex = 2;
            this.btnEasterEgg.Text = "Winggit!";
            this.btnEasterEgg.UseVisualStyleBackColor = true;
            // 
            // btnOpenSearch
            // 
            this.btnOpenSearch.Location = new System.Drawing.Point(279, 21);
            this.btnOpenSearch.Name = "btnOpenSearch";
            this.btnOpenSearch.Size = new System.Drawing.Size(105, 23);
            this.btnOpenSearch.TabIndex = 3;
            this.btnOpenSearch.Text = "Tagger Seach";
            this.btnOpenSearch.UseVisualStyleBackColor = true;
            this.btnOpenSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 146);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWorkLife
            // 
            this.lblWorkLife.AutoSize = true;
            this.lblWorkLife.Location = new System.Drawing.Point(34, 5);
            this.lblWorkLife.Name = "lblWorkLife";
            this.lblWorkLife.Size = new System.Drawing.Size(53, 13);
            this.lblWorkLife.TabIndex = 5;
            this.lblWorkLife.Text = "Work Life";
            // 
            // lblSocialLife
            // 
            this.lblSocialLife.AutoSize = true;
            this.lblSocialLife.Location = new System.Drawing.Point(301, 5);
            this.lblSocialLife.Name = "lblSocialLife";
            this.lblSocialLife.Size = new System.Drawing.Size(56, 13);
            this.lblSocialLife.TabIndex = 5;
            this.lblSocialLife.Text = "Social Life";
            // 
            // btnOpenPokedex
            // 
            this.btnOpenPokedex.Location = new System.Drawing.Point(279, 79);
            this.btnOpenPokedex.Name = "btnOpenPokedex";
            this.btnOpenPokedex.Size = new System.Drawing.Size(105, 23);
            this.btnOpenPokedex.TabIndex = 6;
            this.btnOpenPokedex.Text = "Pokédex";
            this.btnOpenPokedex.UseVisualStyleBackColor = true;
            // 
            // btnOpenSightings
            // 
            this.btnOpenSightings.Location = new System.Drawing.Point(12, 21);
            this.btnOpenSightings.Name = "btnOpenSightings";
            this.btnOpenSightings.Size = new System.Drawing.Size(105, 23);
            this.btnOpenSightings.TabIndex = 7;
            this.btnOpenSightings.Text = "Tags/Sightings";
            this.btnOpenSightings.UseVisualStyleBackColor = true;
            // 
            // picBee
            // 
            this.picBee.Location = new System.Drawing.Point(0, 0);
            this.picBee.Name = "picBee";
            this.picBee.Size = new System.Drawing.Size(100, 50);
            this.picBee.TabIndex = 0;
            this.picBee.TabStop = false;
            // 
            // btnOpenMigration
            // 
            this.btnOpenMigration.Location = new System.Drawing.Point(12, 78);
            this.btnOpenMigration.Name = "btnOpenMigration";
            this.btnOpenMigration.Size = new System.Drawing.Size(105, 23);
            this.btnOpenMigration.TabIndex = 8;
            this.btnOpenMigration.Text = "Migration";
            this.btnOpenMigration.UseVisualStyleBackColor = true;
            this.btnOpenMigration.Click += new System.EventHandler(this.btnOpenMigration_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 207);
            this.Controls.Add(this.btnOpenMigration);
            this.Controls.Add(this.btnOpenSightings);
            this.Controls.Add(this.btnOpenPokedex);
            this.Controls.Add(this.lblSocialLife);
            this.Controls.Add(this.lblWorkLife);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenSearch);
            this.Controls.Add(this.btnEasterEgg);
            this.Controls.Add(this.btnOpenReports);
            this.Controls.Add(this.btnOpenMessaging);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picBee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenMessaging;
        private System.Windows.Forms.Button btnOpenReports;
        private System.Windows.Forms.Button btnEasterEgg;
        private System.Windows.Forms.Button btnOpenSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWorkLife;
        private System.Windows.Forms.Label lblSocialLife;
        private System.Windows.Forms.Button btnOpenPokedex;
        private System.Windows.Forms.Button btnOpenSightings;
        private System.Windows.Forms.PictureBox picBee;
        private System.Windows.Forms.Button btnOpenMigration;
    }
}