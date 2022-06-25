namespace Bank_Management_System
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.label4 = new System.Windows.Forms.Label();
            this.DepositTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(83, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter Amount:";
            // 
            // DepositTextBox
            // 
            this.DepositTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositTextBox.Location = new System.Drawing.Point(70, 49);
            this.DepositTextBox.Name = "DepositTextBox";
            this.DepositTextBox.Size = new System.Drawing.Size(198, 33);
            this.DepositTextBox.TabIndex = 10;
            this.DepositTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DepositTextBox_KeyDown);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ConfirmButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ConfirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfirmButton.BorderRadius = 0;
            this.ConfirmButton.ButtonText = "Confirm";
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.DisabledColor = System.Drawing.Color.Gray;
            this.ConfirmButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ConfirmButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("ConfirmButton.Iconimage")));
            this.ConfirmButton.Iconimage_right = null;
            this.ConfirmButton.Iconimage_right_Selected = null;
            this.ConfirmButton.Iconimage_Selected = null;
            this.ConfirmButton.IconMarginLeft = 0;
            this.ConfirmButton.IconMarginRight = 0;
            this.ConfirmButton.IconRightVisible = true;
            this.ConfirmButton.IconRightZoom = 0D;
            this.ConfirmButton.IconVisible = true;
            this.ConfirmButton.IconZoom = 90D;
            this.ConfirmButton.IsTab = false;
            this.ConfirmButton.Location = new System.Drawing.Point(109, 88);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Normalcolor = System.Drawing.Color.DarkSlateBlue;
            this.ConfirmButton.OnHovercolor = System.Drawing.Color.PaleGreen;
            this.ConfirmButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ConfirmButton.selected = false;
            this.ConfirmButton.Size = new System.Drawing.Size(111, 48);
            this.ConfirmButton.TabIndex = 17;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfirmButton.Textcolor = System.Drawing.Color.White;
            this.ConfirmButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(317, 143);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DepositTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DepositTextBox;
        private Bunifu.Framework.UI.BunifuFlatButton ConfirmButton;
    }
}