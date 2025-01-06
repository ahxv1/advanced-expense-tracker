namespace advanced_expense_tracker
{
    partial class Form2
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
            Logout_button = new Button();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // AddRemoveButton
            // 
            AddRemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddRemoveButton.FlatAppearance.BorderColor = SystemColors.WindowText;
            AddRemoveButton.FlatAppearance.BorderSize = 0;
            AddRemoveButton.Location = new Point(35, 12);
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(654, 392);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(575, 395);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 9;
            label1.Text = "Currency : ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(Logout_button);
            Controls.Add(Account_button);
            Controls.Add(AddRemoveButton);
            Name = "Form2";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddRemoveButton;
        private Button Account_button;
        private Button Logout_button;
        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
    }
}