namespace Bank_Management_System
{
    partial class Options_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options_Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.manageAccountButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.ExitButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.createAccountButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 55);
            this.panel1.TabIndex = 13;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(373, 20);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(521, 26);
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
            // ReportButton
            // 
            this.ReportButton.BackColor = System.Drawing.Color.SeaGreen;
            this.ReportButton.color = System.Drawing.Color.SeaGreen;
            this.ReportButton.colorActive = System.Drawing.Color.LightYellow;
            this.ReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.ReportButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ReportButton.Image = global::Bank_Management_System.Properties.Resources.report;
            this.ReportButton.ImagePosition = 20;
            this.ReportButton.ImageZoom = 50;
            this.ReportButton.LabelPosition = 41;
            this.ReportButton.LabelText = "Report";
            this.ReportButton.Location = new System.Drawing.Point(479, 342);
            this.ReportButton.Margin = new System.Windows.Forms.Padding(6);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(167, 161);
            this.ReportButton.TabIndex = 22;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // manageAccountButton
            // 
            this.manageAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageAccountButton.BackColor = System.Drawing.Color.SeaGreen;
            this.manageAccountButton.color = System.Drawing.Color.SeaGreen;
            this.manageAccountButton.colorActive = System.Drawing.Color.LightYellow;
            this.manageAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.manageAccountButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.manageAccountButton.Image = global::Bank_Management_System.Properties.Resources.manage;
            this.manageAccountButton.ImagePosition = 20;
            this.manageAccountButton.ImageZoom = 50;
            this.manageAccountButton.LabelPosition = 41;
            this.manageAccountButton.LabelText = "Manage Accounts";
            this.manageAccountButton.Location = new System.Drawing.Point(691, 100);
            this.manageAccountButton.Margin = new System.Windows.Forms.Padding(6);
            this.manageAccountButton.Name = "manageAccountButton";
            this.manageAccountButton.Size = new System.Drawing.Size(186, 161);
            this.manageAccountButton.TabIndex = 21;
            this.manageAccountButton.Click += new System.EventHandler(this.manageAccountButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.SeaGreen;
            this.ExitButton.color = System.Drawing.Color.SeaGreen;
            this.ExitButton.colorActive = System.Drawing.Color.Red;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ExitButton.Image = global::Bank_Management_System.Properties.Resources.exit;
            this.ExitButton.ImagePosition = 20;
            this.ExitButton.ImageZoom = 50;
            this.ExitButton.LabelPosition = 41;
            this.ExitButton.LabelText = "Exit";
            this.ExitButton.Location = new System.Drawing.Point(1093, 433);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(6);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(89, 108);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // createAccountButton
            // 
            this.createAccountButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createAccountButton.BackColor = System.Drawing.Color.SeaGreen;
            this.createAccountButton.color = System.Drawing.Color.SeaGreen;
            this.createAccountButton.colorActive = System.Drawing.Color.LightYellow;
            this.createAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.createAccountButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.createAccountButton.Image = global::Bank_Management_System.Properties.Resources.add;
            this.createAccountButton.ImagePosition = 20;
            this.createAccountButton.ImageZoom = 50;
            this.createAccountButton.LabelPosition = 41;
            this.createAccountButton.LabelText = "Create Account";
            this.createAccountButton.Location = new System.Drawing.Point(238, 113);
            this.createAccountButton.Margin = new System.Windows.Forms.Padding(6);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(167, 161);
            this.createAccountButton.TabIndex = 14;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // Options_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1197, 556);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.manageAccountButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Options_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options_Admin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton ExitButton;
        private Bunifu.Framework.UI.BunifuTileButton createAccountButton;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton ReportButton;
        private Bunifu.Framework.UI.BunifuTileButton manageAccountButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}