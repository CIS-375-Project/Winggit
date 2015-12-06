namespace Winggit
{
    partial class frmTaggerSearch
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
            this.lblTaggerSearchLocation = new System.Windows.Forms.Label();
            this.cmbTaggerSearchLocation = new System.Windows.Forms.ComboBox();
            this.btnCancelTaggerSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTaggerSearchLocation
            // 
            this.lblTaggerSearchLocation.AutoSize = true;
            this.lblTaggerSearchLocation.Location = new System.Drawing.Point(24, 30);
            this.lblTaggerSearchLocation.Name = "lblTaggerSearchLocation";
            this.lblTaggerSearchLocation.Size = new System.Drawing.Size(99, 13);
            this.lblTaggerSearchLocation.TabIndex = 0;
            this.lblTaggerSearchLocation.Text = "Search by Location";
            // 
            // cmbTaggerSearchLocation
            // 
            this.cmbTaggerSearchLocation.FormattingEnabled = true;
            this.cmbTaggerSearchLocation.Location = new System.Drawing.Point(27, 46);
            this.cmbTaggerSearchLocation.Name = "cmbTaggerSearchLocation";
            this.cmbTaggerSearchLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbTaggerSearchLocation.TabIndex = 1;
            // 
            // btnCancelTaggerSearch
            // 
            this.btnCancelTaggerSearch.Location = new System.Drawing.Point(897, 426);
            this.btnCancelTaggerSearch.Name = "btnCancelTaggerSearch";
            this.btnCancelTaggerSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCancelTaggerSearch.TabIndex = 2;
            this.btnCancelTaggerSearch.Text = "Cancel";
            this.btnCancelTaggerSearch.UseVisualStyleBackColor = true;
            this.btnCancelTaggerSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // frmTaggerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnCancelTaggerSearch);
            this.Controls.Add(this.cmbTaggerSearchLocation);
            this.Controls.Add(this.lblTaggerSearchLocation);
            this.Name = "frmTaggerSearch";
            this.Text = "Search for Local Taggers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTaggerSearchLocation;
        private System.Windows.Forms.Label lblTaggerSearchLocation;
        private System.Windows.Forms.Button btnCancelTaggerSearch;
    }
}