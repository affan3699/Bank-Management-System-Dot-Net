using System;
using System.Windows.Forms;
using System.Management; // for ManagementObjectSearcher

namespace Bank_Management_System
{
    public partial class Welcome : System.Windows.Forms.Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        
        private void ClientAdminLoginButton_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedText == "Admin Login")
            {
                AdminLoginForm admin = new AdminLoginForm();
                this.Hide();
                admin.Show();
            }

            else
            {
                ClientLoginForm client = new ClientLoginForm();
                this.Hide();
                client.Show();
            }
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedText = "Admin Login";

            string SNO = null;
            ManagementObjectSearcher ABC = new ManagementObjectSearcher("root\\CIMV2", "Select SerialNumber from Win32_BaseBoard"); // Retrieves a collection of management objects based on a specified query.

            foreach (ManagementObject item in ABC.Get()) // When the Get() method on this object is invoked, the ManagementObjectSearcher executes the given query in the specified scope and returns a collection of management objects that match the query
            { 
                SNO = item.GetPropertyValue("SerialNumber").ToString(); // return SerialNumber
            }
            
            if (SNO != "/4T2DR72/CN1296364T0097/") // if current MotherBoard SerialNumber is not equal to specified
            {
                CopyRight copyRight = new CopyRight();
                this.Hide();
                copyRight.ShowDialog();
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
