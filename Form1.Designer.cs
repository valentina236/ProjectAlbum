namespace DatabaseAlbum
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonAdminPanel = new DatabaseAlbum.RJButton();
            this.ButtonAlbumDetails = new DatabaseAlbum.RJButton();
            this.contextMenuStripAlbum = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.форматыАльбомовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыАльбомовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жанрыАльбомовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonRaportOpen = new DatabaseAlbum.RJButton();
            this.ButtonUcet = new DatabaseAlbum.RJButton();
            this.ButtonCheck = new DatabaseAlbum.RJButton();
            this.ButtonTTN = new DatabaseAlbum.RJButton();
            this.ButtonProvider = new DatabaseAlbum.RJButton();
            this.ButtonAlbum = new DatabaseAlbum.RJButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFilter = new System.Windows.Forms.PictureBox();
            this.panelReports = new System.Windows.Forms.Panel();
            this.ButtonDiagramReport = new DatabaseAlbum.RJButton();
            this.ButtonCheckInfoReport = new DatabaseAlbum.RJButton();
            this.ButtonTTNInfoForm = new DatabaseAlbum.RJButton();
            this.ButtonAlbumInfoReport = new DatabaseAlbum.RJButton();
            this.ButtonCount = new DatabaseAlbum.RJButton();
            this.ButtonEdit = new DatabaseAlbum.RJButton();
            this.ButtonSearch = new DatabaseAlbum.RJButton();
            this.TextBoxSearch = new DatabaseAlbum.RJTextBox();
            this.ButtonDelete = new DatabaseAlbum.RJButton();
            this.ButtonAdd = new DatabaseAlbum.RJButton();
            this.pictureBoxWelcome = new System.Windows.Forms.PictureBox();
            this.ButtonHelp = new DatabaseAlbum.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoFiltr)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStripAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilter)).BeginInit();
            this.panelReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(231)))), ((int)(((byte)(241)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(385, 310);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1474, 539);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.Visible = false;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1901, 47);
            this.panel1.TabIndex = 4;
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
            this.panelFilter.Size = new System.Drawing.Size(351, 925);
            this.panelFilter.TabIndex = 12;
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
            this.ButtonFilterClose.Location = new System.Drawing.Point(224, 785);
            this.ButtonFilterClose.Name = "ButtonFilterClose";
            this.ButtonFilterClose.Size = new System.Drawing.Size(81, 71);
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
            this.ButtonClear.Location = new System.Drawing.Point(26, 785);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(63, 70);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.ButtonAdminPanel);
            this.panel2.Controls.Add(this.ButtonAlbumDetails);
            this.panel2.Controls.Add(this.ButtonRaportOpen);
            this.panel2.Controls.Add(this.ButtonUcet);
            this.panel2.Controls.Add(this.ButtonCheck);
            this.panel2.Controls.Add(this.ButtonTTN);
            this.panel2.Controls.Add(this.ButtonProvider);
            this.panel2.Controls.Add(this.ButtonAlbum);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 925);
            this.panel2.TabIndex = 5;
            // 
            // ButtonAdminPanel
            // 
            this.ButtonAdminPanel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAdminPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonAdminPanel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonAdminPanel.BorderRadius = 30;
            this.ButtonAdminPanel.BorderSize = 0;
            this.ButtonAdminPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdminPanel.FlatAppearance.BorderSize = 0;
            this.ButtonAdminPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonAdminPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdminPanel.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdminPanel.ForeColor = System.Drawing.Color.Black;
            this.ButtonAdminPanel.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdminPanel.Image")));
            this.ButtonAdminPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAdminPanel.Location = new System.Drawing.Point(8, 797);
            this.ButtonAdminPanel.Name = "ButtonAdminPanel";
            this.ButtonAdminPanel.Size = new System.Drawing.Size(317, 92);
            this.ButtonAdminPanel.TabIndex = 15;
            this.ButtonAdminPanel.Text = " Панель админа";
            this.ButtonAdminPanel.TextColor = System.Drawing.Color.Black;
            this.ButtonAdminPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAdminPanel.UseVisualStyleBackColor = false;
            this.ButtonAdminPanel.Click += new System.EventHandler(this.ButtonAdminPanel_Click);
            // 
            // ButtonAlbumDetails
            // 
            this.ButtonAlbumDetails.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAlbumDetails.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonAlbumDetails.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonAlbumDetails.BorderRadius = 0;
            this.ButtonAlbumDetails.BorderSize = 0;
            this.ButtonAlbumDetails.ContextMenuStrip = this.contextMenuStripAlbum;
            this.ButtonAlbumDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAlbumDetails.FlatAppearance.BorderSize = 0;
            this.ButtonAlbumDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonAlbumDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonAlbumDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAlbumDetails.Font = new System.Drawing.Font("Bookman Old Style", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAlbumDetails.ForeColor = System.Drawing.Color.Black;
            this.ButtonAlbumDetails.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAlbumDetails.Image")));
            this.ButtonAlbumDetails.Location = new System.Drawing.Point(273, 208);
            this.ButtonAlbumDetails.Name = "ButtonAlbumDetails";
            this.ButtonAlbumDetails.Size = new System.Drawing.Size(45, 41);
            this.ButtonAlbumDetails.TabIndex = 31;
            this.ButtonAlbumDetails.TextColor = System.Drawing.Color.Black;
            this.ButtonAlbumDetails.UseVisualStyleBackColor = false;
            // 
            // contextMenuStripAlbum
            // 
            this.contextMenuStripAlbum.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStripAlbum.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripAlbum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.форматыАльбомовToolStripMenuItem,
            this.типыАльбомовToolStripMenuItem,
            this.жанрыАльбомовToolStripMenuItem});
            this.contextMenuStripAlbum.Name = "contextMenuStripAlbum";
            this.contextMenuStripAlbum.Size = new System.Drawing.Size(269, 172);
            // 
            // форматыАльбомовToolStripMenuItem
            // 
            this.форматыАльбомовToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("форматыАльбомовToolStripMenuItem.Image")));
            this.форматыАльбомовToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.форматыАльбомовToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.форматыАльбомовToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.форматыАльбомовToolStripMenuItem.Name = "форматыАльбомовToolStripMenuItem";
            this.форматыАльбомовToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6);
            this.форматыАльбомовToolStripMenuItem.Size = new System.Drawing.Size(280, 56);
            this.форматыАльбомовToolStripMenuItem.Text = "Форматы альбомов";
            this.форматыАльбомовToolStripMenuItem.Click += new System.EventHandler(this.форматыАльбомовToolStripMenuItem_Click);
            // 
            // типыАльбомовToolStripMenuItem
            // 
            this.типыАльбомовToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("типыАльбомовToolStripMenuItem.Image")));
            this.типыАльбомовToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.типыАльбомовToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.типыАльбомовToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.типыАльбомовToolStripMenuItem.Name = "типыАльбомовToolStripMenuItem";
            this.типыАльбомовToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6);
            this.типыАльбомовToolStripMenuItem.Size = new System.Drawing.Size(280, 56);
            this.типыАльбомовToolStripMenuItem.Text = "Типы альбомов";
            this.типыАльбомовToolStripMenuItem.Click += new System.EventHandler(this.типыАльбомовToolStripMenuItem_Click);
            // 
            // жанрыАльбомовToolStripMenuItem
            // 
            this.жанрыАльбомовToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("жанрыАльбомовToolStripMenuItem.Image")));
            this.жанрыАльбомовToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.жанрыАльбомовToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.жанрыАльбомовToolStripMenuItem.Name = "жанрыАльбомовToolStripMenuItem";
            this.жанрыАльбомовToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6);
            this.жанрыАльбомовToolStripMenuItem.Size = new System.Drawing.Size(280, 56);
            this.жанрыАльбомовToolStripMenuItem.Text = "Жанры альбомов";
            this.жанрыАльбомовToolStripMenuItem.Click += new System.EventHandler(this.жанрыАльбомовToolStripMenuItem_Click);
            // 
            // ButtonRaportOpen
            // 
            this.ButtonRaportOpen.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRaportOpen.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonRaportOpen.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonRaportOpen.BorderRadius = 30;
            this.ButtonRaportOpen.BorderSize = 0;
            this.ButtonRaportOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRaportOpen.FlatAppearance.BorderSize = 0;
            this.ButtonRaportOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonRaportOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonRaportOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRaportOpen.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRaportOpen.ForeColor = System.Drawing.Color.Black;
            this.ButtonRaportOpen.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRaportOpen.Image")));
            this.ButtonRaportOpen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonRaportOpen.Location = new System.Drawing.Point(9, 705);
            this.ButtonRaportOpen.Name = "ButtonRaportOpen";
            this.ButtonRaportOpen.Size = new System.Drawing.Size(317, 81);
            this.ButtonRaportOpen.TabIndex = 14;
            this.ButtonRaportOpen.Text = "  Отчеты";
            this.ButtonRaportOpen.TextColor = System.Drawing.Color.Black;
            this.ButtonRaportOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonRaportOpen.UseVisualStyleBackColor = false;
            this.ButtonRaportOpen.Click += new System.EventHandler(this.ButtonRaportOpen_Click);
            // 
            // ButtonUcet
            // 
            this.ButtonUcet.BackColor = System.Drawing.Color.Transparent;
            this.ButtonUcet.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonUcet.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonUcet.BorderRadius = 25;
            this.ButtonUcet.BorderSize = 0;
            this.ButtonUcet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUcet.FlatAppearance.BorderSize = 0;
            this.ButtonUcet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonUcet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonUcet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUcet.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUcet.ForeColor = System.Drawing.Color.Black;
            this.ButtonUcet.Image = ((System.Drawing.Image)(resources.GetObject("ButtonUcet.Image")));
            this.ButtonUcet.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonUcet.Location = new System.Drawing.Point(12, 608);
            this.ButtonUcet.Name = "ButtonUcet";
            this.ButtonUcet.Size = new System.Drawing.Size(293, 86);
            this.ButtonUcet.TabIndex = 13;
            this.ButtonUcet.Text = "   Журнал учета";
            this.ButtonUcet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonUcet.TextColor = System.Drawing.Color.Black;
            this.ButtonUcet.UseVisualStyleBackColor = false;
            this.ButtonUcet.Click += new System.EventHandler(this.ButtonUcet_Click);
            // 
            // ButtonCheck
            // 
            this.ButtonCheck.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCheck.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonCheck.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonCheck.BorderRadius = 30;
            this.ButtonCheck.BorderSize = 0;
            this.ButtonCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCheck.FlatAppearance.BorderSize = 0;
            this.ButtonCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCheck.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCheck.ForeColor = System.Drawing.Color.Black;
            this.ButtonCheck.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCheck.Image")));
            this.ButtonCheck.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonCheck.Location = new System.Drawing.Point(6, 511);
            this.ButtonCheck.Name = "ButtonCheck";
            this.ButtonCheck.Size = new System.Drawing.Size(323, 86);
            this.ButtonCheck.TabIndex = 12;
            this.ButtonCheck.Text = "Покупки";
            this.ButtonCheck.TextColor = System.Drawing.Color.Black;
            this.ButtonCheck.UseVisualStyleBackColor = false;
            this.ButtonCheck.Click += new System.EventHandler(this.ButtonCheck_Click);
            // 
            // ButtonTTN
            // 
            this.ButtonTTN.BackColor = System.Drawing.Color.Transparent;
            this.ButtonTTN.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonTTN.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonTTN.BorderRadius = 30;
            this.ButtonTTN.BorderSize = 0;
            this.ButtonTTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTTN.FlatAppearance.BorderSize = 0;
            this.ButtonTTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonTTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonTTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTTN.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonTTN.ForeColor = System.Drawing.Color.Black;
            this.ButtonTTN.Image = ((System.Drawing.Image)(resources.GetObject("ButtonTTN.Image")));
            this.ButtonTTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonTTN.Location = new System.Drawing.Point(3, 414);
            this.ButtonTTN.Name = "ButtonTTN";
            this.ButtonTTN.Size = new System.Drawing.Size(326, 81);
            this.ButtonTTN.TabIndex = 11;
            this.ButtonTTN.Text = "ТТН (накладная)";
            this.ButtonTTN.TextColor = System.Drawing.Color.Black;
            this.ButtonTTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonTTN.UseVisualStyleBackColor = false;
            this.ButtonTTN.Click += new System.EventHandler(this.ButtonTTN_Click);
            // 
            // ButtonProvider
            // 
            this.ButtonProvider.BackColor = System.Drawing.Color.Transparent;
            this.ButtonProvider.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonProvider.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonProvider.BorderRadius = 25;
            this.ButtonProvider.BorderSize = 0;
            this.ButtonProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonProvider.FlatAppearance.BorderSize = 0;
            this.ButtonProvider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonProvider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProvider.Font = new System.Drawing.Font("Bookman Old Style", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonProvider.ForeColor = System.Drawing.Color.Black;
            this.ButtonProvider.Image = ((System.Drawing.Image)(resources.GetObject("ButtonProvider.Image")));
            this.ButtonProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonProvider.Location = new System.Drawing.Point(9, 295);
            this.ButtonProvider.Name = "ButtonProvider";
            this.ButtonProvider.Size = new System.Drawing.Size(296, 98);
            this.ButtonProvider.TabIndex = 10;
            this.ButtonProvider.Text = "Поставщики";
            this.ButtonProvider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonProvider.TextColor = System.Drawing.Color.Black;
            this.ButtonProvider.UseVisualStyleBackColor = false;
            this.ButtonProvider.Click += new System.EventHandler(this.ButtonProvider_Click);
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
            this.ButtonAlbum.Location = new System.Drawing.Point(3, 174);
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
            // pictureBoxFilter
            // 
            this.pictureBoxFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFilter.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFilter.Image")));
            this.pictureBoxFilter.Location = new System.Drawing.Point(1789, 237);
            this.pictureBoxFilter.Name = "pictureBoxFilter";
            this.pictureBoxFilter.Size = new System.Drawing.Size(70, 56);
            this.pictureBoxFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFilter.TabIndex = 11;
            this.pictureBoxFilter.TabStop = false;
            this.pictureBoxFilter.Visible = false;
            this.pictureBoxFilter.Click += new System.EventHandler(this.pictureBoxFilter_Click);
            // 
            // panelReports
            // 
            this.panelReports.Controls.Add(this.ButtonDiagramReport);
            this.panelReports.Controls.Add(this.ButtonCheckInfoReport);
            this.panelReports.Controls.Add(this.ButtonTTNInfoForm);
            this.panelReports.Controls.Add(this.ButtonAlbumInfoReport);
            this.panelReports.Location = new System.Drawing.Point(524, 252);
            this.panelReports.Name = "panelReports";
            this.panelReports.Size = new System.Drawing.Size(1103, 502);
            this.panelReports.TabIndex = 29;
            this.panelReports.Visible = false;
            // 
            // ButtonDiagramReport
            // 
            this.ButtonDiagramReport.BackColor = System.Drawing.Color.Teal;
            this.ButtonDiagramReport.BackgroundColor = System.Drawing.Color.Teal;
            this.ButtonDiagramReport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonDiagramReport.BorderRadius = 15;
            this.ButtonDiagramReport.BorderSize = 0;
            this.ButtonDiagramReport.FlatAppearance.BorderSize = 0;
            this.ButtonDiagramReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDiagramReport.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDiagramReport.ForeColor = System.Drawing.Color.White;
            this.ButtonDiagramReport.Location = new System.Drawing.Point(575, 271);
            this.ButtonDiagramReport.Name = "ButtonDiagramReport";
            this.ButtonDiagramReport.Size = new System.Drawing.Size(307, 141);
            this.ButtonDiagramReport.TabIndex = 3;
            this.ButtonDiagramReport.Text = "Диаграмма";
            this.ButtonDiagramReport.TextColor = System.Drawing.Color.White;
            this.ButtonDiagramReport.UseVisualStyleBackColor = false;
            this.ButtonDiagramReport.Click += new System.EventHandler(this.ButtonDiagramReport_Click);
            // 
            // ButtonCheckInfoReport
            // 
            this.ButtonCheckInfoReport.BackColor = System.Drawing.Color.Teal;
            this.ButtonCheckInfoReport.BackgroundColor = System.Drawing.Color.Teal;
            this.ButtonCheckInfoReport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonCheckInfoReport.BorderRadius = 15;
            this.ButtonCheckInfoReport.BorderSize = 0;
            this.ButtonCheckInfoReport.FlatAppearance.BorderSize = 0;
            this.ButtonCheckInfoReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCheckInfoReport.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCheckInfoReport.ForeColor = System.Drawing.Color.White;
            this.ButtonCheckInfoReport.Location = new System.Drawing.Point(189, 277);
            this.ButtonCheckInfoReport.Name = "ButtonCheckInfoReport";
            this.ButtonCheckInfoReport.Size = new System.Drawing.Size(307, 141);
            this.ButtonCheckInfoReport.TabIndex = 2;
            this.ButtonCheckInfoReport.Text = "Информация о покупках";
            this.ButtonCheckInfoReport.TextColor = System.Drawing.Color.White;
            this.ButtonCheckInfoReport.UseVisualStyleBackColor = false;
            this.ButtonCheckInfoReport.Click += new System.EventHandler(this.ButtonCheckInfoReport_Click);
            // 
            // ButtonTTNInfoForm
            // 
            this.ButtonTTNInfoForm.BackColor = System.Drawing.Color.Teal;
            this.ButtonTTNInfoForm.BackgroundColor = System.Drawing.Color.Teal;
            this.ButtonTTNInfoForm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonTTNInfoForm.BorderRadius = 15;
            this.ButtonTTNInfoForm.BorderSize = 0;
            this.ButtonTTNInfoForm.FlatAppearance.BorderSize = 0;
            this.ButtonTTNInfoForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTTNInfoForm.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonTTNInfoForm.ForeColor = System.Drawing.Color.White;
            this.ButtonTTNInfoForm.Location = new System.Drawing.Point(536, 87);
            this.ButtonTTNInfoForm.Name = "ButtonTTNInfoForm";
            this.ButtonTTNInfoForm.Size = new System.Drawing.Size(383, 141);
            this.ButtonTTNInfoForm.TabIndex = 1;
            this.ButtonTTNInfoForm.Text = "Товарно-транспортная накладная";
            this.ButtonTTNInfoForm.TextColor = System.Drawing.Color.White;
            this.ButtonTTNInfoForm.UseVisualStyleBackColor = false;
            this.ButtonTTNInfoForm.Click += new System.EventHandler(this.ButtonTTNInfoForm_Click);
            // 
            // ButtonAlbumInfoReport
            // 
            this.ButtonAlbumInfoReport.BackColor = System.Drawing.Color.Teal;
            this.ButtonAlbumInfoReport.BackgroundColor = System.Drawing.Color.Teal;
            this.ButtonAlbumInfoReport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonAlbumInfoReport.BorderRadius = 15;
            this.ButtonAlbumInfoReport.BorderSize = 0;
            this.ButtonAlbumInfoReport.FlatAppearance.BorderSize = 0;
            this.ButtonAlbumInfoReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAlbumInfoReport.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAlbumInfoReport.ForeColor = System.Drawing.Color.White;
            this.ButtonAlbumInfoReport.Location = new System.Drawing.Point(189, 87);
            this.ButtonAlbumInfoReport.Name = "ButtonAlbumInfoReport";
            this.ButtonAlbumInfoReport.Size = new System.Drawing.Size(307, 141);
            this.ButtonAlbumInfoReport.TabIndex = 0;
            this.ButtonAlbumInfoReport.Text = "Информация об альбомах";
            this.ButtonAlbumInfoReport.TextColor = System.Drawing.Color.White;
            this.ButtonAlbumInfoReport.UseVisualStyleBackColor = false;
            this.ButtonAlbumInfoReport.Click += new System.EventHandler(this.ButtonAlbumInfoReport_Click);
            // 
            // ButtonCount
            // 
            this.ButtonCount.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCount.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonCount.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonCount.BorderRadius = 27;
            this.ButtonCount.BorderSize = 0;
            this.ButtonCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCount.FlatAppearance.BorderSize = 0;
            this.ButtonCount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonCount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCount.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCount.ForeColor = System.Drawing.Color.Black;
            this.ButtonCount.Location = new System.Drawing.Point(1724, 779);
            this.ButtonCount.Name = "ButtonCount";
            this.ButtonCount.Size = new System.Drawing.Size(133, 54);
            this.ButtonCount.TabIndex = 28;
            this.ButtonCount.Text = "Итоги";
            this.ButtonCount.TextColor = System.Drawing.Color.Black;
            this.ButtonCount.UseVisualStyleBackColor = false;
            this.ButtonCount.Visible = false;
            this.ButtonCount.Click += new System.EventHandler(this.ButtonCount_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEdit.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonEdit.BorderRadius = 30;
            this.ButtonEdit.BorderSize = 0;
            this.ButtonEdit.FlatAppearance.BorderSize = 0;
            this.ButtonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEdit.ForeColor = System.Drawing.Color.Black;
            this.ButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEdit.Image")));
            this.ButtonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEdit.Location = new System.Drawing.Point(1259, 107);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(188, 80);
            this.ButtonEdit.TabIndex = 10;
            this.ButtonEdit.Text = "Изменить";
            this.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonEdit.TextColor = System.Drawing.Color.Black;
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Visible = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
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
            this.ButtonSearch.Location = new System.Drawing.Point(605, 113);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(87, 74);
            this.ButtonSearch.TabIndex = 9;
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
            this.TextBoxSearch.Location = new System.Drawing.Point(399, 129);
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
            this.TextBoxSearch.TabIndex = 8;
            this.TextBoxSearch.Texts = "";
            this.TextBoxSearch.UnderlinedStyle = false;
            this.TextBoxSearch.Visible = false;
            this.TextBoxSearch._TextChanged += new System.EventHandler(this.TextBoxSearch__TextChanged);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDelete.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonDelete.BorderRadius = 30;
            this.ButtonDelete.BorderSize = 0;
            this.ButtonDelete.FlatAppearance.BorderSize = 0;
            this.ButtonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDelete.ForeColor = System.Drawing.Color.Black;
            this.ButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.Image")));
            this.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDelete.Location = new System.Drawing.Point(1474, 106);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(175, 80);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDelete.TextColor = System.Drawing.Color.Black;
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Visible = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAdd.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonAdd.BorderRadius = 30;
            this.ButtonAdd.BorderSize = 0;
            this.ButtonAdd.FlatAppearance.BorderSize = 0;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.Black;
            this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
            this.ButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new System.Drawing.Point(1665, 106);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(194, 80);
            this.ButtonAdd.TabIndex = 6;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAdd.TextColor = System.Drawing.Color.Black;
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Visible = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // pictureBoxWelcome
            // 
            this.pictureBoxWelcome.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWelcome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWelcome.Image")));
            this.pictureBoxWelcome.Location = new System.Drawing.Point(399, 205);
            this.pictureBoxWelcome.Name = "pictureBoxWelcome";
            this.pictureBoxWelcome.Size = new System.Drawing.Size(1442, 546);
            this.pictureBoxWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWelcome.TabIndex = 30;
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
            this.ButtonHelp.Location = new System.Drawing.Point(1713, 898);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(162, 62);
            this.ButtonHelp.TabIndex = 33;
            this.ButtonHelp.Text = "Помощь";
            this.ButtonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonHelp.TextColor = System.Drawing.Color.SteelBlue;
            this.ButtonHelp.UseVisualStyleBackColor = false;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1901, 972);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.pictureBoxWelcome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelReports);
            this.Controls.Add(this.ButtonCount);
            this.Controls.Add(this.pictureBoxFilter);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoFiltr)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStripAlbum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilter)).EndInit();
            this.panelReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJButton ButtonAlbum;
        private RJButton ButtonProvider;
        private RJButton ButtonTTN;
        private RJButton ButtonCheck;
        private RJButton ButtonUcet;
        private RJButton ButtonAdd;
        private RJButton ButtonDelete;
        private RJTextBox TextBoxSearch;
        private RJButton ButtonSearch;
        private RJButton ButtonEdit;
        private System.Windows.Forms.PictureBox pictureBoxFilter;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label labelTitleFltr;
        private System.Windows.Forms.PictureBox pictureBoxPhotoFiltr;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelAlbumName;
        private RJComboBox ComboBoxAlbum;
        private System.Windows.Forms.Label labelArtist;
        private RJComboBox ComboBoxArtist;
        private RJComboBox ComboBoxManufacter;
        private System.Windows.Forms.Label labelManufacter;
        private RJComboBox ComboBoxFormat;
        private System.Windows.Forms.Label labelFormat;
        private RJComboBox ComboBoxGenre;
        private System.Windows.Forms.Label labelGenre;
        private RJComboBox ComboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label label6;
        private RJTextBox TextBoxPrice1;
        private System.Windows.Forms.Label labelPrice;
        private RJTextBox TextBoxPrice2;
        private RJButton ButtonClear;
        private RJButton ButtonFilterClose;
        private RJButton ButtonCount;
        private System.Windows.Forms.Panel panelReports;
        private RJButton ButtonAlbumInfoReport;
        private RJButton ButtonCheckInfoReport;
        private RJButton ButtonTTNInfoForm;
        private RJButton ButtonDiagramReport;
        private RJButton ButtonRaportOpen;
        private System.Windows.Forms.DataGridView dataGridView;
        private RJButton ButtonAdminPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAlbum;
        private System.Windows.Forms.ToolStripMenuItem форматыАльбомовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыАльбомовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жанрыАльбомовToolStripMenuItem;
        private RJButton ButtonAlbumDetails;
        private System.Windows.Forms.PictureBox pictureBoxWelcome;
        private RJButton ButtonHelp;
    }
}

