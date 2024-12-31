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
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // AddRemoveButton
            // 
            AddRemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddRemoveButton.FlatAppearance.BorderColor = SystemColors.WindowText;
            AddRemoveButton.FlatAppearance.BorderSize = 0;
            AddRemoveButton.Location = new Point(45, 12);
            AddRemoveButton.Name = "AddRemoveButton";
            AddRemoveButton.Size = new Size(734, 198);
            AddRemoveButton.TabIndex = 0;
            AddRemoveButton.Text = "Payment Window";
            AddRemoveButton.UseVisualStyleBackColor = true;
            AddRemoveButton.Click += AddRemoveButton_Click_1;
            // 
            // Account_button
            // 
            Account_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Account_button.Location = new Point(145, 391);
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
            Money_HP.Font = new Font("Segoe UI", 10.8F);
            Money_HP.Location = new Point(513, 395);
            Money_HP.Name = "Money_HP";
            Money_HP.Size = new Size(128, 25);
            Money_HP.TabIndex = 2;
            Money_HP.Text = "Currect Money";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(647, 395);
            label1.Name = "label1";
            label1.Size = new Size(16, 25);
            label1.TabIndex = 3;
            label1.Text = ":";
            // 
            // Logout_button
            // 
            Logout_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(669, 395);
            label2.Name = "label2";
            label2.Size = new Size(18, 25);
            label2.TabIndex = 5;
            label2.Text = "0";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(693, 396);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(74, 28);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(299, 391);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Dark";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Home_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBox1);
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
        private ComboBox comboBox1;
        private Button button1;
    }
}