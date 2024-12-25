using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
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

        private void button3_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;

        }
        Color colorr = Color.FromArgb(224, 224, 224);

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            button4.BackColor = colorr;
            button5.BackColor = Color.White;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.BringToFront(); ;
            button5.BackColor = colorr;
            button4.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        public void button6_Click(object sender, EventArgs e)
        {
            string file = Application.StartupPath + "\\users-info\\";
            string name = textBox3.Text;
            string surname = textBox4.Text;
            string email = textBox5.Text;
            string user = textBox6.Text;
            string pass = textBox7.Text;

            // check if the boxes are empty
            if (user.Equals("") || pass.Equals("") || name.Equals("") || surname.Equals("") || email.Equals(""))
                {
                    MessageBox.Show("Please Don't Forget to fill out all the boxes :).");
                }

            else {
                // check the file if it's empty
                if (Directory.Exists(file))
                {
                    StreamWriter writer = new StreamWriter(file + "Info.txt");


                    // write the data in the txt file
                    writer.WriteLine("Name:" + name);
                    writer.WriteLine("Surname:" + surname);
                    writer.WriteLine("Email:" + email);
                    writer.WriteLine("Username:" + user);
                    writer.WriteLine("Password:" + pass);
                    MessageBox.Show("Account Created Successfully");
                    writer.Close();


                    //read from the file and get the username and passwrod
                    StreamReader reader = new StreamReader(file + "Info.txt");
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
                // if the file isn't there it will creat it
                else if (!Directory.Exists(file))
                {
                    Directory.CreateDirectory(file);
                    MessageBox.Show("There was a missing file - now fixed");

                    StreamWriter writer = new StreamWriter(file + "Info.txt");
                    writer.WriteLine("Name:" + name);
                    writer.WriteLine("Surname:" + surname);
                    writer.WriteLine("Email:" + email);
                    writer.WriteLine("Username:"+ user);
                    writer.WriteLine("Password:" + pass);
                    MessageBox.Show("Account Created Successfully");
                    writer.Close();
                }
            }
               

            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            //check if the user has information from the txt file
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
            





            if (user == "admin" && pass == "admin")
            {
                MessageBox.Show("Welcome Admin");
                this.Hide();
                Form2 form = new Form2();
                form.Show();
            }
            else if (user == storedUser && pass == storedPass)
            {
                MessageBox.Show($"Welcome, {storedUser}!");
                this.Hide();
                Form2 form = new Form2();
                form.Show();
            }
            else if(user == "" && pass == "")
            {
                MessageBox.Show("No existing user data found , please creat a user.");

            }
            else
            {
                MessageBox.Show("Error username or password");
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
