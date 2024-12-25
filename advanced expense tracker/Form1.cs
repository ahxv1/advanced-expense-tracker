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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;

            if (user == "asd" && pass == "123")
            {
                MessageBox.Show("Welcome Admin");
            }
            else
            {
                MessageBox.Show("Error username or password");
            }
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

        private void button6_Click(object sender, EventArgs e)
        {
            string file = Application.StartupPath + "\\users-info\\";
            string name = textBox3.Text;
            string surname = textBox4.Text;
            string email = textBox5.Text;
            string user = textBox6.Text;
            string pass = textBox7.Text;

            string storedUser = "";
            string storedPass = "";

            if (user.Equals("") || pass.Equals("") || name.Equals("") || surname.Equals("") || email.Equals(""))
                {
                    MessageBox.Show("Please Don't Forget to fill out all the boxes :).");
                }

            // check the file if it's empty
            if (Directory.Exists(file)){
                StreamWriter writer = new StreamWriter(file + "Info.txt");
                

                // write the data in the txt file
                writer.WriteLine(name_label.Text + ":" + name);
                writer.WriteLine(surname_label.Text + ":" + surname);
                writer.WriteLine(email_label.Text + ":" + email);
                writer.WriteLine(username_label.Text + ":" + user);
                writer.WriteLine(password_label.Text + ":" + pass);
                MessageBox.Show("Account Created Successfully");
                writer.Close();

                //read from the file
                StreamReader reader = new StreamReader(file+"Info.txt");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("username:"))
                    {
                        storedUser = line.Replace("username:", "").Trim();
                    }
                    else if (line.StartsWith("password:"))
                    {
                        storedPass = line.Replace("password:", "").Trim();
                    }
                }
                reader.Close();
                MessageBox.Show(storedUser);

            } else if (!Directory.Exists(file))
            {
                Directory.CreateDirectory(file);
                MessageBox.Show("There was a missing file - now fixed");

                StreamWriter writer = new StreamWriter(file + "Info.txt");
                writer.WriteLine(name_label.Text + ":" + name);
                writer.WriteLine(surname_label.Text + ":" + surname);
                writer.WriteLine(email_label.Text + ":" + email);
                writer.WriteLine(username_label.Text + ":" + user);
                writer.WriteLine(password_label.Text + ":" + pass);
                MessageBox.Show("Account Created Successfully");
                writer.Close();
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
