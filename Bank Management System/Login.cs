using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bank_Management_System
{
    public partial class ClientLoginForm : System.Windows.Forms.Form
    {
        MySqlConnection connection;
        DataTable table = new DataTable();
        public ClientLoginForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.f1.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (isValidated() == true)
            {
                table.Clear();
                Option option = new Option(AccountIDTextBox.Text);
                this.Close();
                option.Show();
                //MessageBox.Show("USERNAME OR PASSWORD CORRECT", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("AccountID OR PASSWORD INCORRECT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AccountIDTextBox.Clear();
                passwordTextBox.Clear();
                AccountIDTextBox.Focus();
            }
        }

        private bool isValidated()
        {
            if (AccountIDTextBox.Text == string.Empty.Trim() || passwordTextBox.Text == string.Empty.Trim())
            {
                return false;
            }

            else
            {
                try
                {
                    //connection = new MySqlConnection("server=localhost;database=bank;uid=root;pwd=cs181099;");
                    connection = new MySqlConnection("Server=sql12.freemysqlhosting.net;Port=3306;Database=sql12349824;Uid=sql12349824;Pwd=V5AmLCq9Fl;");
                    connection.Open();

                    string query = "Select AID, password from accounts where AID = @AID and password = @password";
                    MySqlCommand sqlCommand = new MySqlCommand(query, connection);

                    sqlCommand.Parameters.AddWithValue("@AID", AccountIDTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@password", passwordTextBox.Text);

                    MySqlDataReader reader = sqlCommand.ExecuteReader();
                    table.Load(reader);
                    connection.Close();

                    if (table.Rows.Count <= 0)
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
                connection.Close();

                return false;
            }
        }
    }
}
