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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
