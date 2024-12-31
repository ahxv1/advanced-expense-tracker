namespace advanced_expense_tracker
{
    partial class Home_page
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
            AddRemoveButton = new Button();
            Account_button = new Button();
            Money_HP = new Label();
            label1 = new Label();
            Logout_button = new Button();
            label2 = new Label();
            HistoryButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // AddRemoveButton
            // 
            AddRemoveButton.FlatAppearance.BorderColor = SystemColors.WindowText;
            AddRemoveButton.FlatAppearance.BorderSize = 0;
            AddRemoveButton.Location = new Point(45, 26);
            AddRemoveButton.Name = "AddRemoveButton";
            AddRemoveButton.Size = new Size(154, 57);
            AddRemoveButton.TabIndex = 0;
            AddRemoveButton.Text = "Add/Remove Expense";
            AddRemoveButton.UseVisualStyleBackColor = true;
            AddRemoveButton.Click += AddRemoveButton_Click_1;
            // 
            // Account_button
            // 
            Account_button.Location = new Point(167, 391);
            Account_button.Name = "Account_button";
            Account_button.Size = new Size(148, 29);
            Account_button.TabIndex = 1;
            Account_button.Text = "Account details";
            Account_button.UseVisualStyleBackColor = true;
            Account_button.Click += Account_button_Click_1;
            // 
            // Money_HP
            // 
            Money_HP.AutoSize = true;
            Money_HP.Location = new Point(595, 400);
            Money_HP.Name = "Money_HP";
            Money_HP.Size = new Size(105, 20);
            Money_HP.TabIndex = 2;
            Money_HP.Text = "Currect Money";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(699, 400);
            label1.Name = "label1";
            label1.Size = new Size(12, 20);
            label1.TabIndex = 3;
            label1.Text = ":";
            // 
            // Logout_button
            // 
            Logout_button.Location = new Point(45, 391);
            Logout_button.Name = "Logout_button";
            Logout_button.Size = new Size(94, 29);
            Logout_button.TabIndex = 4;
            Logout_button.Text = "Logout";
            Logout_button.UseVisualStyleBackColor = true;
            Logout_button.Click += Logout_button_Click_1;
            // 
            // label2
            // 
            label2.Location = new Point(717, 400);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 5;
            label2.Text = "0";
            // 
            // HistoryButton
            // 
            HistoryButton.Location = new Point(45, 152);
            HistoryButton.Name = "HistoryButton";
            HistoryButton.Size = new Size(153, 57);
            HistoryButton.TabIndex = 6;
            HistoryButton.Text = "History";
            HistoryButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(45, 89);
            button1.Name = "button1";
            button1.Size = new Size(154, 57);
            button1.TabIndex = 7;
            button1.Text = "Add/Remove Category";
            button1.UseVisualStyleBackColor = true;
            // 
            // Home_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(HistoryButton);
            Controls.Add(label2);
            Controls.Add(Logout_button);
            Controls.Add(label1);
            Controls.Add(Money_HP);
            Controls.Add(Account_button);
            Controls.Add(AddRemoveButton);
            Name = "Home_page";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddRemoveButton;
        private Button Account_button;
        private Label Money_HP;
        private Label label1;
        private Button Logout_button;
        private Label label2;
        private Button HistoryButton;
        private Button button1;
    }
}