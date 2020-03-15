namespace CHADANI_ACCOUNTING_SOFTWARE
{
    partial class LoginPage
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.UserTextbox = new MetroFramework.Controls.MetroTextBox();
            this.PassTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(59, 62);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Username:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(59, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Password";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Lime;
            this.metroButton1.Location = new System.Drawing.Point(59, 158);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(104, 41);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Login";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Red;
            this.metroButton2.Location = new System.Drawing.Point(266, 158);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(104, 41);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Close";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // UserTextbox
            // 
            // 
            // 
            // 
            this.UserTextbox.CustomButton.Image = null;
            this.UserTextbox.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.UserTextbox.CustomButton.Name = "";
            this.UserTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UserTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserTextbox.CustomButton.TabIndex = 1;
            this.UserTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserTextbox.CustomButton.UseSelectable = true;
            this.UserTextbox.CustomButton.Visible = false;
            this.UserTextbox.Lines = new string[0];
            this.UserTextbox.Location = new System.Drawing.Point(186, 62);
            this.UserTextbox.MaxLength = 32767;
            this.UserTextbox.Name = "UserTextbox";
            this.UserTextbox.PasswordChar = '\0';
            this.UserTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserTextbox.SelectedText = "";
            this.UserTextbox.SelectionLength = 0;
            this.UserTextbox.SelectionStart = 0;
            this.UserTextbox.ShortcutsEnabled = true;
            this.UserTextbox.Size = new System.Drawing.Size(184, 23);
            this.UserTextbox.TabIndex = 0;
            this.UserTextbox.UseSelectable = true;
            this.UserTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PassTextBox
            // 
            // 
            // 
            // 
            this.PassTextBox.CustomButton.Image = null;
            this.PassTextBox.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.PassTextBox.CustomButton.Name = "";
            this.PassTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PassTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassTextBox.CustomButton.TabIndex = 1;
            this.PassTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassTextBox.CustomButton.UseSelectable = true;
            this.PassTextBox.CustomButton.Visible = false;
            this.PassTextBox.Lines = new string[0];
            this.PassTextBox.Location = new System.Drawing.Point(186, 106);
            this.PassTextBox.MaxLength = 32767;
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassTextBox.SelectedText = "";
            this.PassTextBox.SelectionLength = 0;
            this.PassTextBox.SelectionStart = 0;
            this.PassTextBox.ShortcutsEnabled = true;
            this.PassTextBox.Size = new System.Drawing.Size(184, 23);
            this.PassTextBox.TabIndex = 2;
            this.PassTextBox.UseSelectable = true;
            this.PassTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 236);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.UserTextbox);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "LoginPage";
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox UserTextbox;
        private MetroFramework.Controls.MetroTextBox PassTextBox;
    }
}

