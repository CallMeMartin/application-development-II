
namespace NFL.View
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CreateMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateMatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchesDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateMatchToolStripMenuItem,
            this.UpdateMatchesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CreateMatchToolStripMenuItem
            // 
            this.CreateMatchToolStripMenuItem.Name = "CreateMatchToolStripMenuItem";
            this.CreateMatchToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.CreateMatchToolStripMenuItem.Text = "Új Mérkőzés";
            this.CreateMatchToolStripMenuItem.Click += new System.EventHandler(this.createMatch_Click);
            // 
            // UpdateMatchesToolStripMenuItem
            // 
            this.UpdateMatchesToolStripMenuItem.Name = "UpdateMatchesToolStripMenuItem";
            this.UpdateMatchesToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.UpdateMatchesToolStripMenuItem.Text = "Mérkőzés lista frissítése";
            this.UpdateMatchesToolStripMenuItem.Click += new System.EventHandler(this.updateMatches_Click);
            // 
            // matchesDataGridView
            // 
            this.matchesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchesDataGridView.Location = new System.Drawing.Point(12, 27);
            this.matchesDataGridView.Name = "matchesDataGridView";
            this.matchesDataGridView.ReadOnly = true;
            this.matchesDataGridView.RowTemplate.Height = 25;
            this.matchesDataGridView.Size = new System.Drawing.Size(722, 411);
            this.matchesDataGridView.TabIndex = 1;
            this.matchesDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.updateMatchItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.matchesDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "NFL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateMatchesToolStripMenuItem;
        private System.Windows.Forms.DataGridView matchesDataGridView;
    }
}

