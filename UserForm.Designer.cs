namespace DatabaseAlbum
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonAlbum = new DatabaseAlbum.RJButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBoxFilter = new System.Windows.Forms.PictureBox();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.ButtonFilterClose = new DatabaseAlbum.RJButton();
            this.ButtonClear = new DatabaseAlbum.RJButton();
            this.TextBoxPrice2 = new DatabaseAlbum.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxPrice1 = new DatabaseAlbum.RJTextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.ComboBoxType = new DatabaseAlbum.RJComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.ComboBoxGenre = new DatabaseAlbum.RJComboBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.ComboBoxFormat = new DatabaseAlbum.RJComboBox();
            this.labelFormat = new System.Windows.Forms.Label();
            this.ComboBoxManufacter = new DatabaseAlbum.RJComboBox();
            this.labelManufacter = new System.Windows.Forms.Label();
            this.ComboBoxArtist = new DatabaseAlbum.RJComboBox();
            this.labelArtist = new System.Windows.Forms.Label();
            this.ComboBoxAlbum = new DatabaseAlbum.RJComboBox();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhotoFiltr = new System.Windows.Forms.PictureBox();
            this.labelTitleFltr = new System.Windows.Forms.Label();
            this.ButtonSearch = new DatabaseAlbum.RJButton();
            this.TextBoxSearch = new DatabaseAlbum.RJTextBox();
            this.pictureBoxWelcome = new System.Windows.Forms.PictureBox();
            this.ButtonHelp = new DatabaseAlbum.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilter)).BeginInit();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoFiltr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1901, 47);
            this.panel1.TabIndex = 5;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(1852, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(49, 47);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxExit.TabIndex = 6;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.ButtonAlbum);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 850);
            this.panel2.TabIndex = 6;
            // 
            // ButtonAlbum
            // 
            this.ButtonAlbum.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAlbum.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonAlbum.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonAlbum.BorderRadius = 30;
            this.ButtonAlbum.BorderSize = 0;
            this.ButtonAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAlbum.FlatAppearance.BorderSize = 0;
            this.ButtonAlbum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonAlbum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAlbum.Font = new System.Drawing.Font("Bookman Old Style", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAlbum.ForeColor = System.Drawing.Color.Black;
            this.ButtonAlbum.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAlbum.Image")));
            this.ButtonAlbum.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonAlbum.Location = new System.Drawing.Point(3, 186);
            this.ButtonAlbum.Name = "ButtonAlbum";
            this.ButtonAlbum.Size = new System.Drawing.Size(326, 108);
            this.ButtonAlbum.TabIndex = 9;
            this.ButtonAlbum.Text = "Альбомы";
            this.ButtonAlbum.TextColor = System.Drawing.Color.Black;
            this.ButtonAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAlbum.UseVisualStyleBackColor = false;
            this.ButtonAlbum.Click += new System.EventHandler(this.ButtonAlbum_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(332, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(140, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 82);
            this.label1.TabIndex = 7;
            this.label1.Text = "Магазин \r\nальбомов";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(231)))), ((int)(((byte)(241)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(385, 265);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1483, 565);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.Visible = false;
            // 
            // pictureBoxFilter
            // 
            this.pictureBoxFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFilter.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFilter.Image")));
            this.pictureBoxFilter.Location = new System.Drawing.Point(1798, 187);
            this.pictureBoxFilter.Name = "pictureBoxFilter";
            this.pictureBoxFilter.Size = new System.Drawing.Size(70, 56);
            this.pictureBoxFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFilter.TabIndex = 12;
            this.pictureBoxFilter.TabStop = false;
            this.pictureBoxFilter.Visible = false;
            this.pictureBoxFilter.Click += new System.EventHandler(this.pictureBoxFilter_Click);
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.SystemColors.Control;
            this.panelFilter.Controls.Add(this.ButtonFilterClose);
            this.panelFilter.Controls.Add(this.ButtonClear);
            this.panelFilter.Controls.Add(this.TextBoxPrice2);
            this.panelFilter.Controls.Add(this.label6);
            this.panelFilter.Controls.Add(this.TextBoxPrice1);
            this.panelFilter.Controls.Add(this.labelPrice);
            this.panelFilter.Controls.Add(this.ComboBoxType);
            this.panelFilter.Controls.Add(this.labelType);
            this.panelFilter.Controls.Add(this.ComboBoxGenre);
            this.panelFilter.Controls.Add(this.labelGenre);
            this.panelFilter.Controls.Add(this.ComboBoxFormat);
            this.panelFilter.Controls.Add(this.labelFormat);
            this.panelFilter.Controls.Add(this.ComboBoxManufacter);
            this.panelFilter.Controls.Add(this.labelManufacter);
            this.panelFilter.Controls.Add(this.ComboBoxArtist);
            this.panelFilter.Controls.Add(this.labelArtist);
            this.panelFilter.Controls.Add(this.ComboBoxAlbum);
            this.panelFilter.Controls.Add(this.labelAlbumName);
            this.panelFilter.Controls.Add(this.pictureBox3);
            this.panelFilter.Controls.Add(this.pictureBoxPhotoFiltr);
            this.panelFilter.Controls.Add(this.labelTitleFltr);
            this.panelFilter.Location = new System.Drawing.Point(0, 47);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(347, 850);
            this.panelFilter.TabIndex = 15;
            this.panelFilter.Visible = false;
            // 
            // ButtonFilterClose
            // 
            this.ButtonFilterClose.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFilterClose.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonFilterClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonFilterClose.BorderRadius = 0;
            this.ButtonFilterClose.BorderSize = 0;
            this.ButtonFilterClose.FlatAppearance.BorderSize = 0;
            this.ButtonFilterClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFilterClose.ForeColor = System.Drawing.Color.White;
            this.ButtonFilterClose.Image = ((System.Drawing.Image)(resources.GetObject("ButtonFilterClose.Image")));
            this.ButtonFilterClose.Location = new System.Drawing.Point(261, 775);
            this.ButtonFilterClose.Name = "ButtonFilterClose";
            this.ButtonFilterClose.Size = new System.Drawing.Size(53, 58);
            this.ButtonFilterClose.TabIndex = 60;
            this.ButtonFilterClose.TextColor = System.Drawing.Color.White;
            this.ButtonFilterClose.UseVisualStyleBackColor = false;
            this.ButtonFilterClose.Click += new System.EventHandler(this.ButtonFilterClose_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClear.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonClear.BorderRadius = 0;
            this.ButtonClear.BorderSize = 0;
            this.ButtonClear.FlatAppearance.BorderSize = 0;
            this.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClear.ForeColor = System.Drawing.Color.White;
            this.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("ButtonClear.Image")));
            this.ButtonClear.Location = new System.Drawing.Point(26, 775);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(53, 58);
            this.ButtonClear.TabIndex = 59;
            this.ButtonClear.TextColor = System.Drawing.Color.White;
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // TextBoxPrice2
            // 
            this.TextBoxPrice2.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxPrice2.BorderColor = System.Drawing.Color.SteelBlue;
            this.TextBoxPrice2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxPrice2.BorderRadius = 0;
            this.TextBoxPrice2.BorderSize = 2;
            this.TextBoxPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPrice2.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPrice2.Location = new System.Drawing.Point(190, 722);
            this.TextBoxPrice2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxPrice2.MaxLength = 32767;
            this.TextBoxPrice2.MinLength = 0;
            this.TextBoxPrice2.Multiline = false;
            this.TextBoxPrice2.Name = "TextBoxPrice2";
            this.TextBoxPrice2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxPrice2.PasswordChar = false;
            this.TextBoxPrice2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxPrice2.PlaceholderText = "";
            this.TextBoxPrice2.Size = new System.Drawing.Size(108, 35);
            this.TextBoxPrice2.TabIndex = 58;
            this.TextBoxPrice2.Texts = "";
            this.TextBoxPrice2.UnderlinedStyle = true;
            this.TextBoxPrice2._TextChanged += new System.EventHandler(this.TextBoxPrice__TextChanged);
            this.TextBoxPrice2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPrice_KeyPress);
            this.TextBoxPrice2.Leave += new System.EventHandler(this.TextBoxPrice_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(133, 720);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 38);
            this.label6.TabIndex = 57;
            this.label6.Text = " - ";
            // 
            // TextBoxPrice1
            // 
            this.TextBoxPrice1.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxPrice1.BorderColor = System.Drawing.Color.SteelBlue;
            this.TextBoxPrice1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxPrice1.BorderRadius = 0;
            this.TextBoxPrice1.BorderSize = 2;
            this.TextBoxPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPrice1.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPrice1.Location = new System.Drawing.Point(26, 722);
            this.TextBoxPrice1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxPrice1.MaxLength = 32767;
            this.TextBoxPrice1.MinLength = 0;
            this.TextBoxPrice1.Multiline = false;
            this.TextBoxPrice1.Name = "TextBoxPrice1";
            this.TextBoxPrice1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxPrice1.PasswordChar = false;
            this.TextBoxPrice1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxPrice1.PlaceholderText = "";
            this.TextBoxPrice1.Size = new System.Drawing.Size(108, 35);
            this.TextBoxPrice1.TabIndex = 13;
            this.TextBoxPrice1.Texts = "";
            this.TextBoxPrice1.UnderlinedStyle = true;
            this.TextBoxPrice1._TextChanged += new System.EventHandler(this.TextBoxPrice__TextChanged);
            this.TextBoxPrice1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPrice_KeyPress);
            this.TextBoxPrice1.Leave += new System.EventHandler(this.TextBoxPrice_Leave);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(22, 689);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(67, 23);
            this.labelPrice.TabIndex = 46;
            this.labelPrice.Text = "Цена:";
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxType.BackColor = System.Drawing.Color.White;
            this.ComboBoxType.BorderColor = System.Drawing.Color.SteelBlue;
            this.ComboBoxType.BorderSize = 2;
            this.ComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxType.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxType.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxType.IconColor = System.Drawing.Color.SteelBlue;
            this.ComboBoxType.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxType.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxType.Location = new System.Drawing.Point(21, 633);
            this.ComboBoxType.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxType.Size = new System.Drawing.Size(219, 35);
            this.ComboBoxType.TabIndex = 45;
            this.ComboBoxType.Texts = "";
            this.ComboBoxType.OnSelectedIndexChanged += new System.EventHandler(this.ComboBox_OnSelectedIndexChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(17, 600);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(53, 23);
            this.labelType.TabIndex = 44;
            this.labelType.Text = "Тип:";
            // 
            // ComboBoxGenre
            // 
            this.ComboBoxGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxGenre.BackColor = System.Drawing.Color.White;
            this.ComboBoxGenre.BorderColor = System.Drawing.Color.SteelBlue;
            this.ComboBoxGenre.BorderSize = 2;
            this.ComboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGenre.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxGenre.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxGenre.IconColor = System.Drawing.Color.SteelBlue;
            this.ComboBoxGenre.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxGenre.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxGenre.Location = new System.Drawing.Point(21, 550);
            this.ComboBoxGenre.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxGenre.Name = "ComboBoxGenre";
            this.ComboBoxGenre.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxGenre.Size = new System.Drawing.Size(297, 35);
            this.ComboBoxGenre.TabIndex = 43;
            this.ComboBoxGenre.Texts = "";
            this.ComboBoxGenre.OnSelectedIndexChanged += new System.EventHandler(this.ComboBox_OnSelectedIndexChanged);
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre.Location = new System.Drawing.Point(17, 517);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(72, 23);
            this.labelGenre.TabIndex = 42;
            this.labelGenre.Text = "Жанр:";
            // 
            // ComboBoxFormat
            // 
            this.ComboBoxFormat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxFormat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxFormat.BackColor = System.Drawing.Color.White;
            this.ComboBoxFormat.BorderColor = System.Drawing.Color.SteelBlue;
            this.ComboBoxFormat.BorderSize = 2;
            this.ComboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFormat.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxFormat.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxFormat.IconColor = System.Drawing.Color.SteelBlue;
            this.ComboBoxFormat.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxFormat.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxFormat.Location = new System.Drawing.Point(21, 464);
            this.ComboBoxFormat.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxFormat.Name = "ComboBoxFormat";
            this.ComboBoxFormat.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxFormat.Size = new System.Drawing.Size(219, 35);
            this.ComboBoxFormat.TabIndex = 41;
            this.ComboBoxFormat.Texts = "";
            this.ComboBoxFormat.OnSelectedIndexChanged += new System.EventHandler(this.ComboBox_OnSelectedIndexChanged);
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormat.Location = new System.Drawing.Point(17, 431);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(89, 23);
            this.labelFormat.TabIndex = 40;
            this.labelFormat.Text = "Формат:";
            // 
            // ComboBoxManufacter
            // 
            this.ComboBoxManufacter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxManufacter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxManufacter.BackColor = System.Drawing.Color.White;
            this.ComboBoxManufacter.BorderColor = System.Drawing.Color.SteelBlue;
            this.ComboBoxManufacter.BorderSize = 2;
            this.ComboBoxManufacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ComboBoxManufacter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxManufacter.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxManufacter.IconColor = System.Drawing.Color.SteelBlue;
            this.ComboBoxManufacter.Items.AddRange(new object[] {
            "Yg Entertainment",
            "Hybe Corporation",
            "Interscope Records",
            "Sony Music Entertainment",
            "JYP Entertainment"});
            this.ComboBoxManufacter.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxManufacter.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxManufacter.Location = new System.Drawing.Point(21, 377);
            this.ComboBoxManufacter.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxManufacter.Name = "ComboBoxManufacter";
            this.ComboBoxManufacter.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxManufacter.Size = new System.Drawing.Size(297, 35);
            this.ComboBoxManufacter.TabIndex = 39;
            this.ComboBoxManufacter.Texts = "";
            this.ComboBoxManufacter.OnSelectedIndexChanged += new System.EventHandler(this.ComboBox_OnSelectedIndexChanged);
            // 
            // labelManufacter
            // 
            this.labelManufacter.AutoSize = true;
            this.labelManufacter.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManufacter.Location = new System.Drawing.Point(17, 344);
            this.labelManufacter.Name = "labelManufacter";
            this.labelManufacter.Size = new System.Drawing.Size(162, 23);
            this.labelManufacter.TabIndex = 38;
            this.labelManufacter.Text = "Производитель:";
            // 
            // ComboBoxArtist
            // 
            this.ComboBoxArtist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxArtist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxArtist.BackColor = System.Drawing.Color.White;
            this.ComboBoxArtist.BorderColor = System.Drawing.Color.SteelBlue;
            this.ComboBoxArtist.BorderSize = 2;
            this.ComboBoxArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ComboBoxArtist.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxArtist.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxArtist.IconColor = System.Drawing.Color.SteelBlue;
            this.ComboBoxArtist.Items.AddRange(new object[] {
            "BLACKPINK",
            "BTS",
            "Stray Kids",
            "Michael Jackson",
            "Agust D",
            "J-Hope",
            "Måneskin",
            "Lady Gaga"});
            this.ComboBoxArtist.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxArtist.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxArtist.Location = new System.Drawing.Point(21, 290);
            this.ComboBoxArtist.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxArtist.Name = "ComboBoxArtist";
            this.ComboBoxArtist.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxArtist.Size = new System.Drawing.Size(219, 35);
            this.ComboBoxArtist.TabIndex = 37;
            this.ComboBoxArtist.Texts = "";
            this.ComboBoxArtist.OnSelectedIndexChanged += new System.EventHandler(this.ComboBox_OnSelectedIndexChanged);
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArtist.Location = new System.Drawing.Point(17, 257);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(144, 23);
            this.labelArtist.TabIndex = 36;
            this.labelArtist.Text = "Исполнитель:";
            // 
            // ComboBoxAlbum
            // 
            this.ComboBoxAlbum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxAlbum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxAlbum.BackColor = System.Drawing.Color.White;
            this.ComboBoxAlbum.BorderColor = System.Drawing.Color.SteelBlue;
            this.ComboBoxAlbum.BorderSize = 2;
            this.ComboBoxAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ComboBoxAlbum.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxAlbum.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxAlbum.IconColor = System.Drawing.Color.SteelBlue;
            this.ComboBoxAlbum.ListBackColor = System.Drawing.Color.FloralWhite;
            this.ComboBoxAlbum.ListTextColor = System.Drawing.Color.Black;
            this.ComboBoxAlbum.Location = new System.Drawing.Point(21, 208);
            this.ComboBoxAlbum.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBoxAlbum.Name = "ComboBoxAlbum";
            this.ComboBoxAlbum.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxAlbum.Size = new System.Drawing.Size(297, 32);
            this.ComboBoxAlbum.TabIndex = 35;
            this.ComboBoxAlbum.Texts = "";
            this.ComboBoxAlbum.OnSelectedIndexChanged += new System.EventHandler(this.ComboBox_OnSelectedIndexChanged);
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlbumName.Location = new System.Drawing.Point(17, 178);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(195, 23);
            this.labelAlbumName.TabIndex = 28;
            this.labelAlbumName.Text = "Название альбома:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(346, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxPhotoFiltr
            // 
            this.pictureBoxPhotoFiltr.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhotoFiltr.Image")));
            this.pictureBoxPhotoFiltr.Location = new System.Drawing.Point(12, 17);
            this.pictureBoxPhotoFiltr.Name = "pictureBoxPhotoFiltr";
            this.pictureBoxPhotoFiltr.Size = new System.Drawing.Size(126, 123);
            this.pictureBoxPhotoFiltr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhotoFiltr.TabIndex = 24;
            this.pictureBoxPhotoFiltr.TabStop = false;
            // 
            // labelTitleFltr
            // 
            this.labelTitleFltr.AutoSize = true;
            this.labelTitleFltr.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleFltr.Location = new System.Drawing.Point(140, 59);
            this.labelTitleFltr.Name = "labelTitleFltr";
            this.labelTitleFltr.Size = new System.Drawing.Size(184, 44);
            this.labelTitleFltr.TabIndex = 0;
            this.labelTitleFltr.Text = "Фильтрация";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSearch.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonSearch.BorderRadius = 30;
            this.ButtonSearch.BorderSize = 0;
            this.ButtonSearch.Enabled = false;
            this.ButtonSearch.FlatAppearance.BorderSize = 0;
            this.ButtonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSearch.ForeColor = System.Drawing.Color.Black;
            this.ButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSearch.Image")));
            this.ButtonSearch.Location = new System.Drawing.Point(605, 112);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(87, 74);
            this.ButtonSearch.TabIndex = 14;
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.TextColor = System.Drawing.Color.Black;
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Visible = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxSearch.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.TextBoxSearch.BorderFocusColor = System.Drawing.Color.MediumSeaGreen;
            this.TextBoxSearch.BorderRadius = 0;
            this.TextBoxSearch.BorderSize = 2;
            this.TextBoxSearch.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.TextBoxSearch.Location = new System.Drawing.Point(399, 128);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSearch.MaxLength = 32767;
            this.TextBoxSearch.MinLength = 0;
            this.TextBoxSearch.Multiline = false;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxSearch.PasswordChar = false;
            this.TextBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxSearch.PlaceholderText = "";
            this.TextBoxSearch.Size = new System.Drawing.Size(196, 38);
            this.TextBoxSearch.TabIndex = 13;
            this.TextBoxSearch.Texts = "";
            this.TextBoxSearch.UnderlinedStyle = false;
            this.TextBoxSearch.Visible = false;
            this.TextBoxSearch._TextChanged += new System.EventHandler(this.TextBoxSearch__TextChanged);
            // 
            // pictureBoxWelcome
            // 
            this.pictureBoxWelcome.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWelcome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWelcome.Image")));
            this.pictureBoxWelcome.Location = new System.Drawing.Point(399, 187);
            this.pictureBoxWelcome.Name = "pictureBoxWelcome";
            this.pictureBoxWelcome.Size = new System.Drawing.Size(1362, 478);
            this.pictureBoxWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWelcome.TabIndex = 31;
            this.pictureBoxWelcome.TabStop = false;
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.BackColor = System.Drawing.Color.Transparent;
            this.ButtonHelp.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonHelp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonHelp.BorderRadius = 0;
            this.ButtonHelp.BorderSize = 0;
            this.ButtonHelp.FlatAppearance.BorderSize = 0;
            this.ButtonHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.ButtonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHelp.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonHelp.ForeColor = System.Drawing.Color.SteelBlue;
            this.ButtonHelp.Image = ((System.Drawing.Image)(resources.GetObject("ButtonHelp.Image")));
            this.ButtonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHelp.Location = new System.Drawing.Point(1706, 816);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(162, 62);
            this.ButtonHelp.TabIndex = 32;
            this.ButtonHelp.Text = "Помощь";
            this.ButtonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonHelp.TextColor = System.Drawing.Color.SteelBlue;
            this.ButtonHelp.UseVisualStyleBackColor = false;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1901, 897);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.pictureBoxWelcome);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.pictureBoxFilter);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilter)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoFiltr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Panel panel2;
        private RJButton ButtonAlbum;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureBoxFilter;
        private System.Windows.Forms.Panel panelFilter;
        private RJButton ButtonFilterClose;
        private RJButton ButtonClear;
        private RJTextBox TextBoxPrice2;
        private System.Windows.Forms.Label label6;
        private RJTextBox TextBoxPrice1;
        private System.Windows.Forms.Label labelPrice;
        private RJComboBox ComboBoxType;
        private System.Windows.Forms.Label labelType;
        private RJComboBox ComboBoxGenre;
        private System.Windows.Forms.Label labelGenre;
        private RJComboBox ComboBoxFormat;
        private System.Windows.Forms.Label labelFormat;
        private RJComboBox ComboBoxManufacter;
        private System.Windows.Forms.Label labelManufacter;
        private RJComboBox ComboBoxArtist;
        private System.Windows.Forms.Label labelArtist;
        private RJComboBox ComboBoxAlbum;
        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxPhotoFiltr;
        private System.Windows.Forms.Label labelTitleFltr;
        private RJButton ButtonSearch;
        private RJTextBox TextBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxWelcome;
        private RJButton ButtonHelp;
    }
}