using System;
using System.Drawing; // for print preview
using System.IO; // for MemoryStream
using System.Text; // for StringBuilder
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bank_Management_System
{
    public partial class Details : System.Windows.Forms.Form
    {
        MySqlConnection connection;
        MySqlTransaction myTrans;
        public Details()
        {
            InitializeComponent();
        }

        private void PictureBrowseButton_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();

            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                ProfilepictureBox.Image = new Bitmap(open.FileName);
            }
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            if (isValidated() == true)
            {
                MessageBox.Show("Account Created SucessFully", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            catch (Exception)
            {
                MessageBox.Show("Boxes Cannot Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (int i in NameTextBox.Text) // name must not have number
            {
                if (i >= '0' && i <= '9')
                {
                    MessageBox.Show("Name Must Not Contain Any Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            foreach (int i in MobileTextBox.Text) // mobile must not have alphabet
            {
                if (i >= 'A' && i <= 'Z' || i >= 'a' && i <= 'z')
                {
                    MessageBox.Show("Number Must Not Contain Any Alphabet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if(!(EmailTextBox.Text.Contains("@")))
            {
                MessageBox.Show("Email Not Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (NameTextBox.Text == string.Empty.Trim() || CNICTextBox.Text == string.Empty.Trim() || EmailTextBox.Text == string.Empty.Trim() || MobileTextBox.Text == string.Empty.Trim() || AddressTextBox.Text == string.Empty.Trim() || BalanceTextBox.Text == string.Empty.Trim())
            {
                MessageBox.Show("Boxes Cannot Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            else
            {
                try
                {
                    connection = new MySqlConnection("server=localhost;database=bank;uid=root;pwd=cs181099;");
                    //connection = new MySqlConnection("Server=sql12.freemysqlhosting.net;Port=3306;Database=sql12349824;Uid=sql12349824;Pwd=V5AmLCq9Fl;");

                    connection.Open();
                    myTrans = connection.BeginTransaction();

                    string query = "insert into customers(FullName, CNIC, Email, Contact, Address, Picture) values(@FullName, @CNIC, @Email, @Contact, @Address, @Picture)";
                    string query2 = "insert into accounts(CID, AccountTypeID, Balance, signature, password) values(@CID, @AccountTypeID, @Balance, @signature, @password)";
                    MySqlCommand sqlCommand = new MySqlCommand(query, connection, myTrans);
                    MySqlCommand sqlCommand2 = new MySqlCommand(query2, connection, myTrans);
                   
                    sqlCommand.Parameters.AddWithValue("@FullName", NameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@CNIC", CNICTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Contact", MobileTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Address", AddressTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Picture", pictureBox());
                    
                    int records = sqlCommand.ExecuteNonQuery(); // executing the query for insert

                    sqlCommand2.Parameters.AddWithValue("@CID", getCid());

                    if(AccountTypeComboBox.Text == "S")
                    {
                        sqlCommand2.Parameters.AddWithValue("@AccountTypeID", 1);
                    }
                    
                    else
                    {
                        sqlCommand2.Parameters.AddWithValue("@AccountTypeID", 2);
                    }

                    sqlCommand2.Parameters.AddWithValue("@Balance", BalanceTextBox.Text);
                    sqlCommand2.Parameters.AddWithValue("@password", generatePass(10));
                    sqlCommand2.Parameters.AddWithValue("@signature", signatureBox());

                    sqlCommand2.ExecuteNonQuery();
                    myTrans.Commit(); // records will not saved into tables permenantly until we commit it
                    connection.Close();

                    if(records > 0)
                    {
                        NameTextBox.Clear();
                        CNICTextBox.Clear();
                        EmailTextBox.Clear();
                        MobileTextBox.Clear();
                        AddressTextBox.Clear();
                        BalanceTextBox.Clear();
                        ProfilepictureBox.Image = SignaturePictureBox.Image = null;
                        NameTextBox.Focus();
                        return true;
                    }
                }

                catch (Exception ex)
                {
                    try
                    {
                        myTrans.Rollback();
                    }

                    catch (MySqlException e)
                    {
                        if (myTrans.Connection != null)
                        {
                            MessageBox.Show("An exception of type " + e.GetType() + " was encountered while attempting to roll back the transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    MessageBox.Show("Neither record was written to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
                return false;
            }
        }

        private object generatePass(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder str = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                str.Append(valid[rnd.Next(valid.Length)]);
            }

            return str.ToString();
        }

        private int getCid()
        {
            int CNIC = 0;

            try
            {
                //connection = new MySqlConnection("server=localhost;database=bank;uid=root;pwd=cs181099;");
                string query = "select CID from customers where CNIC = @CNIC";
                MySqlCommand sqlCommand = new MySqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@CNIC", CNICTextBox.Text);
                
                //connection.Open();
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read() == true)
                {
                    CNIC = reader.GetInt32("CID");
                }

                //connection.Close();
                reader.Close();
                return CNIC;
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }

        private Byte[] pictureBox()
        {
            MemoryStream memoryStream = new MemoryStream(); // Creates a stream whose backing store is memory.
            ProfilepictureBox.Image.Save(memoryStream, ProfilepictureBox.Image.RawFormat); // saving the image rawformat into MemoryStream
            return memoryStream.GetBuffer(); // Returns the array of unsigned bytes from which this stream was created.
        }

        private Byte[] signatureBox()
        {
            MemoryStream memoryStream = new MemoryStream(); // Creates a stream whose backing store is memory.
            SignaturePictureBox.Image.Save(memoryStream, SignaturePictureBox.Image.RawFormat);
            return memoryStream.GetBuffer(); // Returns the array of unsigned bytes from which this stream was created.
        }

        private void SignBrowseButton_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                SignaturePictureBox.Image = new Bitmap(open.FileName);
            }
        }
    }
}