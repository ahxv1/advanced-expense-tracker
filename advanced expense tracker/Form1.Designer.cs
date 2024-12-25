namespace advanced_expense_tracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox7 = new TextBox();
            email_label = new Label();
            password_label = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            surname_label = new Label();
            name_label = new Label();
            button6 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            username_label = new Label();
            button8 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(154, 183);
            button1.Name = "button1";
            button1.Size = new Size(103, 44);
            button1.TabIndex = 0;
            button1.Text = "Loh In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 110);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(171, 27);
            textBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(43, 228);
            button2.Name = "button2";
            button2.Size = new Size(81, 66);
            button2.TabIndex = 3;
            button2.Text = "Delet the Text";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 49);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 4;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 117);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "password";
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(195, 64);
            button4.TabIndex = 7;
            button4.Text = "Login Page";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(213, 12);
            button5.Name = "button5";
            button5.Size = new Size(195, 64);
            button5.TabIndex = 8;
            button5.Text = "Registration Page";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(12, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 366);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(email_label);
            panel2.Controls.Add(password_label);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(surname_label);
            panel2.Controls.Add(name_label);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(username_label);
            panel2.Controls.Add(button8);
            panel2.Location = new Point(12, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 366);
            panel2.TabIndex = 10;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(148, 231);
            textBox7.Name = "textBox7";
            textBox7.PasswordChar = '*';
            textBox7.Size = new Size(171, 27);
            textBox7.TabIndex = 11;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Location = new Point(64, 139);
            email_label.Name = "email_label";
            email_label.Size = new Size(46, 20);
            email_label.TabIndex = 12;
            email_label.Text = "Email";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(61, 238);
            password_label.Name = "password_label";
            password_label.Size = new Size(72, 20);
            password_label.TabIndex = 9;
            password_label.Text = "password";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(148, 139);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(171, 27);
            textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(148, 182);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(171, 27);
            textBox6.TabIndex = 8;
            // 
            // surname_label
            // 
            surname_label.AutoSize = true;
            surname_label.Location = new Point(61, 84);
            surname_label.Name = "surname_label";
            surname_label.Size = new Size(67, 20);
            surname_label.TabIndex = 10;
            surname_label.Text = "Surname";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(61, 39);
            name_label.Name = "name_label";
            name_label.Size = new Size(49, 20);
            name_label.TabIndex = 4;
            name_label.Text = "Name";
            // 
            // button6
            // 
            button6.Location = new Point(61, 278);
            button6.Name = "button6";
            button6.Size = new Size(103, 44);
            button6.TabIndex = 0;
            button6.Text = "Sign up";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(148, 39);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 27);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(145, 84);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 27);
            textBox4.TabIndex = 2;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Location = new Point(61, 182);
            username_label.Name = "username_label";
            username_label.Size = new Size(75, 20);
            username_label.TabIndex = 5;
            username_label.Text = "Username";
            // 
            // button8
            // 
            button8.Location = new Point(263, 293);
            button8.Name = "button8";
            button8.Size = new Size(112, 61);
            button8.TabIndex = 3;
            button8.Text = "Delete the Text";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 478);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button4);
            Name = "Form1";
            Text = "Login page";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button4;
        private Button button5;
        private Panel panel1;
        private Panel panel2;
        private Label password_label;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label surname_label;
        private Label name_label;
        private Button button6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label username_label;
        private Button button8;
        private TextBox textBox7;
        private Label email_label;
    }
}
