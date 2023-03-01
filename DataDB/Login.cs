using System.Data.SqlClient;

namespace DataDB
{
    public partial class ConnectionWindow : Form
    {
        public ConnectionWindow()
        {
            InitializeComponent();
        }

        private void BTNConnect_Click(object sender, EventArgs e)
        {
            string server = serverTextBox.Text;
            string database = databaseTextBox.Text;
            string user = userTextBox.Text;
            string password = passwordTextBox.Text;

            // Bypass credential input
            //string connectionString = "Server=YourServer;User Id=YourUser;Password=YourPassword!;";

            // User need to input credentials
            string connectionString = $"Server={server};Database={database};User Id={user};Password={password}";

            // Check null fields 
            if (server == "" && database == "" && user == "" && password == "")
            {
                MessageBox.Show("Please fill-up all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection connection = new(connectionString);
                {
                    try
                    {
                        connection.Open();
                        //MessageBox.Show("Debugging mode active!", "Connection Bypassed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MessageBox.Show("Connection established successfully!");

                        // ... Authenticate user and establish database connection ...
                        MainForm mainForm = new(connectionString);
                        mainForm.FormClosed += MainForm_FormClosed;
                        mainForm.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to the database: " + ex.Message);
                    }
                }
            }
        }

        private void MainForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}