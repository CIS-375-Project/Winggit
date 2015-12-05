namespace Winggit
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
            this.btnOpenMessaging = new System.Windows.Forms.Button();
            this.btnOpenReports = new System.Windows.Forms.Button();
            this.btnEasterEgg = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenMessaging
            // 
            this.btnOpenMessaging.Location = new System.Drawing.Point(345, 282);
            this.btnOpenMessaging.Name = "btnOpenMessaging";
            this.btnOpenMessaging.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMessaging.TabIndex = 0;
            this.btnOpenMessaging.Text = "Messaging";
            this.btnOpenMessaging.UseVisualStyleBackColor = true;
            // 
            // btnOpenReports
            // 
            this.btnOpenReports.Location = new System.Drawing.Point(435, 282);
            this.btnOpenReports.Name = "btnOpenReports";
            this.btnOpenReports.Size = new System.Drawing.Size(75, 23);
            this.btnOpenReports.TabIndex = 1;
            this.btnOpenReports.Text = "Reports";
            this.btnOpenReports.UseVisualStyleBackColor = true;
            // 
            // btnEasterEgg
            // 
            this.btnEasterEgg.Location = new System.Drawing.Point(527, 282);
            this.btnEasterEgg.Name = "btnEasterEgg";
            this.btnEasterEgg.Size = new System.Drawing.Size(75, 23);
            this.btnEasterEgg.TabIndex = 2;
            this.btnEasterEgg.Text = "Winggit!";
            this.btnEasterEgg.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(622, 282);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 463);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEasterEgg);
            this.Controls.Add(this.btnOpenReports);
            this.Controls.Add(this.btnOpenMessaging);
            this.Name = "frmMain";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenMessaging;
        private System.Windows.Forms.Button btnOpenReports;
        private System.Windows.Forms.Button btnEasterEgg;
        private System.Windows.Forms.Button btnSearch;
    }
}