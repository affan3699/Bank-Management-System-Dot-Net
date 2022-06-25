using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bank_Management_System
{
    public partial class ManageAccounts : System.Windows.Forms.Form
    {
        MySqlConnection connection;
        string CID = "";
        DataTable table = new DataTable();
        string comboBoxValue = "";

        public ManageAccounts()
        {
            InitializeComponent();
        }

        private void ManageAccounts_Load(object sender, EventArgs e)
        {
            
            UserDataGridView.DataSource = getData();

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)UserDataGridView.Columns[0];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private DataTable getData()
        {
            
            //connection = new MySqlConnection("server=localhost;database=bank;uid=root;pwd=cs181099;");
            connection = new MySqlConnection("Server=sql12.freemysqlhosting.net;Port=3306;Database=sql12349824;Uid=sql12349824;Pwd=V5AmLCq9Fl;");
            string query = "select customers.Picture, customers.CID, accounts.AID, accounts.password, customers.FullName, customers.CNIC, customers.Email, customers.Contact, accounts.Balance, customers.Address from customers join accounts on accounts.CID=customers.CID";
            MySqlCommand sqlCommand = new MySqlCommand(query, connection);

            connection.Open();
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            table.Load(reader);
            reader.Close();
            connection.Close();
            return table;
        }

        private void UserDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex; // getting current row index

                DataGridViewRow row = UserDataGridView.Rows[i]; // getting all row data, on that index

                /*Displaying each and every row index data to specific textbox*/
                byte[] bytes = (byte[])row.Cells[0].Value;
                MemoryStream ms = new MemoryStream(bytes);
                ProfilepictureBox.Image = Image.FromStream(ms);
                NameTextBox.Text = row.Cells[4].Value.ToString();
                CNICTextBox.Text = row.Cells[5].Value.ToString();
                EmailTextBox.Text = row.Cells[6].Value.ToString();
                MobileTextBox.Text = row.Cells[7].Value.ToString();
                BalanceTextBox.Text = row.Cells[8].Value.ToString();
                AddressRichBox.Text = row.Cells[9].Value.ToString();
                CID = row.Cells[1].Value.ToString();
            }

            catch (Exception)
            {
                // this exception is for, if a user clicks the header row or if row index < 0
                //MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(isValidated() == true)
            {
                MessageBox.Show("Record Updated SucessFully", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManageAccounts_Load(null, null);
            }
        }

        private bool isValidated()
        {
            try
            {
                if (int.Parse(BalanceTextBox.Text) < 0)
                {
                    MessageBox.Show("Balance Must be > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            
            catch(Exception e)
            {
                MessageBox.Show("Boxes Cannot Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (int i in NameTextBox.Text)
            {
                if (i >= '0' && i <= '9')
                {
                    MessageBox.Show("Name Must Not Contain Any Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            foreach (int i in MobileTextBox.Text)
            {
                if (i >= 'A' && i <= 'Z' || i >= 'a' && i <= 'z')
                {
                    MessageBox.Show("Number Must Not Contain Any Alphabet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (NameTextBox.Text == string.Empty.Trim() || CNICTextBox.Text == string.Empty.Trim() || EmailTextBox.Text == string.Empty.Trim() || MobileTextBox.Text == string.Empty.Trim() || AddressRichBox.Text == string.Empty.Trim() || BalanceTextBox.Text == string.Empty.Trim())
            {
                MessageBox.Show("Boxes Cannot Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
            {
                try
                {
                    //connection = new MySqlConnection("server=localhost;database=bank;uid=root;pwd=cs181099;");
                    connection = new MySqlConnection("Server=sql12.freemysqlhosting.net;Port=3306;Database=sql12349824;Uid=sql12349824;Pwd=V5AmLCq9Fl;");

                    string query = "update customers join accounts on customers.CID=accounts.CID set Fullname=@Fullname, CNIC=@CNIC, Email=@Email, Contact=@Contact, Balance=@Balance, Address=@Address where customers.CID=@CID";
                    MySqlCommand sqlCommand = new MySqlCommand(query, connection);

                    sqlCommand.Parameters.AddWithValue("@FullName", NameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@CNIC", CNICTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Contact", MobileTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Address", AddressRichBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Balance", BalanceTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@CID", CID);

                    connection.Open();
                    int records = sqlCommand.ExecuteNonQuery();
                    connection.Close();

                    if (records > 0)
                    {
                        NameTextBox.Clear();
                        CNICTextBox.Clear();
                        EmailTextBox.Clear();
                        MobileTextBox.Clear();
                        AddressRichBox.Clear();
                        BalanceTextBox.Clear();
                        ProfilepictureBox.Image = null;
                        removeTriggerRecord(); // if balance == 0
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

        private void removeTriggerRecord()
        {
            try
            {
                connection = new MySqlConnection("server=localhost;database=bank;uid=root;pwd=cs181099;");
                //connection = new MySqlConnection("Server=sql12.freemysqlhosting.net;Port=3306;Database=sql12349824;Uid=sql12349824;Pwd=V5AmLCq9Fl;");

                string query = "delete from balancetransferlog where balancetranferred = 0";
                MySqlCommand sqlCommand = new MySqlCommand(query, connection);

                connection.Open();
                int records = sqlCommand.ExecuteNonQuery();
                connection.Close();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure To Delete?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    //connection = new MySqlConnection("server=localhost;database=bank;uid=root;pwd=cs181099;");
                    connection = new MySqlConnection("Server=sql12.freemysqlhosting.net;Port=3306;Database=sql12349824;Uid=sql12349824;Pwd=V5AmLCq9Fl;");

                    string query = "delete from customers where CID = @CID";
                    MySqlCommand sqlCommand = new MySqlCommand(query, connection);

                    sqlCommand.Parameters.AddWithValue("@CID", CID);

                    connection.Open();
                    int records = sqlCommand.ExecuteNonQuery();
                    connection.Close();

                    if (records > 0)
                    {
                        NameTextBox.Clear();
                        CNICTextBox.Clear();
                        EmailTextBox.Clear();
                        MobileTextBox.Clear();
                        AddressRichBox.Clear();
                        BalanceTextBox.Clear();
                        ProfilepictureBox.Image = null;
                        MessageBox.Show("Record Deleted SucessFully", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ManageAccounts_Load(null, null);
                    }
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();
            }
        }

        private void SearchTextBox_OnValueChanged(object sender, EventArgs e)
        {
            DataView dataView = new DataView(table);

            if(comboBoxValue == "FullName")
            {
                dataView.RowFilter = string.Format("FullName LIKE '%{0}%'", SearchTextBox.Text.Trim()); // 0 is an argument i.e 0 = SearchTextBox value
            }

            else if(comboBoxValue == "CID")
            {
                dataView.RowFilter = string.Format("CONVERT({0}, System.String) LIKE '%{1}%'", comboBoxValue, SearchTextBox.Text.Trim()); // 0 = comboboxvalue, 1 = SearchTextBox value
            }

            else if (comboBoxValue == "CNIC")
            {
                dataView.RowFilter = string.Format("CONVERT({0}, System.String) LIKE '%{1}%'", comboBoxValue, SearchTextBox.Text.Trim()); // same as above
            }

            UserDataGridView.DataSource = dataView; // assigning filtered data to datagridview
        }

        private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxValue = SearchComboBox.Text;
        }
    }
}
