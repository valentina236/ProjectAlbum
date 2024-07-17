namespace DatabaseAlbum.Reports
{
    partial class ReportAlbumInfoForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportAlbumInfoForm));
            this.viewAlbumInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumInfoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumInfoDataSet = new DatabaseAlbum.AlbumInfoDataSet();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewAlbumInfoTableAdapter = new DatabaseAlbum.AlbumInfoDataSetTableAdapters.ViewAlbumInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewAlbumInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumInfoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumInfoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAlbumInfoBindingSource
            // 
            this.viewAlbumInfoBindingSource.DataMember = "ViewAlbumInfo";
            this.viewAlbumInfoBindingSource.DataSource = this.albumInfoDataSetBindingSource;
            // 
            // albumInfoDataSetBindingSource
            // 
            this.albumInfoDataSetBindingSource.DataSource = this.albumInfoDataSet;
            this.albumInfoDataSetBindingSource.Position = 0;
            // 
            // albumInfoDataSet
            // 
            this.albumInfoDataSet.DataSetName = "AlbumInfoDataSet";
            this.albumInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetAlbumInfo";
            reportDataSource1.Value = this.viewAlbumInfoBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "DatabaseAlbum.AlbumReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(823, 499);
            this.reportViewer.TabIndex = 0;
            // 
            // viewAlbumInfoTableAdapter
            // 
            this.viewAlbumInfoTableAdapter.ClearBeforeFill = true;
            // 
            // ReportAlbumInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 499);
            this.Controls.Add(this.reportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportAlbumInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportAlbumInfoForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.viewAlbumInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumInfoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumInfoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource albumInfoDataSetBindingSource;
        private AlbumInfoDataSet albumInfoDataSet;
        private System.Windows.Forms.BindingSource viewAlbumInfoBindingSource;
        private AlbumInfoDataSetTableAdapters.ViewAlbumInfoTableAdapter viewAlbumInfoTableAdapter;
    }
}