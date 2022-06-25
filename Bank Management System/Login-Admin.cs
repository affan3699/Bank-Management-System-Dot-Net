using System;
using System.Data; // for DataTable
using System.Windows.Forms;
using MySql.Data.MySqlClient; // for mysql database


namespace Bank_Management_System
{
    public partial class AdminLoginForm : System.Windows.Forms.Form
    {
        MySqlConnection connection; // Represents an open connection to a MySQL Server database
        DataTable table = new DataTable(); // table
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (isValidated() == true)
            {
                table.Clear();
                Options_Admin admin = new Options_Admin();
                this.Close();
                admin.Show();
                //MessageBox.Show("USERNAME OR PASSWORD CORRECT", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("USERNAME OR PASSWORD INCORRECT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userTextBox.Clear();
                passwordTextBox.Clear();
                userTextBox.Focus();
            }
        }

        private bool isValidated()
        {
            if (userTextBox.Text == string.Empty.Trim() || passwordTextBox.Text == string.Empty.Trim())
            {
                return false;
            }

            else
            {
                try
                {
                    //connection = new MySqlConnection("server=localhost;database=bank;uid=root;pwd=cs181099;"); // Initializes a new instance of the MySqlConnection class when given a string containing the connection string.
                    connection = new MySqlConnection("Server=sql12.freemysqlhosting.net;Port=3306;Database=sql12349824;Uid=sql12349824;Pwd=V5AmLCq9Fl;");

                    connection.Open(); // Opens a database connection with the property settings specified by the ConnectionString.

                    string query = "Select userName, passWord from adminaccounts where userName = @userName and passWord = @passWord"; // Query using prepared statement, Prepared statements increase security and performance. When we write prepared statements, we use placeholders instead of directly writing the values into the statements.
                    MySqlCommand sqlCommand = new MySqlCommand(query, connection); // Initializes a new instance of the MySqlCommand class with the text of the query and a MySqlConnection. Used for executing SQL statements in database.

                    // replacing the placeholder values with user input values
                    sqlCommand.Parameters.AddWithValue("@userName", userTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@passWord", passwordTextBox.Text);
                    sqlCommand.Prepare();

                    // MysqlDataReader provides a way of reading a forward-only stream of rows from a SQL Server database
                    MySqlDataReader reader = sqlCommand.ExecuteReader(); // Sends the query to the mysql and builds a MySqlDataReader.

                    table.Load(reader); // loading the reader into table
                    connection.Close(); // Closes the connection to the database

                    if (table.Rows.Count <= 0) // if no records are stored in DataTable, hence no such type of user exist
                    {
                        return false;
                    }

                    else
                    {
                        return true;
                    }
                }

                catch (MySqlException ex)
                {
                    //MessageBox.Show(ex.Message);
                }
                connection.Close(); // Closes the connection to the database

                return false;
            }
        }
    }
}