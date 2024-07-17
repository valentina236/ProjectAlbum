namespace DatabaseAlbum
{
    partial class EditAlbumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAlbumForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelFormat = new System.Windows.Forms.Label();
            this.labelManufacter = new System.Windows.Forms.Label();
            this.labeArtist = new System.Windows.Forms.Label();
            this.maskedTextBoxDataRelease = new System.Windows.Forms.MaskedTextBox();
            this.labelDataRelease = new System.Windows.Forms.Label();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panelAlbumName = new System.Windows.Forms.Panel();
            this.TextBoxAlbumName = new DatabaseAlbum.RJTextBox();
            this.radioButtonAlbumName = new System.Windows.Forms.RadioButton();
            this.radioButtonDateRelease = new System.Windows.Forms.RadioButton();
            this.panelDateRelease = new System.Windows.Forms.Panel();
            this.radioButtonArtist = new System.Windows.Forms.RadioButton();
            this.panelArtist = new System.Windows.Forms.Panel();
            this.TextBoxArtist = new DatabaseAlbum.RJTextBox();
            this.panelProvider = new System.Windows.Forms.Panel();
            this.TextBoxManufacter = new DatabaseAlbum.RJTextBox();
            this.panelFormat = new System.Windows.Forms.Panel();
            this.ComboBoxFormat = new DatabaseAlbum.RJComboBox();
            this.radioButtonpProvider = new System.Windows.Forms.RadioButton();
            this.radioButtonFormat = new System.Windows.Forms.RadioButton();
            this.ButtonEdit = new DatabaseAlbum.RJButton();
            this.TextBoxUnitPrice = new DatabaseAlbum.RJTextBox();
            this.ComboBoxType = new DatabaseAlbum.RJComboBox();
            this.ComboBoxGenre = new DatabaseAlbum.RJComboBox();
            this.panelGnre = new System.Windows.Forms.Panel();
            this.panelAlbumType = new System.Windows.Forms.Panel();
            this.radioButtonGenre = new System.Windows.Forms.RadioButton();
            this.radioButtonType = new System.Windows.Forms.RadioButton();
            this.radioButtonPrice = new System.Windows.Forms.RadioButton();
            this.panelPrice = new System.Windows.Forms.Panel();
            this.ButtonClear = new DatabaseAlbum.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panelAlbumName.SuspendLayout();
            this.panelDateRelease.SuspendLayout();
            this.panelArtist.SuspendLayout();
            this.panelProvider.SuspendLayout();
            this.panelFormat.SuspendLayout();
            this.panelGnre.SuspendLayout();
            this.panelAlbumType.SuspendLayout();
            this.panelPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTitle.Location = new System.Drawing.Point(196, 102);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(178, 52);
            this.labelTitle.TabIndex = 43;
            this.labelTitle.Text = "Альбомы";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(64, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelUnitPrice.Location = new System.Drawing.Point(30, 39);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(236, 27);
            this.labelUnitPrice.TabIndex = 40;
            this.labelUnitPrice.Text = "Цена за единицу:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelType.Location = new System.Drawing.Point(27, 37);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(68, 27);
            this.labelType.TabIndex = 38;
            this.labelType.Text = "Тип:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelGenre.Location = new System.Drawing.Point(28, 42);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(82, 27);
            this.labelGenre.TabIndex = 36;
            this.labelGenre.Text = "Жанр:";
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelFormat.Location = new System.Drawing.Point(28, 37);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(110, 27);
            this.labelFormat.TabIndex = 34;
            this.labelFormat.Text = "Формат:";
            // 
            // labelManufacter
            // 
            this.labelManufacter.AutoSize = true;
            this.labelManufacter.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelManufacter.Location = new System.Drawing.Point(28, 43);
            this.labelManufacter.Name = "labelManufacter";
            this.labelManufacter.Size = new System.Drawing.Size(208, 27);
            this.labelManufacter.TabIndex = 33;
            this.labelManufacter.Text = "Производитель:";
            // 
            // labeArtist
            // 
            this.labeArtist.AutoSize = true;
            this.labeArtist.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold);
            this.labeArtist.Location = new System.Drawing.Point(30, 31);
            this.labeArtist.Name = "labeArtist";
            this.labeArtist.Size = new System.Drawing.Size(180, 27);
            this.labeArtist.TabIndex = 31;
            this.labeArtist.Text = "Исполнитель:";
            // 
            // maskedTextBoxDataRelease
            // 
            this.maskedTextBoxDataRelease.BackColor = System.Drawing.Color.Snow;
            this.maskedTextBoxDataRelease.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxDataRelease.Location = new System.Drawing.Point(243, 33);
            this.maskedTextBoxDataRelease.Mask = "0000-00-00";
            this.maskedTextBoxDataRelease.Name = "maskedTextBoxDataRelease";
            this.maskedTextBoxDataRelease.Size = new System.Drawing.Size(172, 30);
            this.maskedTextBoxDataRelease.TabIndex = 30;
            this.maskedTextBoxDataRelease.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataRelease.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxDataRelease_Validating);
            // 
            // labelDataRelease
            // 
            this.labelDataRelease.AutoSize = true;
            this.labelDataRelease.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelDataRelease.Location = new System.Drawing.Point(12, 36);
            this.labelDataRelease.Name = "labelDataRelease";
            this.labelDataRelease.Size = new System.Drawing.Size(194, 27);
            this.labelDataRelease.TabIndex = 29;
            this.labelDataRelease.Text = "Дата выпуска:";
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelAlbumName.Location = new System.Drawing.Point(12, 43);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(250, 27);
            this.labelAlbumName.TabIndex = 27;
            this.labelAlbumName.Text = "Название альбома:";
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
            this.panel1.Size = new System.Drawing.Size(963, 47);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "Изменение информации";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(918, 0);
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
            // panelAlbumName
            // 
            this.panelAlbumName.Controls.Add(this.labelAlbumName);
            this.panelAlbumName.Controls.Add(this.TextBoxAlbumName);
            this.panelAlbumName.Location = new System.Drawing.Point(76, 493);
            this.panelAlbumName.Name = "panelAlbumName";
            this.panelAlbumName.Size = new System.Drawing.Size(707, 100);
            this.panelAlbumName.TabIndex = 45;
            this.panelAlbumName.Visible = false;
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
            this.TextBoxAlbumName.Location = new System.Drawing.Point(287, 33);
            this.TextBoxAlbumName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxAlbumName.MaxLength = 32767;
            this.TextBoxAlbumName.MinLength = 0;
            this.TextBoxAlbumName.Multiline = false;
            this.TextBoxAlbumName.Name = "TextBoxAlbumName";
            this.TextBoxAlbumName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxAlbumName.PasswordChar = false;
            this.TextBoxAlbumName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxAlbumName.PlaceholderText = "";
            this.TextBoxAlbumName.Size = new System.Drawing.Size(385, 37);
            this.TextBoxAlbumName.TabIndex = 25;
            this.TextBoxAlbumName.Texts = "";
            this.TextBoxAlbumName.UnderlinedStyle = true;
            this.TextBoxAlbumName._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            this.TextBoxAlbumName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // radioButtonAlbumName
            // 
            this.radioButtonAlbumName.AutoSize = true;
            this.radioButtonAlbumName.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAlbumName.Location = new System.Drawing.Point(76, 250);
            this.radioButtonAlbumName.Name = "radioButtonAlbumName";
            this.radioButtonAlbumName.Size = new System.Drawing.Size(330, 34);
            this.radioButtonAlbumName.TabIndex = 46;
            this.radioButtonAlbumName.TabStop = true;
            this.radioButtonAlbumName.Text = "Изменить название альбома";
            this.radioButtonAlbumName.UseVisualStyleBackColor = true;
            this.radioButtonAlbumName.CheckedChanged += new System.EventHandler(this.radioButtonAlbumName_CheckedChanged);
            // 
            // radioButtonDateRelease
            // 
            this.radioButtonDateRelease.AutoSize = true;
            this.radioButtonDateRelease.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDateRelease.Location = new System.Drawing.Point(76, 306);
            this.radioButtonDateRelease.Name = "radioButtonDateRelease";
            this.radioButtonDateRelease.Size = new System.Drawing.Size(280, 34);
            this.radioButtonDateRelease.TabIndex = 47;
            this.radioButtonDateRelease.TabStop = true;
            this.radioButtonDateRelease.Text = "Изменить дату выпуска";
            this.radioButtonDateRelease.UseVisualStyleBackColor = true;
            this.radioButtonDateRelease.CheckedChanged += new System.EventHandler(this.radioButtonDateRelease_CheckedChanged);
            // 
            // panelDateRelease
            // 
            this.panelDateRelease.Controls.Add(this.labelDataRelease);
            this.panelDateRelease.Controls.Add(this.maskedTextBoxDataRelease);
            this.panelDateRelease.Location = new System.Drawing.Point(76, 493);
            this.panelDateRelease.Name = "panelDateRelease";
            this.panelDateRelease.Size = new System.Drawing.Size(510, 100);
            this.panelDateRelease.TabIndex = 48;
            this.panelDateRelease.Visible = false;
            // 
            // radioButtonArtist
            // 
            this.radioButtonArtist.AutoSize = true;
            this.radioButtonArtist.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonArtist.Location = new System.Drawing.Point(77, 358);
            this.radioButtonArtist.Name = "radioButtonArtist";
            this.radioButtonArtist.Size = new System.Drawing.Size(329, 34);
            this.radioButtonArtist.TabIndex = 49;
            this.radioButtonArtist.TabStop = true;
            this.radioButtonArtist.Text = "Изменить имя исполнителя";
            this.radioButtonArtist.UseVisualStyleBackColor = true;
            this.radioButtonArtist.CheckedChanged += new System.EventHandler(this.radioButtonArtist_CheckedChanged);
            // 
            // panelArtist
            // 
            this.panelArtist.Controls.Add(this.labeArtist);
            this.panelArtist.Controls.Add(this.TextBoxArtist);
            this.panelArtist.Location = new System.Drawing.Point(76, 493);
            this.panelArtist.Name = "panelArtist";
            this.panelArtist.Size = new System.Drawing.Size(510, 100);
            this.panelArtist.TabIndex = 50;
            this.panelArtist.Visible = false;
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
            this.TextBoxArtist.Location = new System.Drawing.Point(231, 21);
            this.TextBoxArtist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxArtist.MaxLength = 32767;
            this.TextBoxArtist.MinLength = 0;
            this.TextBoxArtist.Multiline = false;
            this.TextBoxArtist.Name = "TextBoxArtist";
            this.TextBoxArtist.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxArtist.PasswordChar = false;
            this.TextBoxArtist.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxArtist.PlaceholderText = "";
            this.TextBoxArtist.Size = new System.Drawing.Size(235, 37);
            this.TextBoxArtist.TabIndex = 28;
            this.TextBoxArtist.Texts = "";
            this.TextBoxArtist.UnderlinedStyle = true;
            this.TextBoxArtist._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            this.TextBoxArtist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // panelProvider
            // 
            this.panelProvider.Controls.Add(this.labelManufacter);
            this.panelProvider.Controls.Add(this.TextBoxManufacter);
            this.panelProvider.Location = new System.Drawing.Point(74, 493);
            this.panelProvider.Name = "panelProvider";
            this.panelProvider.Size = new System.Drawing.Size(706, 100);
            this.panelProvider.TabIndex = 51;
            this.panelProvider.Visible = false;
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
            this.TextBoxManufacter.Location = new System.Drawing.Point(260, 33);
            this.TextBoxManufacter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxManufacter.MaxLength = 32767;
            this.TextBoxManufacter.MinLength = 0;
            this.TextBoxManufacter.Multiline = false;
            this.TextBoxManufacter.Name = "TextBoxManufacter";
            this.TextBoxManufacter.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxManufacter.PasswordChar = false;
            this.TextBoxManufacter.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxManufacter.PlaceholderText = "";
            this.TextBoxManufacter.Size = new System.Drawing.Size(337, 37);
            this.TextBoxManufacter.TabIndex = 32;
            this.TextBoxManufacter.Texts = "";
            this.TextBoxManufacter.UnderlinedStyle = true;
            this.TextBoxManufacter._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            this.TextBoxManufacter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // panelFormat
            // 
            this.panelFormat.Controls.Add(this.ComboBoxFormat);
            this.panelFormat.Controls.Add(this.labelFormat);
            this.panelFormat.Location = new System.Drawing.Point(74, 493);
            this.panelFormat.Name = "panelFormat";
            this.panelFormat.Size = new System.Drawing.Size(468, 100);
            this.panelFormat.TabIndex = 53;
            this.panelFormat.Visible = false;
            // 
            // ComboBoxFormat
            // 
            this.ComboBoxFormat.BackColor = System.Drawing.Color.White;
            this.ComboBoxFormat.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ComboBoxFormat.BorderSize = 2;
            this.ComboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ComboBoxFormat.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxFormat.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxFormat.IconColor = System.Drawing.Color.DarkSlateGray;
            this.ComboBoxFormat.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxFormat.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxFormat.Location = new System.Drawing.Point(179, 35);
            this.ComboBoxFormat.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxFormat.Name = "ComboBoxFormat";
            this.ComboBoxFormat.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxFormat.Size = new System.Drawing.Size(200, 38);
            this.ComboBoxFormat.TabIndex = 26;
            this.ComboBoxFormat.Texts = "";
            this.ComboBoxFormat.OnSelectedIndexChanged += new System.EventHandler(this.ComboBox_OnSelectedIndexChanged);
            // 
            // radioButtonpProvider
            // 
            this.radioButtonpProvider.AutoSize = true;
            this.radioButtonpProvider.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonpProvider.Location = new System.Drawing.Point(75, 410);
            this.radioButtonpProvider.Name = "radioButtonpProvider";
            this.radioButtonpProvider.Size = new System.Drawing.Size(303, 34);
            this.radioButtonpProvider.TabIndex = 51;
            this.radioButtonpProvider.TabStop = true;
            this.radioButtonpProvider.Text = "Изменить производителя";
            this.radioButtonpProvider.UseVisualStyleBackColor = true;
            this.radioButtonpProvider.CheckedChanged += new System.EventHandler(this.radioButtonpProvider_CheckedChanged);
            // 
            // radioButtonFormat
            // 
            this.radioButtonFormat.AutoSize = true;
            this.radioButtonFormat.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonFormat.Location = new System.Drawing.Point(558, 250);
            this.radioButtonFormat.Name = "radioButtonFormat";
            this.radioButtonFormat.Size = new System.Drawing.Size(222, 34);
            this.radioButtonFormat.TabIndex = 52;
            this.radioButtonFormat.TabStop = true;
            this.radioButtonFormat.Text = "Изменить формат";
            this.radioButtonFormat.UseVisualStyleBackColor = true;
            this.radioButtonFormat.CheckedChanged += new System.EventHandler(this.radioButtonFormat_CheckedChanged);
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
            this.ButtonEdit.Location = new System.Drawing.Point(277, 643);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(161, 61);
            this.ButtonEdit.TabIndex = 41;
            this.ButtonEdit.Text = "Изменить";
            this.ButtonEdit.TextColor = System.Drawing.Color.White;
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
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
            this.TextBoxUnitPrice.Location = new System.Drawing.Point(284, 32);
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
            this.TextBoxUnitPrice.TabIndex = 39;
            this.TextBoxUnitPrice.Texts = "";
            this.TextBoxUnitPrice.UnderlinedStyle = true;
            this.TextBoxUnitPrice._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            this.TextBoxUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPrice_KeyPress);
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.BackColor = System.Drawing.Color.White;
            this.ComboBoxType.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ComboBoxType.BorderSize = 2;
            this.ComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ComboBoxType.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxType.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxType.IconColor = System.Drawing.Color.DarkSlateGray;
            this.ComboBoxType.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxType.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxType.Location = new System.Drawing.Point(143, 35);
            this.ComboBoxType.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxType.Size = new System.Drawing.Size(223, 38);
            this.ComboBoxType.TabIndex = 37;
            this.ComboBoxType.Texts = "";
            this.ComboBoxType.OnSelectedIndexChanged += new System.EventHandler(this.ComboBox_OnSelectedIndexChanged);
            // 
            // ComboBoxGenre
            // 
            this.ComboBoxGenre.BackColor = System.Drawing.Color.White;
            this.ComboBoxGenre.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ComboBoxGenre.BorderSize = 2;
            this.ComboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ComboBoxGenre.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxGenre.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxGenre.IconColor = System.Drawing.Color.DarkSlateGray;
            this.ComboBoxGenre.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxGenre.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxGenre.Location = new System.Drawing.Point(144, 40);
            this.ComboBoxGenre.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxGenre.Name = "ComboBoxGenre";
            this.ComboBoxGenre.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxGenre.Size = new System.Drawing.Size(282, 38);
            this.ComboBoxGenre.TabIndex = 35;
            this.ComboBoxGenre.Texts = "";
            this.ComboBoxGenre.OnSelectedIndexChanged += new System.EventHandler(this.ComboBox_OnSelectedIndexChanged);
            // 
            // panelGnre
            // 
            this.panelGnre.Controls.Add(this.labelGenre);
            this.panelGnre.Controls.Add(this.ComboBoxGenre);
            this.panelGnre.Location = new System.Drawing.Point(74, 493);
            this.panelGnre.Name = "panelGnre";
            this.panelGnre.Size = new System.Drawing.Size(496, 100);
            this.panelGnre.TabIndex = 53;
            this.panelGnre.Visible = false;
            // 
            // panelAlbumType
            // 
            this.panelAlbumType.Controls.Add(this.labelType);
            this.panelAlbumType.Controls.Add(this.ComboBoxType);
            this.panelAlbumType.Location = new System.Drawing.Point(72, 493);
            this.panelAlbumType.Name = "panelAlbumType";
            this.panelAlbumType.Size = new System.Drawing.Size(495, 100);
            this.panelAlbumType.TabIndex = 56;
            this.panelAlbumType.Visible = false;
            // 
            // radioButtonGenre
            // 
            this.radioButtonGenre.AutoSize = true;
            this.radioButtonGenre.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonGenre.Location = new System.Drawing.Point(558, 306);
            this.radioButtonGenre.Name = "radioButtonGenre";
            this.radioButtonGenre.Size = new System.Drawing.Size(192, 34);
            this.radioButtonGenre.TabIndex = 54;
            this.radioButtonGenre.TabStop = true;
            this.radioButtonGenre.Text = "Изменить жанр";
            this.radioButtonGenre.UseVisualStyleBackColor = true;
            this.radioButtonGenre.CheckedChanged += new System.EventHandler(this.radioButtonGenre_CheckedChanged);
            // 
            // radioButtonType
            // 
            this.radioButtonType.AutoSize = true;
            this.radioButtonType.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonType.Location = new System.Drawing.Point(558, 358);
            this.radioButtonType.Name = "radioButtonType";
            this.radioButtonType.Size = new System.Drawing.Size(275, 34);
            this.radioButtonType.TabIndex = 55;
            this.radioButtonType.TabStop = true;
            this.radioButtonType.Text = "Изменить тип альбома";
            this.radioButtonType.UseVisualStyleBackColor = true;
            this.radioButtonType.CheckedChanged += new System.EventHandler(this.radioButtonType_CheckedChanged);
            // 
            // radioButtonPrice
            // 
            this.radioButtonPrice.AutoSize = true;
            this.radioButtonPrice.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPrice.Location = new System.Drawing.Point(558, 410);
            this.radioButtonPrice.Name = "radioButtonPrice";
            this.radioButtonPrice.Size = new System.Drawing.Size(316, 34);
            this.radioButtonPrice.TabIndex = 56;
            this.radioButtonPrice.TabStop = true;
            this.radioButtonPrice.Text = "Изменить цену за единицу";
            this.radioButtonPrice.UseVisualStyleBackColor = true;
            this.radioButtonPrice.CheckedChanged += new System.EventHandler(this.radioButtonPrice_CheckedChanged);
            // 
            // panelPrice
            // 
            this.panelPrice.Controls.Add(this.labelUnitPrice);
            this.panelPrice.Controls.Add(this.TextBoxUnitPrice);
            this.panelPrice.Location = new System.Drawing.Point(72, 490);
            this.panelPrice.Name = "panelPrice";
            this.panelPrice.Size = new System.Drawing.Size(494, 100);
            this.panelPrice.TabIndex = 57;
            this.panelPrice.Visible = false;
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
            this.ButtonClear.Location = new System.Drawing.Point(78, 643);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(161, 61);
            this.ButtonClear.TabIndex = 58;
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.TextColor = System.Drawing.Color.White;
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // EditAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(963, 730);
            this.Controls.Add(this.panelPrice);
            this.Controls.Add(this.panelAlbumType);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.radioButtonPrice);
            this.Controls.Add(this.radioButtonType);
            this.Controls.Add(this.panelGnre);
            this.Controls.Add(this.panelFormat);
            this.Controls.Add(this.radioButtonGenre);
            this.Controls.Add(this.panelProvider);
            this.Controls.Add(this.radioButtonFormat);
            this.Controls.Add(this.radioButtonpProvider);
            this.Controls.Add(this.panelArtist);
            this.Controls.Add(this.radioButtonArtist);
            this.Controls.Add(this.panelDateRelease);
            this.Controls.Add(this.radioButtonDateRelease);
            this.Controls.Add(this.radioButtonAlbumName);
            this.Controls.Add(this.panelAlbumName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ButtonEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditAlbumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditAlbumForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panelAlbumName.ResumeLayout(false);
            this.panelAlbumName.PerformLayout();
            this.panelDateRelease.ResumeLayout(false);
            this.panelDateRelease.PerformLayout();
            this.panelArtist.ResumeLayout(false);
            this.panelArtist.PerformLayout();
            this.panelProvider.ResumeLayout(false);
            this.panelProvider.PerformLayout();
            this.panelFormat.ResumeLayout(false);
            this.panelFormat.PerformLayout();
            this.panelGnre.ResumeLayout(false);
            this.panelGnre.PerformLayout();
            this.panelAlbumType.ResumeLayout(false);
            this.panelAlbumType.PerformLayout();
            this.panelPrice.ResumeLayout(false);
            this.panelPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJButton ButtonEdit;
        private System.Windows.Forms.Label labelUnitPrice;
        private RJTextBox TextBoxUnitPrice;
        private System.Windows.Forms.Label labelType;
        private RJComboBox ComboBoxType;
        private System.Windows.Forms.Label labelGenre;
        private RJComboBox ComboBoxGenre;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.Label labelManufacter;
        private RJTextBox TextBoxManufacter;
        private System.Windows.Forms.Label labeArtist;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataRelease;
        private System.Windows.Forms.Label labelDataRelease;
        private RJTextBox TextBoxArtist;
        private System.Windows.Forms.Label labelAlbumName;
        private RJComboBox ComboBoxFormat;
        private RJTextBox TextBoxAlbumName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Panel panelAlbumName;
        private System.Windows.Forms.RadioButton radioButtonAlbumName;
        private System.Windows.Forms.RadioButton radioButtonDateRelease;
        private System.Windows.Forms.Panel panelDateRelease;
        private System.Windows.Forms.RadioButton radioButtonArtist;
        private System.Windows.Forms.Panel panelArtist;
        private System.Windows.Forms.Panel panelProvider;
        private System.Windows.Forms.RadioButton radioButtonpProvider;
        private System.Windows.Forms.RadioButton radioButtonFormat;
        private System.Windows.Forms.Panel panelFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGnre;
        private System.Windows.Forms.RadioButton radioButtonGenre;
        private System.Windows.Forms.Panel panelAlbumType;
        private System.Windows.Forms.RadioButton radioButtonType;
        private System.Windows.Forms.RadioButton radioButtonPrice;
        private System.Windows.Forms.Panel panelPrice;
        private RJButton ButtonClear;
    }
}