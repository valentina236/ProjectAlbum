namespace DatabaseAlbum
{
    partial class TotalsAlbumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalsAlbumForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonMin = new DatabaseAlbum.RJButton();
            this.ButtonMax = new DatabaseAlbum.RJButton();
            this.ButtonAvg = new DatabaseAlbum.RJButton();
            this.ButtonCount = new DatabaseAlbum.RJButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 47);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(946, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(1532, 3);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(49, 41);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxExit.TabIndex = 6;
            this.pictureBoxExit.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(30, 343);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(920, 294);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.Visible = false;
            // 
            // ButtonMin
            // 
            this.ButtonMin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonMin.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonMin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonMin.BorderRadius = 27;
            this.ButtonMin.BorderSize = 0;
            this.ButtonMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMin.FlatAppearance.BorderSize = 0;
            this.ButtonMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.ButtonMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.ButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMin.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMin.ForeColor = System.Drawing.Color.White;
            this.ButtonMin.Location = new System.Drawing.Point(30, 98);
            this.ButtonMin.Name = "ButtonMin";
            this.ButtonMin.Size = new System.Drawing.Size(221, 61);
            this.ButtonMin.TabIndex = 24;
            this.ButtonMin.Text = "Самый дешевый альбом";
            this.ButtonMin.TextColor = System.Drawing.Color.White;
            this.ButtonMin.UseVisualStyleBackColor = false;
            this.ButtonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // ButtonMax
            // 
            this.ButtonMax.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonMax.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonMax.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonMax.BorderRadius = 27;
            this.ButtonMax.BorderSize = 0;
            this.ButtonMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMax.FlatAppearance.BorderSize = 0;
            this.ButtonMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.ButtonMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.ButtonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMax.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMax.ForeColor = System.Drawing.Color.White;
            this.ButtonMax.Location = new System.Drawing.Point(267, 98);
            this.ButtonMax.Name = "ButtonMax";
            this.ButtonMax.Size = new System.Drawing.Size(223, 61);
            this.ButtonMax.TabIndex = 25;
            this.ButtonMax.Text = "Самый дорогой альбом";
            this.ButtonMax.TextColor = System.Drawing.Color.White;
            this.ButtonMax.UseVisualStyleBackColor = false;
            this.ButtonMax.Click += new System.EventHandler(this.ButtonMax_Click);
            // 
            // ButtonAvg
            // 
            this.ButtonAvg.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonAvg.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonAvg.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonAvg.BorderRadius = 27;
            this.ButtonAvg.BorderSize = 0;
            this.ButtonAvg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAvg.FlatAppearance.BorderSize = 0;
            this.ButtonAvg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.ButtonAvg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.ButtonAvg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAvg.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAvg.ForeColor = System.Drawing.Color.White;
            this.ButtonAvg.Location = new System.Drawing.Point(512, 98);
            this.ButtonAvg.Name = "ButtonAvg";
            this.ButtonAvg.Size = new System.Drawing.Size(223, 61);
            this.ButtonAvg.TabIndex = 26;
            this.ButtonAvg.Text = "Средняя цена альбомов";
            this.ButtonAvg.TextColor = System.Drawing.Color.White;
            this.ButtonAvg.UseVisualStyleBackColor = false;
            this.ButtonAvg.Click += new System.EventHandler(this.ButtonAvg_Click);
            // 
            // ButtonCount
            // 
            this.ButtonCount.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonCount.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonCount.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonCount.BorderRadius = 27;
            this.ButtonCount.BorderSize = 0;
            this.ButtonCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCount.FlatAppearance.BorderSize = 0;
            this.ButtonCount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.ButtonCount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.ButtonCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCount.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCount.ForeColor = System.Drawing.Color.White;
            this.ButtonCount.Location = new System.Drawing.Point(759, 101);
            this.ButtonCount.Name = "ButtonCount";
            this.ButtonCount.Size = new System.Drawing.Size(169, 58);
            this.ButtonCount.TabIndex = 27;
            this.ButtonCount.Text = "Подсчет";
            this.ButtonCount.TextColor = System.Drawing.Color.White;
            this.ButtonCount.UseVisualStyleBackColor = false;
            this.ButtonCount.Click += new System.EventHandler(this.ButtonCount_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(296, 265);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(86, 40);
            this.labelTitle.TabIndex = 28;
            this.labelTitle.Text = "label1";
            this.labelTitle.Visible = false;
            // 
            // TotalsAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 649);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.ButtonCount);
            this.Controls.Add(this.ButtonAvg);
            this.Controls.Add(this.ButtonMax);
            this.Controls.Add(this.ButtonMin);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TotalsAlbumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TotalsAlbumForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private RJButton ButtonMin;
        private RJButton ButtonMax;
        private RJButton ButtonAvg;
        private RJButton ButtonCount;
        private System.Windows.Forms.Label labelTitle;
    }
}