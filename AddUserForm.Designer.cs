namespace DatabaseAlbum
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.ButtonClear = new DatabaseAlbum.RJButton();
            this.ButtonAdd = new DatabaseAlbum.RJButton();
            this.ComboBoxRole = new DatabaseAlbum.RJComboBox();
            this.TextBoxPassword = new DatabaseAlbum.RJTextBox();
            this.TextBoxLogin = new DatabaseAlbum.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 47);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Добавление";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(539, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(1536, 3);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(45, 39);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxExit.TabIndex = 6;
            this.pictureBoxExit.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTitle.Location = new System.Drawing.Point(224, 107);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(247, 49);
            this.labelTitle.TabIndex = 28;
            this.labelTitle.Text = "Пользователи";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(64, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(59, 227);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(103, 29);
            this.labelLogin.TabIndex = 38;
            this.labelLogin.Text = "Логин:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(59, 292);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(118, 29);
            this.labelPassword.TabIndex = 40;
            this.labelPassword.Text = "Пароль:";
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlbum.Location = new System.Drawing.Point(59, 361);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(88, 29);
            this.labelAlbum.TabIndex = 43;
            this.labelAlbum.Text = "Роль:";
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonClear.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonClear.BorderRadius = 27;
            this.ButtonClear.BorderSize = 0;
            this.ButtonClear.FlatAppearance.BorderSize = 0;
            this.ButtonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ButtonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClear.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClear.ForeColor = System.Drawing.Color.White;
            this.ButtonClear.Location = new System.Drawing.Point(193, 435);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(161, 61);
            this.ButtonClear.TabIndex = 49;
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.TextColor = System.Drawing.Color.White;
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonAdd.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonAdd.BorderRadius = 27;
            this.ButtonAdd.BorderSize = 0;
            this.ButtonAdd.Enabled = false;
            this.ButtonAdd.FlatAppearance.BorderSize = 0;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(376, 435);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(161, 61);
            this.ButtonAdd.TabIndex = 48;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.TextColor = System.Drawing.Color.White;
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ComboBoxRole
            // 
            this.ComboBoxRole.BackColor = System.Drawing.Color.White;
            this.ComboBoxRole.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ComboBoxRole.BorderSize = 2;
            this.ComboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRole.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxRole.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxRole.IconColor = System.Drawing.Color.DarkSlateGray;
            this.ComboBoxRole.Items.AddRange(new object[] {
            "admin",
            "user",
            "seller"});
            this.ComboBoxRole.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxRole.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxRole.Location = new System.Drawing.Point(157, 354);
            this.ComboBoxRole.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxRole.Name = "ComboBoxRole";
            this.ComboBoxRole.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxRole.Size = new System.Drawing.Size(221, 36);
            this.ComboBoxRole.TabIndex = 42;
            this.ComboBoxRole.Texts = "";
            this.ComboBoxRole.OnSelectedIndexChanged += new System.EventHandler(this.ComboBoxRole_OnSelectedIndexChanged);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.Snow;
            this.TextBoxPassword.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.TextBoxPassword.BorderFocusColor = System.Drawing.Color.Indigo;
            this.TextBoxPassword.BorderRadius = 0;
            this.TextBoxPassword.BorderSize = 2;
            this.TextBoxPassword.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPassword.Location = new System.Drawing.Point(190, 283);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxPassword.MaxLength = 8;
            this.TextBoxPassword.MinLength = 0;
            this.TextBoxPassword.Multiline = false;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxPassword.PasswordChar = false;
            this.TextBoxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxPassword.PlaceholderText = "8 символов";
            this.TextBoxPassword.Size = new System.Drawing.Size(192, 37);
            this.TextBoxPassword.TabIndex = 41;
            this.TextBoxPassword.Texts = "";
            this.TextBoxPassword.UnderlinedStyle = true;
            this.TextBoxPassword._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.BackColor = System.Drawing.Color.Snow;
            this.TextBoxLogin.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.TextBoxLogin.BorderFocusColor = System.Drawing.Color.Indigo;
            this.TextBoxLogin.BorderRadius = 0;
            this.TextBoxLogin.BorderSize = 2;
            this.TextBoxLogin.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLogin.ForeColor = System.Drawing.Color.Black;
            this.TextBoxLogin.Location = new System.Drawing.Point(186, 214);
            this.TextBoxLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxLogin.MaxLength = 30;
            this.TextBoxLogin.MinLength = 0;
            this.TextBoxLogin.Multiline = false;
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxLogin.PasswordChar = false;
            this.TextBoxLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxLogin.PlaceholderText = "";
            this.TextBoxLogin.Size = new System.Drawing.Size(192, 37);
            this.TextBoxLogin.TabIndex = 39;
            this.TextBoxLogin.Texts = "";
            this.TextBoxLogin.UnderlinedStyle = true;
            this.TextBoxLogin._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(584, 534);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.ComboBoxRole);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJTextBox TextBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private RJTextBox TextBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelAlbum;
        private RJComboBox ComboBoxRole;
        private RJButton ButtonClear;
        private RJButton ButtonAdd;
    }
}