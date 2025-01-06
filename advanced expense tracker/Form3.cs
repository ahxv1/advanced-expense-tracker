using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace advanced_expense_tracker
{
    public partial class Form3 : Form
    {
        // Initialize a list to store transactions
        private List<Transaction> transactions = new List<Transaction>();

        private string storedUser;
        private string storedName;
        private string storedSurname;
        private string storedEmail;
        private string selectedCurrency; // New variable to store currency

        public Form3(string storedUser, string storedName, string storedSurname, string storedEmail, string selectedCurrency)
        {
            InitializeComponent();
            this.storedUser = storedUser;
            this.storedName = storedName;
            this.storedSurname = storedSurname;
            this.storedEmail = storedEmail;
            this.selectedCurrency = selectedCurrency; // Assign the passed currency value
            LoadTransactionsFromFile(); // Load existing transactions on form load
            ThemeManager.ApplyTheme(this);

            // Update Label6 with the selected currency
            label6.Text =  selectedCurrency;
        }

        // Event handler for the 'Save' button click
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            // Parse input values from form controls
            decimal amount;
            if (!decimal.TryParse(textAmount.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            // Ensure ComboBox has a selected item
            string paymentMethod = comboPaymentMethod.SelectedItem?.ToString() ?? "N/A"; // Use "N/A" if nothing is selected

            // Validate that category is not empty
            if (string.IsNullOrEmpty(comboBox1.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            // Create a new Transaction object
            Transaction newTransaction = new Transaction
            {
                Amount = amount,
                Category = comboBox1.SelectedItem.ToString(),
                PaymentMethod = paymentMethod,
                Date = datePicker1.Value,
                Notes = string.IsNullOrEmpty(textBox1.Text) ? null : textBox1.Text // Allow empty or null notes
            };

            // Add the new transaction to the list
            transactions.Add(newTransaction);

            // Save the transactions to a file
            SaveTransactionsToFile();

            // Bind the updated list to the DataGridView
            dataGridView1.DataSource = null; // Reset the binding
            dataGridView1.DataSource = transactions; // Bind the updated list

            // Notify the user
            MessageBox.Show("Transaction added successfully!");

            // Clear inputs after adding the transaction
            ClearInputs();
        }

        // Method to clear form inputs after a successful transaction
        private void ClearInputs()
        {
            textAmount.Clear();
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            comboPaymentMethod.SelectedIndex = -1;
            datePicker1.Value = DateTime.Now;
        }

        // Method to save transactions to a JSON file
        private void SaveTransactionsToFile()
        {
            string filePath = Application.StartupPath + "\\users-info\\" + "transactions.json";
            try
            {
                string json = JsonConvert.SerializeObject(transactions, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving transactions to file: " + ex.Message);
            }
        }

        // Method to load transactions from a JSON file
        private void LoadTransactionsFromFile()
        {
            string filePath = Application.StartupPath + "\\users-info\\" + "transactions.json";
            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    transactions = JsonConvert.DeserializeObject<List<Transaction>>(json) ?? new List<Transaction>();
                    dataGridView1.DataSource = transactions; // Bind loaded data to DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading transactions from file: " + ex.Message);
                }
            }
        }

        // Event handler for the 'View' button click (this is not yet implemented)
        private void btnViewTransaction_Click(object sender, EventArgs e)
        {
            // TODO: Implement functionality to view transactions (e.g., display them in a detailed format)
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ensure that a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to delete.");
                return;
            }

            // Get the index of the selected row
            int selectedIndex = dataGridView1.SelectedRows[0].Index;

            // Remove the selected transaction from the list
            transactions.RemoveAt(selectedIndex);

            // Save the updated list to the file
            SaveTransactionsToFile();

            // Update the DataGridView
            dataGridView1.DataSource = null; // Reset the binding
            dataGridView1.DataSource = transactions; // Bind the updated list

            // Notify the user
            MessageBox.Show("Transaction deleted successfully!");
        }

        private void back_home_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2(storedUser, storedName, storedSurname, storedEmail);
            form2.Show();
        }
    }

    // Define the Transaction class to represent a single transaction
    public class Transaction
    {
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
    }
}
