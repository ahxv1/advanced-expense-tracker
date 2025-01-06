

namespace advanced_expense_tracker
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textAmount = new TextBox();
            comboPaymentMethod = new ComboBox();
            datePicker1 = new DateTimePicker();
            btnAddTransaction = new Button();
            colorDialog1 = new ColorDialog();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            saveFileDialog1 = new SaveFileDialog();
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button2 = new Button();
            label5 = new Label();
            back_home = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 164);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 111);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 270);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 2;
            label3.Text = "Payment Method";
            // 
            // textAmount
            // 
            textAmount.Location = new Point(28, 134);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(125, 27);
            textAmount.TabIndex = 3;
            // 
            // comboPaymentMethod
            // 
            comboPaymentMethod.FormattingEnabled = true;
            comboPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "Bank Transfer" });
            comboPaymentMethod.Location = new Point(28, 293);
            comboPaymentMethod.Name = "comboPaymentMethod";
            comboPaymentMethod.Size = new Size(151, 28);
            comboPaymentMethod.TabIndex = 6;
            // 
            // datePicker1
            // 
            datePicker1.Location = new Point(28, 53);
            datePicker1.Name = "datePicker1";
            datePicker1.Size = new Size(250, 27);
            datePicker1.TabIndex = 7;
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.Location = new Point(28, 368);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(94, 29);
            btnAddTransaction.TabIndex = 8;
            btnAddTransaction.Text = "Save";
            btnAddTransaction.UseVisualStyleBackColor = true;
            btnAddTransaction.Click += btnAddTransaction_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 217);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 11;
            label4.Text = "Note";
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Food", "Transfer", "Hobies", "Daily Life", "Clothes", "Health", "Education", "Else" });
            comboBox1.Location = new Point(28, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(284, -2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(703, 342);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // button2
            // 
            button2.Location = new Point(284, 368);
            button2.Name = "button2";
            button2.Size = new Size(708, 29);
            button2.TabIndex = 14;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(284, 343);
            label5.Name = "label5";
            label5.Size = new Size(206, 20);
            label5.TabIndex = 15;
            label5.Text = "Sellect a transaction to delete";
            // 
            // back_home
            // 
            back_home.Location = new Point(28, 418);
            back_home.Name = "back_home";
            back_home.Size = new Size(94, 29);
            back_home.TabIndex = 16;
            back_home.Text = "Home Page";
            back_home.UseVisualStyleBackColor = true;
            back_home.Click += back_home_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 111);
            label6.Name = "label6";
            label6.Size = new Size(18, 20);
            label6.TabIndex = 17;
            label6.Text = "...";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(999, 523);
            Controls.Add(label6);
            Controls.Add(back_home);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(btnAddTransaction);
            Controls.Add(datePicker1);
            Controls.Add(comboPaymentMethod);
            Controls.Add(textAmount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form3";
            Text = "Payment Process";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)


        //private void comboPaymentMethod_SelectedIndexChanged(object sender, EventArgs e) => throw new NotImplementedException();

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textAmount;
        private TextBox textNotes;
        private TextBox textCategory;
        private ComboBox comboPaymentMethod;
        private DateTimePicker datePicker1;
        private Button btnAddTransaction;
        private Label label4;
        private Button back_home;
        private ColorDialog colorDialog1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private SaveFileDialog saveFileDialog1;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private Label label5;
        private Label label6;
    }
}