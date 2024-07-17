namespace DatabaseAlbum
{
    partial class EditJurnalUceta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditJurnalUceta));
            this.ButtonEdit = new DatabaseAlbum.RJButton();
            this.TextBoxCountSold = new DatabaseAlbum.RJTextBox();
            this.labelCountSold = new System.Windows.Forms.Label();
            this.TextBoxCountAlbumsDeliver = new DatabaseAlbum.RJTextBox();
            this.labelCountAlbumsDeliver = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.ComboBoxAlbum = new DatabaseAlbum.RJComboBox();
            this.labelMonth = new System.Windows.Forms.Label();
            this.TextBoxMonth = new DatabaseAlbum.RJTextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonEdit.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonEdit.BorderRadius = 27;
            this.ButtonEdit.BorderSize = 0;
            this.ButtonEdit.Enabled = false;
            this.ButtonEdit.FlatAppearance.BorderSize = 0;
            this.ButtonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.ButtonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEdit.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEdit.ForeColor = System.Drawing.Color.White;
            this.ButtonEdit.Location = new System.Drawing.Point(499, 514);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(161, 61);
            this.ButtonEdit.TabIndex = 53;
            this.ButtonEdit.Text = "Изменить";
            this.ButtonEdit.TextColor = System.Drawing.Color.White;
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // TextBoxCountSold
            // 
            this.TextBoxCountSold.BackColor = System.Drawing.Color.Snow;
            this.TextBoxCountSold.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.TextBoxCountSold.BorderFocusColor = System.Drawing.Color.Indigo;
            this.TextBoxCountSold.BorderRadius = 0;
            this.TextBoxCountSold.BorderSize = 2;
            this.TextBoxCountSold.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxCountSold.ForeColor = System.Drawing.Color.Black;
            this.TextBoxCountSold.Location = new System.Drawing.Point(332, 431);
            this.TextBoxCountSold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxCountSold.MaxLength = 10;
            this.TextBoxCountSold.MinLength = 0;
            this.TextBoxCountSold.Multiline = false;
            this.TextBoxCountSold.Name = "TextBoxCountSold";
            this.TextBoxCountSold.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxCountSold.PasswordChar = false;
            this.TextBoxCountSold.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxCountSold.PlaceholderText = "";
            this.TextBoxCountSold.Size = new System.Drawing.Size(174, 37);
            this.TextBoxCountSold.TabIndex = 52;
            this.TextBoxCountSold.Texts = "";
            this.TextBoxCountSold.UnderlinedStyle = true;
            this.TextBoxCountSold._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            this.TextBoxCountSold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDigits_KeyPress);
            // 
            // labelCountSold
            // 
            this.labelCountSold.AutoSize = true;
            this.labelCountSold.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountSold.Location = new System.Drawing.Point(44, 441);
            this.labelCountSold.Name = "labelCountSold";
            this.labelCountSold.Size = new System.Drawing.Size(268, 29);
            this.labelCountSold.TabIndex = 51;
            this.labelCountSold.Text = "Кол-во проданных:";
            // 
            // TextBoxCountAlbumsDeliver
            // 
            this.TextBoxCountAlbumsDeliver.BackColor = System.Drawing.Color.Snow;
            this.TextBoxCountAlbumsDeliver.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.TextBoxCountAlbumsDeliver.BorderFocusColor = System.Drawing.Color.Indigo;
            this.TextBoxCountAlbumsDeliver.BorderRadius = 0;
            this.TextBoxCountAlbumsDeliver.BorderSize = 2;
            this.TextBoxCountAlbumsDeliver.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxCountAlbumsDeliver.ForeColor = System.Drawing.Color.Black;
            this.TextBoxCountAlbumsDeliver.Location = new System.Drawing.Point(374, 363);
            this.TextBoxCountAlbumsDeliver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxCountAlbumsDeliver.MaxLength = 10;
            this.TextBoxCountAlbumsDeliver.MinLength = 0;
            this.TextBoxCountAlbumsDeliver.Multiline = false;
            this.TextBoxCountAlbumsDeliver.Name = "TextBoxCountAlbumsDeliver";
            this.TextBoxCountAlbumsDeliver.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxCountAlbumsDeliver.PasswordChar = false;
            this.TextBoxCountAlbumsDeliver.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxCountAlbumsDeliver.PlaceholderText = "";
            this.TextBoxCountAlbumsDeliver.Size = new System.Drawing.Size(174, 37);
            this.TextBoxCountAlbumsDeliver.TabIndex = 50;
            this.TextBoxCountAlbumsDeliver.Texts = "";
            this.TextBoxCountAlbumsDeliver.UnderlinedStyle = true;
            this.TextBoxCountAlbumsDeliver._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            this.TextBoxCountAlbumsDeliver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDigits_KeyPress);
            // 
            // labelCountAlbumsDeliver
            // 
            this.labelCountAlbumsDeliver.AutoSize = true;
            this.labelCountAlbumsDeliver.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountAlbumsDeliver.Location = new System.Drawing.Point(44, 371);
            this.labelCountAlbumsDeliver.Name = "labelCountAlbumsDeliver";
            this.labelCountAlbumsDeliver.Size = new System.Drawing.Size(313, 29);
            this.labelCountAlbumsDeliver.TabIndex = 49;
            this.labelCountAlbumsDeliver.Text = "Кол-во поставленных:";
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlbum.Location = new System.Drawing.Point(44, 302);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(118, 29);
            this.labelAlbum.TabIndex = 48;
            this.labelAlbum.Text = "Альбом:";
            // 
            // ComboBoxAlbum
            // 
            this.ComboBoxAlbum.BackColor = System.Drawing.Color.White;
            this.ComboBoxAlbum.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ComboBoxAlbum.BorderSize = 2;
            this.ComboBoxAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAlbum.Enabled = false;
            this.ComboBoxAlbum.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxAlbum.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxAlbum.IconColor = System.Drawing.Color.DarkSlateGray;
            this.ComboBoxAlbum.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxAlbum.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxAlbum.Location = new System.Drawing.Point(180, 293);
            this.ComboBoxAlbum.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxAlbum.Name = "ComboBoxAlbum";
            this.ComboBoxAlbum.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxAlbum.Size = new System.Drawing.Size(315, 38);
            this.ComboBoxAlbum.TabIndex = 47;
            this.ComboBoxAlbum.Texts = "";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMonth.Location = new System.Drawing.Point(44, 227);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(103, 29);
            this.labelMonth.TabIndex = 46;
            this.labelMonth.Text = "Месяц:";
            // 
            // TextBoxMonth
            // 
            this.TextBoxMonth.BackColor = System.Drawing.Color.Snow;
            this.TextBoxMonth.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.TextBoxMonth.BorderFocusColor = System.Drawing.Color.Indigo;
            this.TextBoxMonth.BorderRadius = 0;
            this.TextBoxMonth.BorderSize = 2;
            this.TextBoxMonth.Enabled = false;
            this.TextBoxMonth.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxMonth.ForeColor = System.Drawing.Color.Black;
            this.TextBoxMonth.Location = new System.Drawing.Point(167, 214);
            this.TextBoxMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxMonth.MaxLength = 10;
            this.TextBoxMonth.MinLength = 0;
            this.TextBoxMonth.Multiline = false;
            this.TextBoxMonth.Name = "TextBoxMonth";
            this.TextBoxMonth.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxMonth.PasswordChar = false;
            this.TextBoxMonth.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxMonth.PlaceholderText = "";
            this.TextBoxMonth.Size = new System.Drawing.Size(174, 37);
            this.TextBoxMonth.TabIndex = 45;
            this.TextBoxMonth.Texts = "";
            this.TextBoxMonth.UnderlinedStyle = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelTitle.Location = new System.Drawing.Point(186, 99);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(252, 49);
            this.labelTitle.TabIndex = 44;
            this.labelTitle.Text = "Журнал учета";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
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
            this.panel1.Size = new System.Drawing.Size(716, 47);
            this.panel1.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "Изменение информации";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(671, 0);
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
            this.ButtonClear.Location = new System.Drawing.Point(306, 514);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(161, 61);
            this.ButtonClear.TabIndex = 57;
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.TextColor = System.Drawing.Color.White;
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // EditJurnalUceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(716, 618);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.TextBoxCountSold);
            this.Controls.Add(this.labelCountSold);
            this.Controls.Add(this.TextBoxCountAlbumsDeliver);
            this.Controls.Add(this.labelCountAlbumsDeliver);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.ComboBoxAlbum);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.TextBoxMonth);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditJurnalUceta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditJurnalUceta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton ButtonEdit;
        private RJTextBox TextBoxCountSold;
        private System.Windows.Forms.Label labelCountSold;
        private RJTextBox TextBoxCountAlbumsDeliver;
        private System.Windows.Forms.Label labelCountAlbumsDeliver;
        private System.Windows.Forms.Label labelAlbum;
        private RJComboBox ComboBoxAlbum;
        private System.Windows.Forms.Label labelMonth;
        private RJTextBox TextBoxMonth;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label label1;
        private RJButton ButtonClear;
    }
}