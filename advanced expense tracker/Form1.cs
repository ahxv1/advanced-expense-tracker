using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

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
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            button4.BackColor = Color.FromArgb(224, 224, 224);
            button5.BackColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            button5.BackColor = Color.FromArgb(224, 224, 224);
            button4.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        // Register button click event handler
        public void button6_Click(object sender, EventArgs e)
        {
            string file = Application.StartupPath + "\\users-info\\";
            string name = textBox3.Text;
            string surname = textBox4.Text;
            string email = textBox5.Text;
            string user = textBox6.Text;
            string pass = textBox7.Text;

            // Check if the boxes are empty
            if (user.Equals("") || pass.Equals("") || name.Equals("") || surname.Equals("") || email.Equals(""))
            {
                MessageBox.Show("Please don't forget to fill out all the boxes.");
            }
            else
            {
                // Check if the directory exists
                if (!Directory.Exists(file))
                {
                    Directory.CreateDirectory(file); // Create the directory if it doesn't exist
                    MessageBox.Show("Directory was missing - now fixed");
                }

                // Write the data in the text file
                StreamWriter writer = new StreamWriter(file + "Info.txt");
                writer.WriteLine("Name:" + name);
                writer.WriteLine("Surname:" + surname);
                writer.WriteLine("Email:" + email);
                writer.WriteLine("Username:" + user);
                writer.WriteLine("Password:" + pass);
                writer.Close();

                MessageBox.Show("Account created successfully!");

                // Open Form5 (Transaction Form)
                this.Hide();  // Hide the registration form
                Form2 transactionForm = new Form2();  // Open Form5
                transactionForm.Show();
            }
        }

        // Login button click event handler
        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            string file = Application.StartupPath + "\\users-info\\Info.txt";

            if (File.Exists(file))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(file))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.StartsWith("Username:"))
                            {
                                storedUser = line.Replace("Username:", "").Trim();
                            }
                            else if (line.StartsWith("Password:"))
                            {
                                storedPass = line.Replace("Password:", "").Trim();
                            }
                            else if (line.StartsWith("Name:"))
                            {
                                storedName = line.Replace("Name:", "").Trim();
                            }
                            else if (line.StartsWith("Surname:"))
                            {
                                storedSurname = line.Replace("Surname:", "").Trim();
                            }
                            else if (line.StartsWith("Email:"))
                            {
                                storedEmail = line.Replace("Email:", "").Trim();
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading user file: {ex.Message}");
                }
            }

            // Check if the login is successful
            if (user == "admin" && pass == "admin")
            {
                MessageBox.Show("Welcome Admin!");
                this.Hide();  // Hide the login form
                Form2 transactionForm = new Form2();  // Open Form5
                transactionForm.Show();
            }
            else if (user == storedUser && pass == storedPass)
            {
                MessageBox.Show($"Welcome, {storedUser}!");
                this.Hide();  // Hide the login form
                Form2 transactionForm = new Form2();  // Open Form5
                transactionForm.Show();
            }
            else if (user == "" && pass == "")
            {
                MessageBox.Show("No existing user data found, please create a user.");
            }
            else
            {
                MessageBox.Show("Error: Username or password is incorrect.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
        }
    }
}

