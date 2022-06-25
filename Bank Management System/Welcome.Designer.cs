namespace Bank_Management_System
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.ClientAdminLoginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.exitButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // ClientAdminLoginButton
            // 
            this.ClientAdminLoginButton.ActiveBorderThickness = 1;
            this.ClientAdminLoginButton.ActiveCornerRadius = 20;
            this.ClientAdminLoginButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ClientAdminLoginButton.ActiveForecolor = System.Drawing.Color.White;
            this.ClientAdminLoginButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ClientAdminLoginButton.BackColor = System.Drawing.SystemColors.Control;
            this.ClientAdminLoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClientAdminLoginButton.BackgroundImage")));
            this.ClientAdminLoginButton.ButtonText = "Select";
            this.ClientAdminLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientAdminLoginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientAdminLoginButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ClientAdminLoginButton.IdleBorderThickness = 1;
            this.ClientAdminLoginButton.IdleCornerRadius = 20;
            this.ClientAdminLoginButton.IdleFillColor = System.Drawing.SystemColors.Window;
            this.ClientAdminLoginButton.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.ClientAdminLoginButton.IdleLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientAdminLoginButton.Location = new System.Drawing.Point(112, 368);
            this.ClientAdminLoginButton.Margin = new System.Windows.Forms.Padding(5);
            this.ClientAdminLoginButton.Name = "ClientAdminLoginButton";
            this.ClientAdminLoginButton.Size = new System.Drawing.Size(181, 41);
            this.ClientAdminLoginButton.TabIndex = 1;
            this.ClientAdminLoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClientAdminLoginButton.Click += new System.EventHandler(this.ClientAdminLoginButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin Login",
            "Client Login"});
            this.comboBox1.Location = new System.Drawing.Point(125, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Turquoise;
            this.exitButton.color = System.Drawing.Color.Turquoise;
            this.exitButton.colorActive = System.Drawing.Color.Red;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.exitButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.exitButton.Image = global::Bank_Management_System.Properties.Resources.exit;
            this.exitButton.ImagePosition = 20;
            this.exitButton.ImageZoom = 50;
            this.exitButton.LabelPosition = 41;
            this.exitButton.LabelText = "Exit";
            this.exitButton.Location = new System.Drawing.Point(359, 332);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(77, 107);
            this.exitButton.TabIndex = 14;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bank_Management_System.Properties.Resources.bank;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(442, 480);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ClientAdminLoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 ClientAdminLoginButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuTileButton exitButton;
    }
}

