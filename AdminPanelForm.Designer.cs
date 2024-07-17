namespace DatabaseAlbum
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ButtonDelete = new DatabaseAlbum.RJButton();
            this.ButtonEdit = new DatabaseAlbum.RJButton();
            this.ButtonAdd = new DatabaseAlbum.RJButton();
            this.ButtonUsers = new DatabaseAlbum.RJButton();
            this.ButtonBackUpRestore = new DatabaseAlbum.RJButton();
            this.ButtonBackUp = new DatabaseAlbum.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 47);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(785, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(44, 47);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxExit.TabIndex = 6;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTitle.Location = new System.Drawing.Point(147, 92);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(511, 44);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Панель управления администратора";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.dataGridView.Location = new System.Drawing.Point(141, 480);
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
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(502, 344);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.Visible = false;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDelete.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonDelete.BorderRadius = 0;
            this.ButtonDelete.BorderSize = 0;
            this.ButtonDelete.FlatAppearance.BorderSize = 0;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.Image")));
            this.ButtonDelete.Location = new System.Drawing.Point(649, 591);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(57, 55);
            this.ButtonDelete.TabIndex = 17;
            this.ButtonDelete.TextColor = System.Drawing.Color.White;
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Visible = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEdit.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonEdit.BorderRadius = 0;
            this.ButtonEdit.BorderSize = 0;
            this.ButtonEdit.FlatAppearance.BorderSize = 0;
            this.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEdit.ForeColor = System.Drawing.Color.White;
            this.ButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEdit.Image")));
            this.ButtonEdit.Location = new System.Drawing.Point(649, 530);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(57, 55);
            this.ButtonEdit.TabIndex = 16;
            this.ButtonEdit.TextColor = System.Drawing.Color.White;
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Visible = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAdd.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonAdd.BorderRadius = 0;
            this.ButtonAdd.BorderSize = 0;
            this.ButtonAdd.FlatAppearance.BorderSize = 0;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
            this.ButtonAdd.Location = new System.Drawing.Point(649, 469);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(57, 55);
            this.ButtonAdd.TabIndex = 15;
            this.ButtonAdd.TextColor = System.Drawing.Color.White;
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Visible = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonUsers
            // 
            this.ButtonUsers.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonUsers.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonUsers.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonUsers.BorderRadius = 12;
            this.ButtonUsers.BorderSize = 0;
            this.ButtonUsers.FlatAppearance.BorderSize = 0;
            this.ButtonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUsers.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUsers.ForeColor = System.Drawing.Color.White;
            this.ButtonUsers.Location = new System.Drawing.Point(193, 376);
            this.ButtonUsers.Name = "ButtonUsers";
            this.ButtonUsers.Size = new System.Drawing.Size(400, 59);
            this.ButtonUsers.TabIndex = 10;
            this.ButtonUsers.Text = "Пользователи";
            this.ButtonUsers.TextColor = System.Drawing.Color.White;
            this.ButtonUsers.UseVisualStyleBackColor = false;
            this.ButtonUsers.Click += new System.EventHandler(this.ButtonUsers_Click);
            // 
            // ButtonBackUpRestore
            // 
            this.ButtonBackUpRestore.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonBackUpRestore.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonBackUpRestore.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonBackUpRestore.BorderRadius = 12;
            this.ButtonBackUpRestore.BorderSize = 0;
            this.ButtonBackUpRestore.FlatAppearance.BorderSize = 0;
            this.ButtonBackUpRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBackUpRestore.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBackUpRestore.ForeColor = System.Drawing.Color.White;
            this.ButtonBackUpRestore.Location = new System.Drawing.Point(193, 293);
            this.ButtonBackUpRestore.Name = "ButtonBackUpRestore";
            this.ButtonBackUpRestore.Size = new System.Drawing.Size(400, 59);
            this.ButtonBackUpRestore.TabIndex = 9;
            this.ButtonBackUpRestore.Text = "Восстановить данные";
            this.ButtonBackUpRestore.TextColor = System.Drawing.Color.White;
            this.ButtonBackUpRestore.UseVisualStyleBackColor = false;
            this.ButtonBackUpRestore.Click += new System.EventHandler(this.ButtonBackUpRestore_Click);
            // 
            // ButtonBackUp
            // 
            this.ButtonBackUp.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonBackUp.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonBackUp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonBackUp.BorderRadius = 12;
            this.ButtonBackUp.BorderSize = 0;
            this.ButtonBackUp.FlatAppearance.BorderSize = 0;
            this.ButtonBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBackUp.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBackUp.ForeColor = System.Drawing.Color.White;
            this.ButtonBackUp.Location = new System.Drawing.Point(193, 208);
            this.ButtonBackUp.Name = "ButtonBackUp";
            this.ButtonBackUp.Size = new System.Drawing.Size(400, 59);
            this.ButtonBackUp.TabIndex = 8;
            this.ButtonBackUp.Text = "Создать резервную копию";
            this.ButtonBackUp.TextColor = System.Drawing.Color.White;
            this.ButtonBackUp.UseVisualStyleBackColor = false;
            this.ButtonBackUp.Click += new System.EventHandler(this.ButtonBackUp_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 866);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ButtonUsers);
            this.Controls.Add(this.ButtonBackUpRestore);
            this.Controls.Add(this.ButtonBackUp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanelForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJButton ButtonBackUp;
        private RJButton ButtonBackUpRestore;
        private RJButton ButtonUsers;
        private System.Windows.Forms.DataGridView dataGridView;
        private RJButton ButtonAdd;
        private RJButton ButtonEdit;
        private RJButton ButtonDelete;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}