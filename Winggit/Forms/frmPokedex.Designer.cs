namespace Winggit.Forms
{
    partial class frmPokedex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPokedex));
            this.btnCancelPokedex = new System.Windows.Forms.Button();
            this.dgdTaggerRankings = new System.Windows.Forms.DataGridView();
            this.btnRefreshRankings = new System.Windows.Forms.Button();
            this.lblTaggerRankings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgdTaggerRankings)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelPokedex
            // 
            this.btnCancelPokedex.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelPokedex.Location = new System.Drawing.Point(284, 268);
            this.btnCancelPokedex.Name = "btnCancelPokedex";
            this.btnCancelPokedex.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPokedex.TabIndex = 0;
            this.btnCancelPokedex.Text = "Cancel";
            this.btnCancelPokedex.UseVisualStyleBackColor = true;
            this.btnCancelPokedex.Click += new System.EventHandler(this.btnCancelPokedex_Click);
            // 
            // dgdTaggerRankings
            // 
            this.dgdTaggerRankings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdTaggerRankings.Location = new System.Drawing.Point(12, 25);
            this.dgdTaggerRankings.Name = "dgdTaggerRankings";
            this.dgdTaggerRankings.Size = new System.Drawing.Size(347, 237);
            this.dgdTaggerRankings.TabIndex = 1;
            // 
            // btnRefreshRankings
            // 
            this.btnRefreshRankings.Location = new System.Drawing.Point(12, 268);
            this.btnRefreshRankings.Name = "btnRefreshRankings";
            this.btnRefreshRankings.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshRankings.TabIndex = 2;
            this.btnRefreshRankings.Text = "Refresh";
            this.btnRefreshRankings.UseVisualStyleBackColor = true;
            this.btnRefreshRankings.Click += new System.EventHandler(this.btnRefreshRankings_Click);
            // 
            // lblTaggerRankings
            // 
            this.lblTaggerRankings.AutoSize = true;
            this.lblTaggerRankings.Location = new System.Drawing.Point(12, 9);
            this.lblTaggerRankings.Name = "lblTaggerRankings";
            this.lblTaggerRankings.Size = new System.Drawing.Size(89, 13);
            this.lblTaggerRankings.TabIndex = 3;
            this.lblTaggerRankings.Text = "Tagger Rankings";
            // 
            // frmPokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelPokedex;
            this.ClientSize = new System.Drawing.Size(371, 303);
            this.Controls.Add(this.lblTaggerRankings);
            this.Controls.Add(this.btnRefreshRankings);
            this.Controls.Add(this.dgdTaggerRankings);
            this.Controls.Add(this.btnCancelPokedex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPokedex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokédex";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPokedex_FormClosing);
            this.Load += new System.EventHandler(this.frmPokedex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdTaggerRankings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelPokedex;
        private System.Windows.Forms.DataGridView dgdTaggerRankings;
        private System.Windows.Forms.Button btnRefreshRankings;
        private System.Windows.Forms.Label lblTaggerRankings;
    }
}