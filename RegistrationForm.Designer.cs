namespace DatabaseAlbum
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonLogin = new DatabaseAlbum.RJButton();
            this.ButtonClear = new DatabaseAlbum.RJButton();
            this.TextBoxPassword = new DatabaseAlbum.RJTextBox();
            this.TextBoxLogin = new DatabaseAlbum.RJTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(165, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 504);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelTitle);
            this.panel3.Controls.Add(this.ButtonLogin);
            this.panel3.Controls.Add(this.ButtonClear);
            this.panel3.Controls.Add(this.checkBoxShowPassword);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.TextBoxPassword);
            this.panel3.Controls.Add(this.labelPassword);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.TextBoxLogin);
            this.panel3.Controls.Add(this.labelLogin);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(468, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 504);
            this.panel3.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(147, 70);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(237, 49);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Авторизация";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowPassword.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(282, 340);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(177, 23);
            this.checkBoxShowPassword.TabIndex = 8;
            this.checkBoxShowPassword.Text = "Показать пароль";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(404, 289);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelPassword.Location = new System.Drawing.Point(46, 258);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(96, 27);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Пароль";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(404, 187);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelLogin.Location = new System.Drawing.Point(46, 156);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(82, 27);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Логин";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(503, 48);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBoxExit);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(503, 48);
            this.panel5.TabIndex = 0;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(450, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(53, 48);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxExit.TabIndex = 0;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 504);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.ButtonLogin.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.ButtonLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonLogin.BorderRadius = 22;
            this.ButtonLogin.BorderSize = 0;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(299, 398);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(150, 53);
            this.ButtonLogin.TabIndex = 10;
            this.ButtonLogin.Text = "Войти";
            this.ButtonLogin.TextColor = System.Drawing.Color.White;
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.DarkCyan;
            this.ButtonClear.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.ButtonClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonClear.BorderRadius = 22;
            this.ButtonClear.BorderSize = 0;
            this.ButtonClear.FlatAppearance.BorderSize = 0;
            this.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClear.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClear.ForeColor = System.Drawing.Color.White;
            this.ButtonClear.Location = new System.Drawing.Point(51, 398);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(150, 53);
            this.ButtonClear.TabIndex = 9;
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.TextColor = System.Drawing.Color.White;
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxPassword.BorderColor = System.Drawing.Color.LightSlateGray;
            this.TextBoxPassword.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.TextBoxPassword.BorderRadius = 0;
            this.TextBoxPassword.BorderSize = 2;
            this.TextBoxPassword.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.TextBoxPassword.Location = new System.Drawing.Point(48, 296);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxPassword.MaxLength = 8;
            this.TextBoxPassword.MinLength = 0;
            this.TextBoxPassword.Multiline = false;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxPassword.PasswordChar = true;
            this.TextBoxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxPassword.PlaceholderText = "8 символов";
            this.TextBoxPassword.Size = new System.Drawing.Size(398, 37);
            this.TextBoxPassword.TabIndex = 6;
            this.TextBoxPassword.Texts = "";
            this.TextBoxPassword.UnderlinedStyle = true;
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxLogin.BorderColor = System.Drawing.Color.LightSlateGray;
            this.TextBoxLogin.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.TextBoxLogin.BorderRadius = 0;
            this.TextBoxLogin.BorderSize = 2;
            this.TextBoxLogin.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.TextBoxLogin.Location = new System.Drawing.Point(48, 194);
            this.TextBoxLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxLogin.MaxLength = 30;
            this.TextBoxLogin.MinLength = 0;
            this.TextBoxLogin.Multiline = false;
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxLogin.PasswordChar = false;
            this.TextBoxLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxLogin.PlaceholderText = "";
            this.TextBoxLogin.Size = new System.Drawing.Size(398, 37);
            this.TextBoxLogin.TabIndex = 3;
            this.TextBoxLogin.Texts = "";
            this.TextBoxLogin.UnderlinedStyle = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1333, 827);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label labelLogin;
        private RJTextBox TextBoxLogin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private RJTextBox TextBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private RJButton ButtonLogin;
        private RJButton ButtonClear;
        private System.Windows.Forms.Label labelTitle;
    }
}