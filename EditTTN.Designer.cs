namespace DatabaseAlbum
{
    partial class EditTTN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTTN));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.ButtonEdit = new DatabaseAlbum.RJButton();
            this.TextBoxCountAlbums = new DatabaseAlbum.RJTextBox();
            this.labelCountAlbums = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.ComboBoxAlbum = new DatabaseAlbum.RJComboBox();
            this.labelProvider = new System.Windows.Forms.Label();
            this.ComboBoxProvider = new DatabaseAlbum.RJComboBox();
            this.labelDataPost = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.ButtonClear = new DatabaseAlbum.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy.MM.dd";
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(294, 203);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(140, 32);
            this.dateTimePicker.TabIndex = 41;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(69, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTitle.Location = new System.Drawing.Point(193, 99);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(302, 45);
            this.labelTitle.TabIndex = 39;
            this.labelTitle.Text = "ТТН (накладная)";
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonEdit.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonEdit.BorderRadius = 27;
            this.ButtonEdit.BorderSize = 0;
            this.ButtonEdit.Enabled = false;
            this.ButtonEdit.FlatAppearance.BorderSize = 0;
            this.ButtonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ButtonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEdit.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEdit.ForeColor = System.Drawing.Color.White;
            this.ButtonEdit.Location = new System.Drawing.Point(451, 463);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(161, 61);
            this.ButtonEdit.TabIndex = 38;
            this.ButtonEdit.Text = "Изменить";
            this.ButtonEdit.TextColor = System.Drawing.Color.White;
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // TextBoxCountAlbums
            // 
            this.TextBoxCountAlbums.BackColor = System.Drawing.Color.Snow;
            this.TextBoxCountAlbums.BorderColor = System.Drawing.Color.Turquoise;
            this.TextBoxCountAlbums.BorderFocusColor = System.Drawing.Color.Indigo;
            this.TextBoxCountAlbums.BorderRadius = 0;
            this.TextBoxCountAlbums.BorderSize = 2;
            this.TextBoxCountAlbums.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxCountAlbums.ForeColor = System.Drawing.Color.Black;
            this.TextBoxCountAlbums.Location = new System.Drawing.Point(197, 396);
            this.TextBoxCountAlbums.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxCountAlbums.MaxLength = 10;
            this.TextBoxCountAlbums.MinLength = 0;
            this.TextBoxCountAlbums.Multiline = false;
            this.TextBoxCountAlbums.Name = "TextBoxCountAlbums";
            this.TextBoxCountAlbums.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxCountAlbums.PasswordChar = false;
            this.TextBoxCountAlbums.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxCountAlbums.PlaceholderText = "";
            this.TextBoxCountAlbums.Size = new System.Drawing.Size(174, 37);
            this.TextBoxCountAlbums.TabIndex = 37;
            this.TextBoxCountAlbums.Texts = "";
            this.TextBoxCountAlbums.UnderlinedStyle = true;
            this.TextBoxCountAlbums._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            this.TextBoxCountAlbums.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDigits_KeyPress);
            // 
            // labelCountAlbums
            // 
            this.labelCountAlbums.AutoSize = true;
            this.labelCountAlbums.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountAlbums.Location = new System.Drawing.Point(65, 411);
            this.labelCountAlbums.Name = "labelCountAlbums";
            this.labelCountAlbums.Size = new System.Drawing.Size(118, 29);
            this.labelCountAlbums.TabIndex = 36;
            this.labelCountAlbums.Text = "Кол-во:";
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlbum.Location = new System.Drawing.Point(65, 342);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(118, 29);
            this.labelAlbum.TabIndex = 35;
            this.labelAlbum.Text = "Альбом:";
            // 
            // ComboBoxAlbum
            // 
            this.ComboBoxAlbum.BackColor = System.Drawing.Color.White;
            this.ComboBoxAlbum.BorderColor = System.Drawing.Color.Turquoise;
            this.ComboBoxAlbum.BorderSize = 2;
            this.ComboBoxAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAlbum.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxAlbum.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxAlbum.IconColor = System.Drawing.Color.DarkSlateGray;
            this.ComboBoxAlbum.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxAlbum.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxAlbum.Location = new System.Drawing.Point(201, 333);
            this.ComboBoxAlbum.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxAlbum.Name = "ComboBoxAlbum";
            this.ComboBoxAlbum.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxAlbum.Size = new System.Drawing.Size(315, 38);
            this.ComboBoxAlbum.TabIndex = 34;
            this.ComboBoxAlbum.Texts = "";
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProvider.Location = new System.Drawing.Point(65, 274);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(163, 29);
            this.labelProvider.TabIndex = 33;
            this.labelProvider.Text = "Поставщик:";
            // 
            // ComboBoxProvider
            // 
            this.ComboBoxProvider.BackColor = System.Drawing.Color.White;
            this.ComboBoxProvider.BorderColor = System.Drawing.Color.Turquoise;
            this.ComboBoxProvider.BorderSize = 2;
            this.ComboBoxProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProvider.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxProvider.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxProvider.IconColor = System.Drawing.Color.DarkSlateGray;
            this.ComboBoxProvider.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxProvider.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxProvider.Location = new System.Drawing.Point(248, 265);
            this.ComboBoxProvider.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxProvider.Name = "ComboBoxProvider";
            this.ComboBoxProvider.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxProvider.Size = new System.Drawing.Size(200, 38);
            this.ComboBoxProvider.TabIndex = 32;
            this.ComboBoxProvider.Texts = "";
            // 
            // labelDataPost
            // 
            this.labelDataPost.AutoSize = true;
            this.labelDataPost.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataPost.Location = new System.Drawing.Point(65, 206);
            this.labelDataPost.Name = "labelDataPost";
            this.labelDataPost.Size = new System.Drawing.Size(223, 29);
            this.labelDataPost.TabIndex = 31;
            this.labelDataPost.Text = "Дата поставки:";
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
            this.panel1.Size = new System.Drawing.Size(655, 47);
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 21);
            this.label1.TabIndex = 58;
            this.label1.Text = "Изменение информации";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(610, 0);
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
            this.ButtonClear.Location = new System.Drawing.Point(270, 463);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(161, 61);
            this.ButtonClear.TabIndex = 57;
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.TextColor = System.Drawing.Color.White;
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // EditTTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(655, 557);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.TextBoxCountAlbums);
            this.Controls.Add(this.labelCountAlbums);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.ComboBoxAlbum);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.ComboBoxProvider);
            this.Controls.Add(this.labelDataPost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTTN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditTTN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTitle;
        private RJButton ButtonEdit;
        private RJTextBox TextBoxCountAlbums;
        private System.Windows.Forms.Label labelCountAlbums;
        private System.Windows.Forms.Label labelAlbum;
        private RJComboBox ComboBoxAlbum;
        private System.Windows.Forms.Label labelProvider;
        private RJComboBox ComboBoxProvider;
        private System.Windows.Forms.Label labelDataPost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private RJButton ButtonClear;
        private System.Windows.Forms.Label label1;
    }
}