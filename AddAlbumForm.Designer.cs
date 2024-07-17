namespace DatabaseAlbum
{
    partial class AddAlbumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAlbumForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.labelDataRelease = new System.Windows.Forms.Label();
            this.maskedTextBoxDataRelease = new System.Windows.Forms.MaskedTextBox();
            this.labeArtist = new System.Windows.Forms.Label();
            this.labelManufacter = new System.Windows.Forms.Label();
            this.labelFormat = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.ComboBoxFormat = new DatabaseAlbum.RJComboBox();
            this.TextBoxManufacter = new DatabaseAlbum.RJTextBox();
            this.ComboBoxGenre = new DatabaseAlbum.RJComboBox();
            this.panelAdd2 = new System.Windows.Forms.Panel();
            this.ComboBoxType = new DatabaseAlbum.RJComboBox();
            this.TextBoxUnitPrice = new DatabaseAlbum.RJTextBox();
            this.ButtonClear = new DatabaseAlbum.RJButton();
            this.ButtonAdd = new DatabaseAlbum.RJButton();
            this.TextBoxArtist = new DatabaseAlbum.RJTextBox();
            this.TextBoxAlbumName = new DatabaseAlbum.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelAdd.SuspendLayout();
            this.panelAdd2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(717, 47);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Добавление информации";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(672, 0);
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
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlbumName.Location = new System.Drawing.Point(61, 221);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(250, 27);
            this.labelAlbumName.TabIndex = 8;
            this.labelAlbumName.Text = "Название альбома:";
            // 
            // labelDataRelease
            // 
            this.labelDataRelease.AutoSize = true;
            this.labelDataRelease.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataRelease.Location = new System.Drawing.Point(61, 289);
            this.labelDataRelease.Name = "labelDataRelease";
            this.labelDataRelease.Size = new System.Drawing.Size(194, 27);
            this.labelDataRelease.TabIndex = 10;
            this.labelDataRelease.Text = "Дата выпуска:";
            // 
            // maskedTextBoxDataRelease
            // 
            this.maskedTextBoxDataRelease.BackColor = System.Drawing.Color.Snow;
            this.maskedTextBoxDataRelease.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxDataRelease.Location = new System.Drawing.Point(261, 286);
            this.maskedTextBoxDataRelease.Mask = "0000-00-00";
            this.maskedTextBoxDataRelease.Name = "maskedTextBoxDataRelease";
            this.maskedTextBoxDataRelease.Size = new System.Drawing.Size(172, 30);
            this.maskedTextBoxDataRelease.TabIndex = 11;
            this.maskedTextBoxDataRelease.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataRelease.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxDataRelease_Validating);
            // 
            // labeArtist
            // 
            this.labeArtist.AutoSize = true;
            this.labeArtist.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeArtist.Location = new System.Drawing.Point(61, 356);
            this.labeArtist.Name = "labeArtist";
            this.labeArtist.Size = new System.Drawing.Size(180, 27);
            this.labeArtist.TabIndex = 12;
            this.labeArtist.Text = "Исполнитель:";
            // 
            // labelManufacter
            // 
            this.labelManufacter.AutoSize = true;
            this.labelManufacter.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManufacter.Location = new System.Drawing.Point(10, 18);
            this.labelManufacter.Name = "labelManufacter";
            this.labelManufacter.Size = new System.Drawing.Size(208, 27);
            this.labelManufacter.TabIndex = 14;
            this.labelManufacter.Text = "Производитель:";
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormat.Location = new System.Drawing.Point(10, 88);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(110, 27);
            this.labelFormat.TabIndex = 15;
            this.labelFormat.Text = "Формат:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre.Location = new System.Drawing.Point(10, 158);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(82, 27);
            this.labelGenre.TabIndex = 17;
            this.labelGenre.Text = "Жанр:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(3, 29);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(68, 27);
            this.labelType.TabIndex = 19;
            this.labelType.Text = "Тип:";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUnitPrice.Location = new System.Drawing.Point(3, 99);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(236, 27);
            this.labelUnitPrice.TabIndex = 21;
            this.labelUnitPrice.Text = "Цена за единицу:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTitle.Location = new System.Drawing.Point(158, 100);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(178, 52);
            this.labelTitle.TabIndex = 24;
            this.labelTitle.Text = "Альбомы";
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.labelManufacter);
            this.panelAdd.Controls.Add(this.ComboBoxFormat);
            this.panelAdd.Controls.Add(this.TextBoxManufacter);
            this.panelAdd.Controls.Add(this.labelFormat);
            this.panelAdd.Controls.Add(this.ComboBoxGenre);
            this.panelAdd.Controls.Add(this.labelGenre);
            this.panelAdd.Location = new System.Drawing.Point(56, 409);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(491, 207);
            this.panelAdd.TabIndex = 25;
            this.panelAdd.Visible = false;
            // 
            // ComboBoxFormat
            // 
            this.ComboBoxFormat.BackColor = System.Drawing.Color.White;
            this.ComboBoxFormat.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ComboBoxFormat.BorderSize = 2;
            this.ComboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFormat.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxFormat.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxFormat.IconColor = System.Drawing.Color.DarkSlateGray;
            this.ComboBoxFormat.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxFormat.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxFormat.Location = new System.Drawing.Point(127, 77);
            this.ComboBoxFormat.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxFormat.Name = "ComboBoxFormat";
            this.ComboBoxFormat.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxFormat.Size = new System.Drawing.Size(200, 38);
            this.ComboBoxFormat.TabIndex = 7;
            this.ComboBoxFormat.Texts = "";
            this.ComboBoxFormat.OnSelectedIndexChanged += new System.EventHandler(this.ComboBox_OnSelectedIndexChanged);
            // 
            // TextBoxManufacter
            // 
            this.TextBoxManufacter.BackColor = System.Drawing.Color.Snow;
            this.TextBoxManufacter.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.TextBoxManufacter.BorderFocusColor = System.Drawing.Color.Indigo;
            this.TextBoxManufacter.BorderRadius = 0;
            this.TextBoxManufacter.BorderSize = 2;
            this.TextBoxManufacter.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxManufacter.ForeColor = System.Drawing.Color.Black;
            this.TextBoxManufacter.Location = new System.Drawing.Point(224, 8);
            this.TextBoxManufacter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxManufacter.MaxLength = 32767;
            this.TextBoxManufacter.MinLength = 0;
            this.TextBoxManufacter.Multiline = false;
            this.TextBoxManufacter.Name = "TextBoxManufacter";
            this.TextBoxManufacter.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxManufacter.PasswordChar = false;
            this.TextBoxManufacter.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxManufacter.PlaceholderText = "";
            this.TextBoxManufacter.Size = new System.Drawing.Size(189, 37);
            this.TextBoxManufacter.TabIndex = 13;
            this.TextBoxManufacter.Texts = "";
            this.TextBoxManufacter.UnderlinedStyle = true;
            this.TextBoxManufacter._TextChanged += new System.EventHandler(this.TextBox1__TextChanged);
            this.TextBoxManufacter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // ComboBoxGenre
            // 
            this.ComboBoxGenre.BackColor = System.Drawing.Color.White;
            this.ComboBoxGenre.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ComboBoxGenre.BorderSize = 2;
            this.ComboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGenre.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxGenre.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxGenre.IconColor = System.Drawing.Color.DarkSlateGray;
            this.ComboBoxGenre.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxGenre.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxGenre.Location = new System.Drawing.Point(98, 147);
            this.ComboBoxGenre.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxGenre.Name = "ComboBoxGenre";
            this.ComboBoxGenre.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxGenre.Size = new System.Drawing.Size(282, 38);
            this.ComboBoxGenre.TabIndex = 16;
            this.ComboBoxGenre.Texts = "";
            this.ComboBoxGenre.DropDownClosed += new System.EventHandler(this.ComboBoxGenre_DropDownClosed);
            this.ComboBoxGenre.Leave += new System.EventHandler(this.ComboBoxGenre_Leave);
            // 
            // panelAdd2
            // 
            this.panelAdd2.Controls.Add(this.labelType);
            this.panelAdd2.Controls.Add(this.ComboBoxType);
            this.panelAdd2.Controls.Add(this.TextBoxUnitPrice);
            this.panelAdd2.Controls.Add(this.labelUnitPrice);
            this.panelAdd2.Location = new System.Drawing.Point(56, 611);
            this.panelAdd2.Name = "panelAdd2";
            this.panelAdd2.Size = new System.Drawing.Size(491, 154);
            this.panelAdd2.TabIndex = 26;
            this.panelAdd2.Visible = false;
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.BackColor = System.Drawing.Color.White;
            this.ComboBoxType.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ComboBoxType.BorderSize = 2;
            this.ComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxType.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxType.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxType.IconColor = System.Drawing.Color.DarkSlateGray;
            this.ComboBoxType.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxType.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxType.Location = new System.Drawing.Point(77, 18);
            this.ComboBoxType.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxType.Size = new System.Drawing.Size(223, 38);
            this.ComboBoxType.TabIndex = 18;
            this.ComboBoxType.Texts = "";
            this.ComboBoxType.OnSelectedIndexChanged += new System.EventHandler(this.ComboBox_OnSelectedIndexChanged);
            // 
            // TextBoxUnitPrice
            // 
            this.TextBoxUnitPrice.BackColor = System.Drawing.Color.Snow;
            this.TextBoxUnitPrice.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.TextBoxUnitPrice.BorderFocusColor = System.Drawing.Color.Indigo;
            this.TextBoxUnitPrice.BorderRadius = 0;
            this.TextBoxUnitPrice.BorderSize = 2;
            this.TextBoxUnitPrice.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.TextBoxUnitPrice.Location = new System.Drawing.Point(245, 89);
            this.TextBoxUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxUnitPrice.MaxLength = 32767;
            this.TextBoxUnitPrice.MinLength = 0;
            this.TextBoxUnitPrice.Multiline = false;
            this.TextBoxUnitPrice.Name = "TextBoxUnitPrice";
            this.TextBoxUnitPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxUnitPrice.PasswordChar = false;
            this.TextBoxUnitPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxUnitPrice.PlaceholderText = "";
            this.TextBoxUnitPrice.Size = new System.Drawing.Size(174, 37);
            this.TextBoxUnitPrice.TabIndex = 20;
            this.TextBoxUnitPrice.Texts = "";
            this.TextBoxUnitPrice.UnderlinedStyle = true;
            this.TextBoxUnitPrice._TextChanged += new System.EventHandler(this.TextBox1__TextChanged);
            this.TextBoxUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPrice_KeyPress);
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
            this.ButtonClear.Location = new System.Drawing.Point(66, 780);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(161, 61);
            this.ButtonClear.TabIndex = 57;
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
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(518, 780);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(161, 61);
            this.ButtonAdd.TabIndex = 22;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.TextColor = System.Drawing.Color.White;
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TextBoxArtist
            // 
            this.TextBoxArtist.BackColor = System.Drawing.Color.Snow;
            this.TextBoxArtist.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.TextBoxArtist.BorderFocusColor = System.Drawing.Color.Indigo;
            this.TextBoxArtist.BorderRadius = 0;
            this.TextBoxArtist.BorderSize = 2;
            this.TextBoxArtist.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxArtist.ForeColor = System.Drawing.Color.Black;
            this.TextBoxArtist.Location = new System.Drawing.Point(247, 346);
            this.TextBoxArtist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxArtist.MaxLength = 32767;
            this.TextBoxArtist.MinLength = 0;
            this.TextBoxArtist.Multiline = false;
            this.TextBoxArtist.Name = "TextBoxArtist";
            this.TextBoxArtist.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxArtist.PasswordChar = false;
            this.TextBoxArtist.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxArtist.PlaceholderText = "";
            this.TextBoxArtist.Size = new System.Drawing.Size(213, 37);
            this.TextBoxArtist.TabIndex = 9;
            this.TextBoxArtist.Texts = "";
            this.TextBoxArtist.UnderlinedStyle = true;
            this.TextBoxArtist._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            this.TextBoxArtist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TextBoxArtist.Leave += new System.EventHandler(this.TextBoxArtist_Leave);
            // 
            // TextBoxAlbumName
            // 
            this.TextBoxAlbumName.BackColor = System.Drawing.Color.Snow;
            this.TextBoxAlbumName.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.TextBoxAlbumName.BorderFocusColor = System.Drawing.Color.Indigo;
            this.TextBoxAlbumName.BorderRadius = 0;
            this.TextBoxAlbumName.BorderSize = 2;
            this.TextBoxAlbumName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAlbumName.ForeColor = System.Drawing.Color.Black;
            this.TextBoxAlbumName.Location = new System.Drawing.Point(320, 211);
            this.TextBoxAlbumName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxAlbumName.MaxLength = 32767;
            this.TextBoxAlbumName.MinLength = 0;
            this.TextBoxAlbumName.Multiline = false;
            this.TextBoxAlbumName.Name = "TextBoxAlbumName";
            this.TextBoxAlbumName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxAlbumName.PasswordChar = false;
            this.TextBoxAlbumName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxAlbumName.PlaceholderText = "";
            this.TextBoxAlbumName.Size = new System.Drawing.Size(237, 37);
            this.TextBoxAlbumName.TabIndex = 6;
            this.TextBoxAlbumName.Texts = "";
            this.TextBoxAlbumName.UnderlinedStyle = true;
            this.TextBoxAlbumName._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            this.TextBoxAlbumName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // AddAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(717, 881);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.panelAdd2);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.labeArtist);
            this.Controls.Add(this.maskedTextBoxDataRelease);
            this.Controls.Add(this.labelDataRelease);
            this.Controls.Add(this.TextBoxArtist);
            this.Controls.Add(this.labelAlbumName);
            this.Controls.Add(this.TextBoxAlbumName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAlbumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAlbumForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelAdd2.ResumeLayout(false);
            this.panelAdd2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJTextBox TextBoxAlbumName;
        private RJComboBox ComboBoxFormat;
        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.Label labelDataRelease;
        private RJTextBox TextBoxArtist;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataRelease;
        private System.Windows.Forms.Label labeArtist;
        private System.Windows.Forms.Label labelManufacter;
        private RJTextBox TextBoxManufacter;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.Label labelGenre;
        private RJComboBox ComboBoxGenre;
        private System.Windows.Forms.Label labelType;
        private RJComboBox ComboBoxType;
        private System.Windows.Forms.Label labelUnitPrice;
        private RJTextBox TextBoxUnitPrice;
        private RJButton ButtonAdd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panelAdd2;
        private RJButton ButtonClear;
    }
}