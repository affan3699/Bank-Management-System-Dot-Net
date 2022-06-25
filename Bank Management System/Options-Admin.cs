using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bank_Management_System
{
    public partial class Options_Admin : System.Windows.Forms.Form
    {
        MySqlConnection connection;
        public Options_Admin()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.f1.Show();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.ShowDialog();
        }

        private void manageAccountButton_Click(object sender, EventArgs e)
        {
            ManageAccounts manageAccounts = new ManageAccounts();
            manageAccounts.ShowDialog();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font F = new Font("Yu Gothic UI", 13, FontStyle.Bold); // font
            Brush B = Brushes.Black; // font colour
            int y = 350;

            /* In draw string method, 5 arguments are needed, string, Font, Colour, X-coordinate, Y- coordinate*/
            e.Graphics.DrawImage(Properties.Resources.BankLogo, 250, 1); // Header Image
            e.Graphics.DrawString("CID", F, B, 10, 320);
            e.Graphics.DrawString("AID", F, B, 100, 320);
            e.Graphics.DrawString("FullName", F, B, 190, 320);
            e.Graphics.DrawString("CNIC", F, B, 400, 320);
            e.Graphics.DrawString("Email", F, B, 560, 320);
            e.Graphics.DrawString("Contact", F, B, 750, 320);
            e.Graphics.DrawString("Balance", F, B, 950, 320);

            try
            {
               // connection = new MySqlConnection("server=localhost;database=bank;uid=root;pwd=cs181099;");
                connection = new MySqlConnection("Server=sql12.freemysqlhosting.net;Port=3306;Database=sql12349824;Uid=sql12349824;Pwd=V5AmLCq9Fl;");
                string query = "select customers.CID, accounts.AID, customers.FullName, customers.CNIC, customers.Email, customers.Contact, accounts.balance from customers join accounts on accounts.CID=customers.CID";
                MySqlCommand sqlCommand = new MySqlCommand(query, connection);

                connection.Open();
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    e.Graphics.DrawString(reader.GetString("CID"), F, B, 10, y);
                    e.Graphics.DrawString(reader.GetString("AID"), F, B, 100, y);
                    e.Graphics.DrawString(reader.GetString("FullName"), F, B, 190, y);
                    e.Graphics.DrawString(reader.GetString("CNIC"), F, B, 400, y);
                    e.Graphics.DrawString(reader.GetString("Email"), F, B, 560, y);
                    e.Graphics.DrawString(reader.GetString("Contact"), F, B, 750, y);
                    e.Graphics.DrawString(reader.GetString("balance"), F, B, 950, y);
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
