namespace LibraryApp
{
    partial class TransactionDetail
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
            this.ReturnDate = new System.Windows.Forms.Label();
            this.ActualDate = new System.Windows.Forms.Label();
            this.DelayDate = new System.Windows.Forms.Label();
            this.Penalty = new System.Windows.Forms.Label();
            this.DOR = new System.Windows.Forms.DateTimePicker();
            this.DOA = new System.Windows.Forms.DateTimePicker();
            this.DelayDays = new System.Windows.Forms.TextBox();
            this.PFees = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.BIssue = new System.Windows.Forms.Label();
            this.BKIssue = new System.Windows.Forms.DateTimePicker();
            this.BIssueId = new System.Windows.Forms.Label();
            this.BK_Issue_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ReturnDate
            // 
            this.ReturnDate.AutoSize = true;
            this.ReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDate.Location = new System.Drawing.Point(12, 77);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(101, 16);
            this.ReturnDate.TabIndex = 0;
            this.ReturnDate.Text = "DateOfReturn";
            // 
            // ActualDate
            // 
            this.ActualDate.AutoSize = true;
            this.ActualDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualDate.Location = new System.Drawing.Point(12, 112);
            this.ActualDate.Name = "ActualDate";
            this.ActualDate.Size = new System.Drawing.Size(84, 16);
            this.ActualDate.TabIndex = 1;
            this.ActualDate.Text = "ActualDate";
            // 
            // DelayDate
            // 
            this.DelayDate.AutoSize = true;
            this.DelayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelayDate.Location = new System.Drawing.Point(13, 149);
            this.DelayDate.Name = "DelayDate";
            this.DelayDate.Size = new System.Drawing.Size(131, 16);
            this.DelayDate.TabIndex = 2;
            this.DelayDate.Text = "No. of Delay Date";
            // 
            // Penalty
            // 
            this.Penalty.AutoSize = true;
            this.Penalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Penalty.Location = new System.Drawing.Point(12, 187);
            this.Penalty.Name = "Penalty";
            this.Penalty.Size = new System.Drawing.Size(138, 16);
            this.Penalty.TabIndex = 3;
            this.Penalty.Text = "ApplicationPenalty";
            // 
            // DOR
            // 
            this.DOR.Location = new System.Drawing.Point(193, 73);
            this.DOR.Name = "DOR";
            this.DOR.Size = new System.Drawing.Size(200, 20);
            this.DOR.TabIndex = 4;
            // 
            // DOA
            // 
            this.DOA.Location = new System.Drawing.Point(193, 108);
            this.DOA.Name = "DOA";
            this.DOA.Size = new System.Drawing.Size(200, 20);
            this.DOA.TabIndex = 5;
            // 
            // DelayDays
            // 
            this.DelayDays.Location = new System.Drawing.Point(193, 145);
            this.DelayDays.Name = "DelayDays";
            this.DelayDays.Size = new System.Drawing.Size(200, 20);
            this.DelayDays.TabIndex = 6;
            // 
            // PFees
            // 
            this.PFees.Location = new System.Drawing.Point(193, 183);
            this.PFees.Name = "PFees";
            this.PFees.Size = new System.Drawing.Size(200, 20);
            this.PFees.TabIndex = 7;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(193, 227);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(306, 227);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 9;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // BIssue
            // 
            this.BIssue.AutoSize = true;
            this.BIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIssue.Location = new System.Drawing.Point(13, 45);
            this.BIssue.Name = "BIssue";
            this.BIssue.Size = new System.Drawing.Size(81, 16);
            this.BIssue.TabIndex = 10;
            this.BIssue.Text = "BookIssue";
            // 
            // BKIssue
            // 
            this.BKIssue.Location = new System.Drawing.Point(193, 41);
            this.BKIssue.Name = "BKIssue";
            this.BKIssue.Size = new System.Drawing.Size(200, 20);
            this.BKIssue.TabIndex = 11;
            // 
            // BIssueId
            // 
            this.BIssueId.AutoSize = true;
            this.BIssueId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIssueId.Location = new System.Drawing.Point(16, 13);
            this.BIssueId.Name = "BIssueId";
            this.BIssueId.Size = new System.Drawing.Size(93, 16);
            this.BIssueId.TabIndex = 12;
            this.BIssueId.Text = "BK_Issue_Id";
            // 
            // BK_Issue_ID
            // 
            this.BK_Issue_ID.Location = new System.Drawing.Point(193, 8);
            this.BK_Issue_ID.Name = "BK_Issue_ID";
            this.BK_Issue_ID.Size = new System.Drawing.Size(200, 20);
            this.BK_Issue_ID.TabIndex = 13;
            // 
            // TransactionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 262);
            this.Controls.Add(this.BK_Issue_ID);
            this.Controls.Add(this.BIssueId);
            this.Controls.Add(this.BKIssue);
            this.Controls.Add(this.BIssue);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.PFees);
            this.Controls.Add(this.DelayDays);
            this.Controls.Add(this.DOA);
            this.Controls.Add(this.DOR);
            this.Controls.Add(this.Penalty);
            this.Controls.Add(this.DelayDate);
            this.Controls.Add(this.ActualDate);
            this.Controls.Add(this.ReturnDate);
            this.Name = "TransactionDetail";
            this.Text = "TransactionDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReturnDate;
        private System.Windows.Forms.Label ActualDate;
        private System.Windows.Forms.Label DelayDate;
        private System.Windows.Forms.Label Penalty;
        private System.Windows.Forms.DateTimePicker DOR;
        private System.Windows.Forms.DateTimePicker DOA;
        private System.Windows.Forms.TextBox DelayDays;
        private System.Windows.Forms.TextBox PFees;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label BIssue;
        private System.Windows.Forms.DateTimePicker BKIssue;
        private System.Windows.Forms.Label BIssueId;
        private System.Windows.Forms.TextBox BK_Issue_ID;
    }
}