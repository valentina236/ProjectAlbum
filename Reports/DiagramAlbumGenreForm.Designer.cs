namespace DatabaseAlbum.Reports
{
    partial class DiagramAlbumGenreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagramAlbumGenreForm));
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewAlbumInfoTableAdapter = new DatabaseAlbum.AlbumInfoDataSetTableAdapters.ViewAlbumInfoTableAdapter();
            this.albumInfoDataSet = new DatabaseAlbum.AlbumInfoDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.albumInfoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.LocalReport.ReportEmbeddedResource = "DatabaseAlbum.Reports.DiagramReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(995, 634);
            this.reportViewer.TabIndex = 0;
            // 
            // viewAlbumInfoTableAdapter
            // 
            this.viewAlbumInfoTableAdapter.ClearBeforeFill = true;
            // 
            // albumInfoDataSet
            // 
            this.albumInfoDataSet.DataSetName = "AlbumInfoDataSet";
            this.albumInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DiagramAlbumGenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 634);
            this.Controls.Add(this.reportViewer);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DiagramAlbumGenreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Диаграмма";
            this.Load += new System.EventHandler(this.DiagramAlbumGenreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.albumInfoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private AlbumInfoDataSetTableAdapters.ViewAlbumInfoTableAdapter viewAlbumInfoTableAdapter;
        private AlbumInfoDataSet albumInfoDataSet;
    }
}