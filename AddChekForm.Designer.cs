namespace DatabaseAlbum
{
    partial class AddChekForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChekForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelCountAlbums = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.maskedTextBoxTime = new System.Windows.Forms.MaskedTextBox();
            this.ButtonAdd = new DatabaseAlbum.RJButton();
            this.TextBoxCountAlbums = new DatabaseAlbum.RJTextBox();
            this.ComboBoxAlbum = new DatabaseAlbum.RJComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.panel1.Size = new System.Drawing.Size(638, 47);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Добавление информации";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(593, 0);
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
            this.labelTitle.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelTitle.Location = new System.Drawing.Point(201, 107);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(170, 52);
            this.labelTitle.TabIndex = 27;
            this.labelTitle.Text = "Покупки";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // labelCountAlbums
            // 
            this.labelCountAlbums.AutoSize = true;
            this.labelCountAlbums.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountAlbums.Location = new System.Drawing.Point(47, 442);
            this.labelCountAlbums.Name = "labelCountAlbums";
            this.labelCountAlbums.Size = new System.Drawing.Size(118, 29);
            this.labelCountAlbums.TabIndex = 36;
            this.labelCountAlbums.Text = "Кол-во:";
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlbum.Location = new System.Drawing.Point(47, 378);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(118, 29);
            this.labelAlbum.TabIndex = 35;
            this.labelAlbum.Text = "Альбом:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelData.Location = new System.Drawing.Point(47, 231);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(208, 29);
            this.labelData.TabIndex = 31;
            this.labelData.Text = "Дата покупки:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(47, 300);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(223, 29);
            this.labelTime.TabIndex = 39;
            this.labelTime.Text = "Время покупки:";
            // 
            // maskedTextBoxTime
            // 
            this.maskedTextBoxTime.BackColor = System.Drawing.SystemColors.Window;
            this.maskedTextBoxTime.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxTime.Location = new System.Drawing.Point(276, 297);
            this.maskedTextBoxTime.Name = "maskedTextBoxTime";
            this.maskedTextBoxTime.ReadOnly = true;
            this.maskedTextBoxTime.Size = new System.Drawing.Size(84, 32);
            this.maskedTextBoxTime.TabIndex = 38;
            this.maskedTextBoxTime.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxTime.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxTime_Validating);
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
            this.ButtonAdd.Location = new System.Drawing.Point(423, 507);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(161, 61);
            this.ButtonAdd.TabIndex = 40;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.TextColor = System.Drawing.Color.White;
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TextBoxCountAlbums
            // 
            this.TextBoxCountAlbums.BackColor = System.Drawing.Color.Snow;
            this.TextBoxCountAlbums.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.TextBoxCountAlbums.BorderFocusColor = System.Drawing.Color.Indigo;
            this.TextBoxCountAlbums.BorderRadius = 0;
            this.TextBoxCountAlbums.BorderSize = 2;
            this.TextBoxCountAlbums.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxCountAlbums.ForeColor = System.Drawing.Color.Black;
            this.TextBoxCountAlbums.Location = new System.Drawing.Point(183, 434);
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
            // ComboBoxAlbum
            // 
            this.ComboBoxAlbum.BackColor = System.Drawing.Color.White;
            this.ComboBoxAlbum.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ComboBoxAlbum.BorderSize = 2;
            this.ComboBoxAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAlbum.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxAlbum.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxAlbum.IconColor = System.Drawing.Color.DarkSlateGray;
            this.ComboBoxAlbum.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxAlbum.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxAlbum.Location = new System.Drawing.Point(183, 372);
            this.ComboBoxAlbum.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxAlbum.Name = "ComboBoxAlbum";
            this.ComboBoxAlbum.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxAlbum.Size = new System.Drawing.Size(296, 36);
            this.ComboBoxAlbum.TabIndex = 34;
            this.ComboBoxAlbum.Texts = "";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy.MM.dd";
            this.dateTimePicker.Font = new System.Drawing.Font("Century", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(261, 226);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(140, 34);
            this.dateTimePicker.TabIndex = 41;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
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
            this.ButtonClear.Location = new System.Drawing.Point(240, 507);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(161, 61);
            this.ButtonClear.TabIndex = 47;
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.TextColor = System.Drawing.Color.White;
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // AddChekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(638, 606);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.maskedTextBoxTime);
            this.Controls.Add(this.TextBoxCountAlbums);
            this.Controls.Add(this.labelCountAlbums);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.ComboBoxAlbum);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddChekForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddChekForm";
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
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJTextBox TextBoxCountAlbums;
        private System.Windows.Forms.Label labelCountAlbums;
        private System.Windows.Forms.Label labelAlbum;
        private RJComboBox ComboBoxAlbum;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTime;
        private RJButton ButtonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private RJButton ButtonClear;
        private System.Windows.Forms.Label label1;
    }
}