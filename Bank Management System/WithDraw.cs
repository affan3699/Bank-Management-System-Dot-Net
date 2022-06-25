using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bank_Management_System
{
    public partial class WithDraw : Form
    {
        MySqlConnection connection;
        string AID = "";
        public WithDraw(string AID)
        {
            this.AID = AID;
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (isValidated() == true)
            {
                MessageBox.Show("Amount SucessFully WithDrawn", "WithDrawn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool isValidated()
        {
            try
            {
                if (int.Parse(DepositTextBox.Text) <= 0)
                {
                    MessageBox.Show("Balance Must be > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DepositTextBox.Clear();
                    return false;
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Please, Enter Some Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DepositTextBox.Clear();
                return false;
            }

            foreach (int i in DepositTextBox.Text)
            {
                if (i >= 'A' && i <= 'Z' || i >= 'a' && i <= 'z')
                {
                    MessageBox.Show("Numbers are Allowed Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DepositTextBox.Clear();
                    return false;
                }
            }

            if (DepositTextBox.Text == string.Empty.Trim())
            {
                MessageBox.Show("Please, Enter Some Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DepositTextBox.Clear();
                return false;
            }

            else
            {
                try
                {
                    //connection = new MySqlConnection("server=localhost;database=bank;uid=root;pwd=cs181099;");
                    connection = new MySqlConnection("Server=sql12.freemysqlhosting.net;Port=3306;Database=sql12349824;Uid=sql12349824;Pwd=V5AmLCq9Fl;");

                    string query = "update accounts set Balance = Balance - @newBalance where AID=@AID";
                    MySqlCommand sqlCommand = new MySqlCommand(query, connection);

                    sqlCommand.Parameters.AddWithValue("@newBalance", DepositTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@AID", AID);


                    connection.Open();
                    int records = sqlCommand.ExecuteNonQuery();
                    connection.Close();

                    if (records > 0)
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

        private void DepositTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmButton_Click(null, null);
            }
        }
    }
}
