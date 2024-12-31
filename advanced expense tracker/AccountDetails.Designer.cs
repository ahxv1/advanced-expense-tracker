namespace advanced_expense_tracker
{
    partial class AccountDetails
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
            BackToHP = new Button();
            AccountName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // BackToHP
            // 
            BackToHP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BackToHP.Location = new Point(312, 389);
            BackToHP.Name = "BackToHP";
            BackToHP.Size = new Size(140, 57);
            BackToHP.TabIndex = 0;
            BackToHP.Text = "Back To Home Page";
            BackToHP.UseVisualStyleBackColor = true;
            BackToHP.Click += BackToHP_Click;
            // 
            // AccountName
            // 
            AccountName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AccountName.AutoSize = true;
            AccountName.Font = new Font("Segoe UI", 12F);
            AccountName.Location = new Point(35, 39);
            AccountName.Name = "AccountName";
            AccountName.Size = new Size(150, 28);
            AccountName.TabIndex = 1;
            AccountName.Text = "Account Name :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(35, 205);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 2;
            label1.Text = "Account Surname :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(406, 39);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 3;
            label2.Text = "Account Email :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(406, 205);
            label3.Name = "label3";
            label3.Size = new Size(185, 28);
            label3.TabIndex = 4;
            label3.Text = "Account Username :";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(216, 205);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 6;
            label5.Text = "label5";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(557, 39);
            label6.Name = "label6";
            label6.Size = new Size(65, 28);
            label6.TabIndex = 7;
            label6.Text = "label6";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(597, 205);
            label7.Name = "label7";
            label7.Size = new Size(65, 28);
            label7.TabIndex = 8;
            label7.Text = "label7";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(191, 39);
            label8.Name = "label8";
            label8.Size = new Size(65, 28);
            label8.TabIndex = 9;
            label8.Text = "label8";
            label8.Click += label8_Click_1;
            // 
            // AccountDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 458);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AccountName);
            Controls.Add(BackToHP);
            Name = "AccountDetails";
            Text = "AccountDetails";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackToHP;
        private Label AccountName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}