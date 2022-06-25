using System;
using System.Windows.Forms;

namespace Bank_Management_System
{
    public partial class CopyRight : Form
    {
        public CopyRight()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
