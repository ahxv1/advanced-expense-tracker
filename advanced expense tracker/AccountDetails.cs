using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace advanced_expense_tracker
{
    public partial class AccountDetails : Form
    {
        private string storedUser;
        private string storedName;
        private string storedSurname;
        private string storedEmail;
        public AccountDetails(string storedUser, string storedName, string storedSurname, string storedEmail)
        {
            InitializeComponent();
            // Apply the current theme
            ThemeManager.ApplyTheme(this);
            this.storedEmail = storedEmail;
            this.storedUser = storedUser;
            this.storedName = storedName;
            this.storedSurname = storedSurname;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            label8.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Text = storedName;
            label5.Text = storedSurname;
            label6.Text = storedEmail;
            label7.Text = storedUser;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void BackToHP_Click(object sender, EventArgs e)
        {
            Home_page newForm = new Home_page(storedUser, storedName, storedSurname, storedEmail);
            newForm.Show();
            this.Close();
            
        }
    }
}
