namespace LibraryApp
{
    partial class Category
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
            this.cat_id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.CId = new System.Windows.Forms.TextBox();
            this.CName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cat_id
            // 
            this.cat_id.AutoSize = true;
            this.cat_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_id.Location = new System.Drawing.Point(13, 46);
            this.cat_id.Name = "cat_id";
            this.cat_id.Size = new System.Drawing.Size(90, 16);
            this.cat_id.TabIndex = 0;
            this.cat_id.Text = "category_Id";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(16, 89);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(78, 16);
            this.name.TabIndex = 1;
            this.name.Text = "cat_Name";
            // 
            // CId
            // 
            this.CId.Location = new System.Drawing.Point(120, 46);
            this.CId.Name = "CId";
            this.CId.Size = new System.Drawing.Size(134, 20);
            this.CId.TabIndex = 2;
            // 
            // CName
            // 
            this.CName.Location = new System.Drawing.Point(120, 89);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(134, 20);
            this.CName.TabIndex = 3;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.CName);
            this.Controls.Add(this.CId);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cat_id);
            this.Name = "Category";
            this.Text = "Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cat_id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox CId;
        private System.Windows.Forms.TextBox CName;
    }
}