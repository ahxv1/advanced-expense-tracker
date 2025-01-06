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
    public partial class Form2 : Form
    {
        private string storedUser;
        private string storedName;
        private string storedSurname;
        private string storedEmail;

        // Store selected currency
        private string selectedCurrency = "USD"; // Default currency

        // Flag to suppress message box on first load
        private bool isFirstLoad = true;

        // Track the current theme
        private bool isDarkMode = false;

        public Form2(string storedUser, string storedName, string storedSurname, string storedEmail)
        {
            InitializeComponent();
            // Apply the current theme
            ThemeManager.ApplyTheme(this);
            this.storedEmail = storedEmail;
            this.storedUser = storedUser;
            this.storedName = storedName;
            this.storedSurname = storedSurname;

            // Populate comboBox1 with currencies, including Turkish Lira (TRY)
            comboBox1.Items.AddRange(new string[] { "USD", "EUR", "GBP", "JPY", "TRY" });
            comboBox1.SelectedIndex = 0; // Default selection
        }

        private void AddRemoveButton_Click_1(object sender, EventArgs e)
        {
            // Pass the selected currency to Form3
            this.Hide();
            Form3 form3 = new Form3(storedUser, storedName, storedSurname, storedEmail, selectedCurrency);
            form3.Show();
        }

        private void Logout_button_Click_1(object sender, EventArgs e)
        {
            // Apply default theme (light mode) on logout
            ThemeManager.IsDarkMode = false;
            ThemeManager.ApplyTheme(this); // Apply light theme to current form

            // Navigate to the login screen (Form1)
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close(); // Close the current form (Home_page)
        }

        private void Account_button_Click_1(object sender, EventArgs e)
        {
            AccountDetails accountDetailsForm = new AccountDetails(storedUser, storedName, storedSurname, storedEmail);
            accountDetailsForm.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Suppress the message box on first load
            if (isFirstLoad)
            {
                isFirstLoad = false;
                return;
            }

            // Update the selected currency based on user selection
            selectedCurrency = comboBox1.SelectedItem.ToString();

            // Display a message or update relevant data
            MessageBox.Show($"Currency changed to {selectedCurrency}", "Currency Update");

            // Add logic here to adjust amounts or other data in the app based on the selected currency
        }

        private void ThemeToggleButton_Click(object sender, EventArgs e)
        {
            // This method seems to be unused, you can remove it if not needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Toggle the theme
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                // Set dark mode colors
                this.BackColor = System.Drawing.Color.FromArgb(45, 45, 48); // Dark gray background
                this.ForeColor = System.Drawing.Color.White; // White text

                // Update controls
                foreach (Control control in this.Controls)
                {
                    if (control is Button || control is Label || control is ComboBox)
                    {
                        control.BackColor = System.Drawing.Color.FromArgb(28, 28, 28); // Darker gray
                        control.ForeColor = System.Drawing.Color.White;
                    }
                }
            }
            else
            {
                // Set light mode colors
                this.BackColor = System.Drawing.Color.White; // White background
                this.ForeColor = System.Drawing.Color.Black; // Black text

                // Update controls
                foreach (Control control in this.Controls)
                {
                    if (control is Button || control is Label || control is ComboBox)
                    {
                        control.BackColor = System.Drawing.Color.LightGray; // Light gray
                        control.ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
            // Toggle the theme
            ThemeManager.ToggleTheme();

            // Apply the new theme to the current form
            ThemeManager.ApplyTheme(this);
        }
    }
}
