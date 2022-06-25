using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bank_Management_System
{
    public partial class Option : System.Windows.Forms.Form
    {
        MySqlConnection connection;
        string AID = "";
        public Option(string AID)
        {
            this.AID = AID;
            InitializeComponent();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.f1.Show();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            Transfer t1 = new Transfer(AID);
            t1.ShowDialog();
        }

        private void Option_Load(object sender, EventArgs e)
        {
            try
            {
                //connection = new MySqlConnection("server=localhost;database=bank;uid=root;pwd=cs181099;");
                connection = new MySqlConnection("Server=sql12.freemysqlhosting.net;Port=3306;Database=sql12349824;Uid=sql12349824;Pwd=V5AmLCq9Fl;");
                string query = "select accounts.Balance, customers.Picture from customers join accounts on accounts.CID=customers.CID where accounts.AID=@AID;";
                MySqlCommand sqlCommand = new MySqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@AID", AID);

                connection.Open();
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                
                if(reader.Read() == true) // Read advances the MySqlDataReader to next record, means if any record is present
                {
                    currentBalanceLabel.Text = "$" + reader.GetInt32("Balance").ToString(); // getting current balance of login client
                    byte[] bytes = (byte[])reader[1]; // getting the current user picture data and storing in byte array
                    MemoryStream ms = new MemoryStream(bytes); // loading that bytes to MemoryStream
                    ProfilePictureBox.Image = Image.FromStream(ms); // Fianlly loading the picture to picturebox
                }

                connection.Close();
                reader.Close();
                
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit(AID);
            deposit.ShowDialog();
        }

        private void Option_Activated(object sender, EventArgs e)
        {
            Option_Load(null, null);
        }

        private void WithDrawButton_Click(object sender, EventArgs e)
        {
            WithDraw withDraw = new WithDraw(AID);
            withDraw.ShowDialog();
        }

        private void StatementButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font F = new Font("Yu Gothic UI", 13, FontStyle.Bold); // font
            Brush B = Brushes.Black; // font colour
            int y = 350;

            /* In draw string method, 5 arguments are needed, string, Font, Colour, X-coordinate, Y- coordinate*/
            e.Graphics.DrawImage(Properties.Resources.BankLogo, 190, 1); // Header Image
            e.Graphics.DrawString("NAME", F, B, 10, 320);
            e.Graphics.DrawString("BalanceTranfer", F, B, 200, 320);
            e.Graphics.DrawString("Time", F, B, 500, 320);
            e.Graphics.DrawString("Action", F, B, 700, 320);

            try
            {
                connection = new MySqlConnection("server=localhost;database=bank;uid=root;pwd=cs181099;");
                //connection = new MySqlConnection("Server=sql12.freemysqlhosting.net;Port=3306;Database=sql12348170;Uid=sql12348170;Pwd=aWEazfLWE5;");
                string query = "select Name, BalanceTranferred, TimeStamp, action from balancetransferlog where AID=@AID;";
                MySqlCommand sqlCommand = new MySqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@AID", AID);

                connection.Open();
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    e.Graphics.DrawString(reader.GetString("Name"), F, B, 10, y);
                    e.Graphics.DrawString(reader.GetString("BalanceTranferred"), F, B, 200, y);
                    e.Graphics.DrawString(reader.GetString("TimeStamp"), F, B, 450, y);
                    e.Graphics.DrawString(reader.GetString("action"), F, B, 700, y);

                    y = y + 30;
                }

                connection.Close();
                reader.Close();

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
