namespace LibraryApp
{
    partial class MemberRegister
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
            this.Reg = new System.Windows.Forms.Label();
            this.MemberReg = new System.Windows.Forms.Label();
            this.dateReg = new System.Windows.Forms.Label();
            this.deposit = new System.Windows.Forms.Label();
            this.MID = new System.Windows.Forms.TextBox();
            this.Dep = new System.Windows.Forms.TextBox();
            this.regdate = new System.Windows.Forms.DateTimePicker();
            this.submit = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reg
            // 
            this.Reg.AutoSize = true;
            this.Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reg.Location = new System.Drawing.Point(98, 13);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(87, 24);
            this.Reg.TabIndex = 0;
            this.Reg.Text = "Register";
            // 
            // MemberReg
            // 
            this.MemberReg.AutoSize = true;
            this.MemberReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberReg.Location = new System.Drawing.Point(13, 80);
            this.MemberReg.Name = "MemberReg";
            this.MemberReg.Size = new System.Drawing.Size(87, 16);
            this.MemberReg.TabIndex = 1;
            this.MemberReg.Text = "Member_ID";
            // 
            // dateReg
            // 
            this.dateReg.AutoSize = true;
            this.dateReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReg.Location = new System.Drawing.Point(13, 122);
            this.dateReg.Name = "dateReg";
            this.dateReg.Size = new System.Drawing.Size(115, 16);
            this.dateReg.TabIndex = 2;
            this.dateReg.Text = "DateOfRegister";
            // 
            // deposit
            // 
            this.deposit.AutoSize = true;
            this.deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.Location = new System.Drawing.Point(16, 156);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(62, 16);
            this.deposit.TabIndex = 3;
            this.deposit.Text = "Deposit";
            // 
            // MID
            // 
            this.MID.Location = new System.Drawing.Point(140, 80);
            this.MID.Name = "MID";
            this.MID.Size = new System.Drawing.Size(132, 20);
            this.MID.TabIndex = 4;
            // 
            // Dep
            // 
            this.Dep.Location = new System.Drawing.Point(140, 151);
            this.Dep.Name = "Dep";
            this.Dep.Size = new System.Drawing.Size(132, 20);
            this.Dep.TabIndex = 5;
            // 
            // regdate
            // 
            this.regdate.Location = new System.Drawing.Point(140, 117);
            this.regdate.Name = "regdate";
            this.regdate.Size = new System.Drawing.Size(132, 20);
            this.regdate.TabIndex = 6;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(140, 191);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 7;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(233, 190);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 8;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // MemberRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 262);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.regdate);
            this.Controls.Add(this.Dep);
            this.Controls.Add(this.MID);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.dateReg);
            this.Controls.Add(this.MemberReg);
            this.Controls.Add(this.Reg);
            this.Name = "MemberRegister";
            this.Text = "MemberRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reg;
        private System.Windows.Forms.Label MemberReg;
        private System.Windows.Forms.Label dateReg;
        private System.Windows.Forms.Label deposit;
        private System.Windows.Forms.TextBox MID;
        private System.Windows.Forms.TextBox Dep;
        private System.Windows.Forms.DateTimePicker regdate;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button exit;
    }
}