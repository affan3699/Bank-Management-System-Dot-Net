namespace Bank_Management_System
{
    partial class Option
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentBalanceLabel = new System.Windows.Forms.Label();
            this.DepositButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.WithDrawButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.LogOutButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.StatementButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.TransferButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 55);
            this.panel1.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(373, 20);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(251, 26);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Select Action To Perform";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank ABC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current Balance : ";
            // 
            // currentBalanceLabel
            // 
            this.currentBalanceLabel.AutoSize = true;
            this.currentBalanceLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBalanceLabel.Location = new System.Drawing.Point(242, 80);
            this.currentBalanceLabel.Name = "currentBalanceLabel";
            this.currentBalanceLabel.Size = new System.Drawing.Size(32, 23);
            this.currentBalanceLabel.TabIndex = 14;
            this.currentBalanceLabel.Text = "0$";
            // 
            // DepositButton
            // 
            this.DepositButton.BackColor = System.Drawing.Color.SeaGreen;
            this.DepositButton.color = System.Drawing.Color.SeaGreen;
            this.DepositButton.colorActive = System.Drawing.Color.Azure;
            this.DepositButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DepositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.DepositButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DepositButton.Image = global::Bank_Management_System.Properties.Resources.economic_growth;
            this.DepositButton.ImagePosition = 20;
            this.DepositButton.ImageZoom = 50;
            this.DepositButton.LabelPosition = 41;
            this.DepositButton.LabelText = "Deposit";
            this.DepositButton.Location = new System.Drawing.Point(658, 206);
            this.DepositButton.Margin = new System.Windows.Forms.Padding(6);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(157, 161);
            this.DepositButton.TabIndex = 16;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // WithDrawButton
            // 
            this.WithDrawButton.BackColor = System.Drawing.Color.SeaGreen;
            this.WithDrawButton.color = System.Drawing.Color.SeaGreen;
            this.WithDrawButton.colorActive = System.Drawing.Color.Azure;
            this.WithDrawButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WithDrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.WithDrawButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.WithDrawButton.Image = global::Bank_Management_System.Properties.Resources.cash;
            this.WithDrawButton.ImagePosition = 20;
            this.WithDrawButton.ImageZoom = 50;
            this.WithDrawButton.LabelPosition = 41;
            this.WithDrawButton.LabelText = "WithDraw";
            this.WithDrawButton.Location = new System.Drawing.Point(440, 206);
            this.WithDrawButton.Margin = new System.Windows.Forms.Padding(6);
            this.WithDrawButton.Name = "WithDrawButton";
            this.WithDrawButton.Size = new System.Drawing.Size(157, 161);
            this.WithDrawButton.TabIndex = 15;
            this.WithDrawButton.Click += new System.EventHandler(this.WithDrawButton_Click);
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.ProfilePictureBox.Location = new System.Drawing.Point(923, 60);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(144, 128);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePictureBox.TabIndex = 13;
            this.ProfilePictureBox.TabStop = false;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogOutButton.color = System.Drawing.SystemColors.ActiveCaption;
            this.LogOutButton.colorActive = System.Drawing.Color.Red;
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LogOutButton.Image = global::Bank_Management_System.Properties.Resources.exit;
            this.LogOutButton.ImagePosition = 20;
            this.LogOutButton.ImageZoom = 50;
            this.LogOutButton.LabelPosition = 41;
            this.LogOutButton.LabelText = "Logout";
            this.LogOutButton.Location = new System.Drawing.Point(978, 436);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(6);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(89, 108);
            this.LogOutButton.TabIndex = 12;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // StatementButton
            // 
            this.StatementButton.BackColor = System.Drawing.Color.SeaGreen;
            this.StatementButton.color = System.Drawing.Color.SeaGreen;
            this.StatementButton.colorActive = System.Drawing.Color.Azure;
            this.StatementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.StatementButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StatementButton.Image = global::Bank_Management_System.Properties.Resources.print;
            this.StatementButton.ImagePosition = 20;
            this.StatementButton.ImageZoom = 50;
            this.StatementButton.LabelPosition = 41;
            this.StatementButton.LabelText = "Statement";
            this.StatementButton.Location = new System.Drawing.Point(228, 206);
            this.StatementButton.Margin = new System.Windows.Forms.Padding(6);
            this.StatementButton.Name = "StatementButton";
            this.StatementButton.Size = new System.Drawing.Size(158, 161);
            this.StatementButton.TabIndex = 9;
            this.StatementButton.Click += new System.EventHandler(this.StatementButton_Click);
            // 
            // TransferButton
            // 
            this.TransferButton.BackColor = System.Drawing.Color.SeaGreen;
            this.TransferButton.color = System.Drawing.Color.SeaGreen;
            this.TransferButton.colorActive = System.Drawing.Color.Azure;
            this.TransferButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransferButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TransferButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TransferButton.Image = ((System.Drawing.Image)(resources.GetObject("TransferButton.Image")));
            this.TransferButton.ImagePosition = 20;
            this.TransferButton.ImageZoom = 50;
            this.TransferButton.LabelPosition = 41;
            this.TransferButton.LabelText = "Transfer";
            this.TransferButton.Location = new System.Drawing.Point(35, 206);
            this.TransferButton.Margin = new System.Windows.Forms.Padding(6);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(157, 161);
            this.TransferButton.TabIndex = 6;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1069, 549);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.WithDrawButton);
            this.Controls.Add(this.currentBalanceLabel);
            this.Controls.Add(this.ProfilePictureBox);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatementButton);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientDetails";
            this.Activated += new System.EventHandler(this.Option_Activated);
            this.Load += new System.EventHandler(this.Option_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton TransferButton;
        private Bunifu.Framework.UI.BunifuTileButton StatementButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTileButton LogOutButton;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.Label currentBalanceLabel;
        private Bunifu.Framework.UI.BunifuTileButton WithDrawButton;
        private Bunifu.Framework.UI.BunifuTileButton DepositButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}