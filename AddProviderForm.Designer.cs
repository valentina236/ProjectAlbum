namespace DatabaseAlbum
{
    partial class AddProviderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProviderForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.labelProviderName = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelRasScet = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.maskedTextBoxRasScet = new System.Windows.Forms.MaskedTextBox();
            this.ButtonAdd = new DatabaseAlbum.RJButton();
            this.TextBoxAdress = new DatabaseAlbum.RJTextBox();
            this.TextBoxProviderName = new DatabaseAlbum.RJTextBox();
            this.ButtonClear = new DatabaseAlbum.RJButton();
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
            this.panel1.Size = new System.Drawing.Size(681, 47);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Добавление информации";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(633, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 39);
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
            // labelProviderName
            // 
            this.labelProviderName.AutoSize = true;
            this.labelProviderName.Font = new System.Drawing.Font("Dubai", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProviderName.Location = new System.Drawing.Point(56, 213);
            this.labelProviderName.Name = "labelProviderName";
            this.labelProviderName.Size = new System.Drawing.Size(79, 37);
            this.labelProviderName.TabIndex = 10;
            this.labelProviderName.Text = "Имя:";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Dubai", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdress.Location = new System.Drawing.Point(56, 278);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(105, 37);
            this.labelAdress.TabIndex = 12;
            this.labelAdress.Text = "Адрес:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Dubai", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(56, 350);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(248, 37);
            this.labelPhone.TabIndex = 13;
            this.labelPhone.Text = "Номер телефона:";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.BackColor = System.Drawing.Color.Snow;
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(326, 350);
            this.maskedTextBoxPhone.Mask = "+(373) 000-00-000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(248, 32);
            this.maskedTextBoxPhone.TabIndex = 14;
            this.maskedTextBoxPhone.TextChanged += new System.EventHandler(this.maskedTextBox__TextChanged);
            this.maskedTextBoxPhone.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox_Validating);
            // 
            // labelRasScet
            // 
            this.labelRasScet.AutoSize = true;
            this.labelRasScet.Font = new System.Drawing.Font("Dubai", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRasScet.Location = new System.Drawing.Point(56, 421);
            this.labelRasScet.Name = "labelRasScet";
            this.labelRasScet.Size = new System.Drawing.Size(232, 37);
            this.labelRasScet.TabIndex = 16;
            this.labelRasScet.Text = "Расчётный счет:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(58, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 108);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelTitle.Location = new System.Drawing.Point(202, 101);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(240, 52);
            this.labelTitle.TabIndex = 25;
            this.labelTitle.Text = "Поставщики";
            // 
            // maskedTextBoxRasScet
            // 
            this.maskedTextBoxRasScet.BackColor = System.Drawing.Color.Snow;
            this.maskedTextBoxRasScet.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxRasScet.Location = new System.Drawing.Point(313, 421);
            this.maskedTextBoxRasScet.Mask = "00000000000000000000";
            this.maskedTextBoxRasScet.Name = "maskedTextBoxRasScet";
            this.maskedTextBoxRasScet.Size = new System.Drawing.Size(269, 32);
            this.maskedTextBoxRasScet.TabIndex = 26;
            this.maskedTextBoxRasScet.TextChanged += new System.EventHandler(this.maskedTextBox__TextChanged);
            this.maskedTextBoxRasScet.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox_Validating);
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
            this.ButtonAdd.Location = new System.Drawing.Point(465, 489);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(161, 61);
            this.ButtonAdd.TabIndex = 23;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.TextColor = System.Drawing.Color.White;
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TextBoxAdress
            // 
            this.TextBoxAdress.BackColor = System.Drawing.Color.Snow;
            this.TextBoxAdress.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.TextBoxAdress.BorderFocusColor = System.Drawing.Color.DarkMagenta;
            this.TextBoxAdress.BorderRadius = 0;
            this.TextBoxAdress.BorderSize = 2;
            this.TextBoxAdress.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAdress.ForeColor = System.Drawing.Color.Black;
            this.TextBoxAdress.Location = new System.Drawing.Point(182, 269);
            this.TextBoxAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxAdress.MaxLength = 70;
            this.TextBoxAdress.MinLength = 0;
            this.TextBoxAdress.Multiline = false;
            this.TextBoxAdress.Name = "TextBoxAdress";
            this.TextBoxAdress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxAdress.PasswordChar = false;
            this.TextBoxAdress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxAdress.PlaceholderText = "";
            this.TextBoxAdress.Size = new System.Drawing.Size(278, 37);
            this.TextBoxAdress.TabIndex = 11;
            this.TextBoxAdress.Texts = "";
            this.TextBoxAdress.UnderlinedStyle = true;
            this.TextBoxAdress._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            // 
            // TextBoxProviderName
            // 
            this.TextBoxProviderName.BackColor = System.Drawing.Color.Snow;
            this.TextBoxProviderName.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.TextBoxProviderName.BorderFocusColor = System.Drawing.Color.DarkMagenta;
            this.TextBoxProviderName.BorderRadius = 0;
            this.TextBoxProviderName.BorderSize = 2;
            this.TextBoxProviderName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxProviderName.ForeColor = System.Drawing.Color.Black;
            this.TextBoxProviderName.Location = new System.Drawing.Point(161, 208);
            this.TextBoxProviderName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxProviderName.MaxLength = 32767;
            this.TextBoxProviderName.MinLength = 0;
            this.TextBoxProviderName.Multiline = false;
            this.TextBoxProviderName.Name = "TextBoxProviderName";
            this.TextBoxProviderName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxProviderName.PasswordChar = false;
            this.TextBoxProviderName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxProviderName.PlaceholderText = "";
            this.TextBoxProviderName.Size = new System.Drawing.Size(189, 37);
            this.TextBoxProviderName.TabIndex = 9;
            this.TextBoxProviderName.Texts = "";
            this.TextBoxProviderName.UnderlinedStyle = true;
            this.TextBoxProviderName._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            this.TextBoxProviderName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxProviderName_KeyPress);
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
            this.ButtonClear.Location = new System.Drawing.Point(285, 489);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(161, 61);
            this.ButtonClear.TabIndex = 45;
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.TextColor = System.Drawing.Color.White;
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // AddProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(681, 586);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.maskedTextBoxRasScet);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.labelRasScet);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.TextBoxAdress);
            this.Controls.Add(this.labelProviderName);
            this.Controls.Add(this.TextBoxProviderName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProviderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProviderForm";
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label labelProviderName;
        private RJTextBox TextBoxProviderName;
        private System.Windows.Forms.Label labelAdress;
        private RJTextBox TextBoxAdress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label labelRasScet;
        private RJButton ButtonAdd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRasScet;
        private RJButton ButtonClear;
        private System.Windows.Forms.Label label1;
    }
}