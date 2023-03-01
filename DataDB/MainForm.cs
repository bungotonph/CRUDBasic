using System.Data;
using System.Data.SqlClient;

namespace DataDB
{
    public partial class MainForm : Form
    {
        private readonly string connectionString;
        private SqlDataAdapter adapter;
        private DataSet dataSet;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public MainForm(string connectionString)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void BTNView_Click(object sender, EventArgs e)
        {
            // Create a connection object
            SqlConnection connection = new(connectionString);
            {
                // Open the connection
                connection.Open();

                // Create a SQL command to select all data from a table
                SqlCommand command = new("SELECT * FROM cabal_auth_table", connection);

                // Create a data adapter and fill the data set
                adapter = new SqlDataAdapter(command);
                dataSet = new DataSet();
                adapter.Fill(dataSet);

                // Bind the data set to the DataGridView control
                dataGridView1.DataSource = dataSet.Tables[0];

                // Create a SqlCommandBuilder object
                SqlCommandBuilder builder = new(adapter);

                // Hide columns to the DataGridView
                dataGridView1.Columns["IdentityNo"].Visible = false;
                dataGridView1.Columns["Password"].Visible = false;
                dataGridView1.Columns["LoginEx"].Visible = false;
                dataGridView1.Columns["Question"].Visible = false;
                dataGridView1.Columns["Answer"].Visible = false;
                dataGridView1.Columns["DiscordId"].Visible = false;
                dataGridView1.Columns["DiscordAvatar"].Visible = false;

                // Enable editing for the DataGridView control
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns["UserNum"].ReadOnly = true;
            }
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            // Save the changes made to the data set to the database
            adapter.Update(dataSet);
            MessageBox.Show("Data has been updated successfully!", "Update Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTNLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
