using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace advanced_expense_tracker
{
    public partial class Form2 : Form
    {
        // Initialize a list to store transactions
        private List<Transaction> transactions = new List<Transaction>();

        public Form2()
        {
            InitializeComponent();
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

            // Save the transaction to a file
            SaveTransactionToFile(newTransaction);

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

        // Method to save transaction to a file
        private void SaveTransactionToFile(Transaction transaction)
        {
            string filePath = "transactions.txt"; // Path to save the transaction data (you can change this)
            string transactionData = $"{transaction.Date.ToShortDateString()} | {transaction.Amount} | {transaction.Category} | {transaction.PaymentMethod} | {transaction.Notes}";

            try
            {
                // Append the transaction to the file
                File.AppendAllText(filePath, transactionData + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving transaction to file: " + ex.Message);
            }
        }

        // Event handler for the 'View' button click (this is not yet implemented)
        private void btnViewTransaction_Click(object sender, EventArgs e)
        {
            // TODO: Implement functionality to view transactions (e.g., display them in the dataGridView1)
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

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




