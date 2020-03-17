namespace LibraryApp
{
    partial class BookDetail
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
            this.Bid = new System.Windows.Forms.Label();
            this.BTitle = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.bkid = new System.Windows.Forms.TextBox();
            this.bktitle = new System.Windows.Forms.TextBox();
            this.bkauthor = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bid
            // 
            this.Bid.AutoSize = true;
            this.Bid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bid.Location = new System.Drawing.Point(13, 47);
            this.Bid.Name = "Bid";
            this.Bid.Size = new System.Drawing.Size(59, 16);
            this.Bid.TabIndex = 0;
            this.Bid.Text = "BookID";
            // 
            // BTitle
            // 
            this.BTitle.AutoSize = true;
            this.BTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTitle.Location = new System.Drawing.Point(16, 87);
            this.BTitle.Name = "BTitle";
            this.BTitle.Size = new System.Drawing.Size(83, 16);
            this.BTitle.TabIndex = 1;
            this.BTitle.Text = "Book_Title";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.Location = new System.Drawing.Point(16, 130);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(52, 16);
            this.author.TabIndex = 2;
            this.author.Text = "Author";
            // 
            // bkid
            // 
            this.bkid.Location = new System.Drawing.Point(120, 47);
            this.bkid.Name = "bkid";
            this.bkid.Size = new System.Drawing.Size(136, 20);
            this.bkid.TabIndex = 3;
            // 
            // bktitle
            // 
            this.bktitle.Location = new System.Drawing.Point(120, 87);
            this.bktitle.Name = "bktitle";
            this.bktitle.Size = new System.Drawing.Size(136, 20);
            this.bktitle.TabIndex = 4;
            // 
            // bkauthor
            // 
            this.bkauthor.Location = new System.Drawing.Point(120, 125);
            this.bkauthor.Name = "bkauthor";
            this.bkauthor.Size = new System.Drawing.Size(136, 20);
            this.bkauthor.TabIndex = 5;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(120, 176);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "submit";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(217, 175);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // BookDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 262);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.bkauthor);
            this.Controls.Add(this.bktitle);
            this.Controls.Add(this.bkid);
            this.Controls.Add(this.author);
            this.Controls.Add(this.BTitle);
            this.Controls.Add(this.Bid);
            this.Name = "BookDetail";
            this.Text = "BookDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bid;
        private System.Windows.Forms.Label BTitle;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.TextBox bkid;
        private System.Windows.Forms.TextBox bktitle;
        private System.Windows.Forms.TextBox bkauthor;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button exit;
    }
}