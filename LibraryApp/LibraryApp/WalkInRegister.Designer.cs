namespace LibraryApp
{
    partial class WalkInRegister
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
            this.VID = new System.Windows.Forms.Label();
            this.VName = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.Label();
            this.Idv = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.VAddress = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VID
            // 
            this.VID.AutoSize = true;
            this.VID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VID.Location = new System.Drawing.Point(13, 59);
            this.VID.Name = "VID";
            this.VID.Size = new System.Drawing.Size(75, 16);
            this.VID.TabIndex = 0;
            this.VID.Text = "Visiter_ID";
            // 
            // VName
            // 
            this.VName.AutoSize = true;
            this.VName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VName.Location = new System.Drawing.Point(16, 98);
            this.VName.Name = "VName";
            this.VName.Size = new System.Drawing.Size(93, 16);
            this.VName.TabIndex = 1;
            this.VName.Text = "VisitorName";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(16, 132);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(66, 16);
            this.address.TabIndex = 2;
            this.address.Text = "Address";
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(16, 168);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(60, 16);
            this.Contact.TabIndex = 3;
            this.Contact.Text = "Contact";
            // 
            // Idv
            // 
            this.Idv.Location = new System.Drawing.Point(139, 59);
            this.Idv.Name = "Idv";
            this.Idv.Size = new System.Drawing.Size(118, 20);
            this.Idv.TabIndex = 4;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(139, 98);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(118, 20);
            this.name.TabIndex = 5;
            // 
            // VAddress
            // 
            this.VAddress.Location = new System.Drawing.Point(139, 132);
            this.VAddress.Name = "VAddress";
            this.VAddress.Size = new System.Drawing.Size(118, 20);
            this.VAddress.TabIndex = 6;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(139, 168);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(118, 20);
            this.number.TabIndex = 7;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(139, 215);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(234, 215);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 9;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // WalkInRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 262);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.number);
            this.Controls.Add(this.VAddress);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Idv);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.address);
            this.Controls.Add(this.VName);
            this.Controls.Add(this.VID);
            this.Name = "WalkInRegister";
            this.Text = "WalkInRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VID;
        private System.Windows.Forms.Label VName;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.TextBox Idv;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox VAddress;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button exit;
    }
}