using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bank_Management_System
{
    public partial class Transfer : System.Windows.Forms.Form
    {
        MySqlConnection connection;
        string AID = "";
        public Transfer(string AID)
        {
            this.AID = AID;
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Transfer?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if(deposit() == true && withDraw() == true)
                {
                    MessageBox.Show("Balance Succesfully Transfered", "Tranferred", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("No Such Account Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool withDraw()
        {
            try
            {
                if (int.Parse(AmountTextBox.Text) <= 0)
                {
                    MessageBox.Show("Balance Must be > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AmountTextBox.Clear();
                    return false;
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Please, Enter Some Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AmountTextBox.Clear();
                return false;
            }

            foreach (int i in AmountTextBox.Text)
            {
                if (i >= 'A' && i <= 'Z' || i >= 'a' && i <= 'z')
                {
                    MessageBox.Show("Numbers are Allowed Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AmountTextBox.Clear();
                    return false;
                }
            }

            if (AmountTextBox.Text == string.Empty.Trim())
            {
                MessageBox.Show("Please, Enter Some Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AmountTextBox.Clear();
                return false;
            }

            else
            {
                try
                {
                    //connection = new MySqlConnection("server=localhost;database=bank;uid=root;pwd=cs181099;");
                    connection = new MySqlConnection("Server=sql12.freemysqlhosting.net;Port=3306;Database=sql12349824;Uid=sql12349824;Pwd=V5AmLCq9Fl;");

                    string query = "update accounts set Balance=Balance-@newBalance where AID=@AID";
                    MySqlCommand sqlCommand = new MySqlCommand(query, connection);

                    sqlCommand.Parameters.AddWithValue("@newBalance", AmountTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@AID", AID);

                    connection.Open();
                    int records = sqlCommand.ExecuteNonQuery();
                    connection.Close();

                    if(records > 0)
                    {
                        return true;
                    }
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();
                return false;
            }
        }

        private bool deposit()
        {
            try
            {
                if (int.Parse(AmountTextBox.Text) <= 0)
                {
                    MessageBox.Show("Balance Must be > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AmountTextBox.Clear();
                    return false;
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Please, Enter Some Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AmountTextBox.Clear();
                return false;
            }

            foreach (int i in AmountTextBox.Text)
            {
                if (i >= 'A' && i <= 'Z' || i >= 'a' && i <= 'z')
                {
                    MessageBox.Show("Numbers are Allowed Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AmountTextBox.Clear();
                    return false;
                }
            }

            if (AmountTextBox.Text == string.Empty.Trim())
            {
                MessageBox.Show("Please, Enter Some Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AmountTextBox.Clear();
                return false;
            }

            else
            {
                try
                {
                    //connection = new MySqlConnection("server=localhost;database=bank;uid=root;pwd=cs181099;");
                    connection = new MySqlConnection("Server=sql12.freemysqlhosting.net;Port=3306;Database=sql12349824;Uid=sql12349824;Pwd=V5AmLCq9Fl;");

                    string query = "update accounts set Balance=Balance+@newBalance where AID=@AID";
                    MySqlCommand sqlCommand = new MySqlCommand(query, connection);

                    sqlCommand.Parameters.AddWithValue("@newBalance", AmountTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@AID", ToAccountTextBox.Text);


                    connection.Open();
                    int records = sqlCommand.ExecuteNonQuery(); // Executes a SQL statement against the connection and returns the number of rows affected.
                    connection.Close();

                    if(records > 0)
                    {
                        return true;
                    }
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();
                return false;
            }
        }
    }
}
