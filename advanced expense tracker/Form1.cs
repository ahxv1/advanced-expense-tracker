using System;
using System.IO;
using System.Windows.Forms;

namespace advanced_expense_tracker
{
    public partial class Form1 : Form
    {
        private string storedUser = "";
        private string storedPass = "";
        private string storedName = "";
        private string storedSurname = "";
        private string storedEmail = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            button4.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            button5.BackColor = System.Drawing.Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            button5.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            button4.BackColor = System.Drawing.Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string directoryPath = Path.Combine(Application.StartupPath, "users-info");
            string filePath = Path.Combine(directoryPath, "Info.txt");

            string name = textBox3.Text.Trim();
            string surname = textBox4.Text.Trim();
            string email = textBox5.Text.Trim();
            string user = textBox6.Text.Trim();
            string pass = textBox7.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            try
            {
                if (!Directory.Exists(directoryPath))
                    Directory.CreateDirectory(directoryPath);

                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    writer.WriteLine($"Name:{name}");
                    writer.WriteLine($"Surname:{surname}");
                    writer.WriteLine($"Email:{email}");
                    writer.WriteLine($"Username:{user}");
                    writer.WriteLine($"Password:{pass}");
                }

                // Store the user data for future use
                storedUser = user;
                storedName = name;
                storedSurname = surname;
                storedEmail = email;

                MessageBox.Show("Account created successfully!");
                this.Hide();
                Form2 transactionForm = new Form2(storedUser, storedName, storedSurname, storedEmail);
                transactionForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "users-info", "Info.txt");
            string user = textBox1.Text.Trim();
            string pass = textBox2.Text.Trim();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No user data found. Please register first.");
                return;
            }

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.StartsWith("Username:"))
                            storedUser = line.Replace("Username:", "").Trim();
                        else if (line.StartsWith("Password:"))
                            storedPass = line.Replace("Password:", "").Trim();
                        else if (line.StartsWith("Name:"))
                            storedName = line.Replace("Name:", "").Trim();
                        else if (line.StartsWith("Surname:"))
                            storedSurname = line.Replace("Surname:", "").Trim();
                        else if (line.StartsWith("Email:"))
                            storedEmail = line.Replace("Email:", "").Trim();
                    }
                }

                if (user == storedUser && pass == storedPass)
                {
                    MessageBox.Show($"Welcome, {storedUser}!");
                    this.Hide();
                    Form2 homePage = new Form2(storedUser, storedName, storedSurname, storedEmail);
                    homePage.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        
    }
}
