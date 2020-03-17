namespace LibrayManagement
{
    partial class LibForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maagazinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mannualsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.textBookToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.booksToolStripMenuItem.Text = "&Books";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textBookToolStripMenuItem1,
            this.maagazinesToolStripMenuItem,
            this.mannualsToolStripMenuItem});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoryToolStripMenuItem.Text = "&Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // textBookToolStripMenuItem
            // 
            this.textBookToolStripMenuItem.Name = "textBookToolStripMenuItem";
            this.textBookToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.textBookToolStripMenuItem.Text = "TextBook";
            // 
            // textBookToolStripMenuItem1
            // 
            this.textBookToolStripMenuItem1.Name = "textBookToolStripMenuItem1";
            this.textBookToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.textBookToolStripMenuItem1.Text = "Science & Technologies";
            // 
            // maagazinesToolStripMenuItem
            // 
            this.maagazinesToolStripMenuItem.Name = "maagazinesToolStripMenuItem";
            this.maagazinesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.maagazinesToolStripMenuItem.Text = "Computer Books";
            // 
            // mannualsToolStripMenuItem
            // 
            this.mannualsToolStripMenuItem.Name = "mannualsToolStripMenuItem";
            this.mannualsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.mannualsToolStripMenuItem.Text = "Finance";
            // 
            // LibForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 322);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LibForm";
            this.Text = "LibraryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maagazinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mannualsToolStripMenuItem;
    }
}

