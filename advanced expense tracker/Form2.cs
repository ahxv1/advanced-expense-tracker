using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace advanced_expense_tracker
{
    public partial class Home_page : Form
    {
        private string storedUser;
        private string storedName;
        private string storedSurname;
        private string storedEmail;
        public Home_page(string storedUser, string storedName, string storedSurname, string storedEmail)
        {
            InitializeComponent();
            this.storedEmail = storedEmail;
            this.storedUser = storedUser;
            this.storedName = storedName;
            this.storedSurname = storedSurname;
        }

        private void AddRemoveButton_Click_1(object sender, EventArgs e)
        {

        }

        private void Logout_button_Click_1(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Close();
        }



        private void Account_button_Click_1(object sender, EventArgs e)
        {
            AccountDetails accountDetailsForm = new AccountDetails(storedUser,storedName,storedSurname,storedEmail);
            accountDetailsForm.Show();
            this.Hide();
        }
    }
}
