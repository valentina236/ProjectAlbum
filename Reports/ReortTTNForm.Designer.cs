namespace DatabaseAlbum.Reports
{
    partial class ReortTTNForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReortTTNForm));
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tTNDataSet = new DatabaseAlbum.TTNDataSet();
            this.viewAlbumTTNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewAlbumTTNTableAdapter = new DatabaseAlbum.TTNDataSetTableAdapters.ViewAlbumTTNTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tTNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAlbumTTNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TTNInfoDataSet";
            reportDataSource1.Value = this.viewAlbumTTNBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "DatabaseAlbum.Reports.TTNInfoReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(808, 473);
            this.reportViewer.TabIndex = 0;
            // 
            // tTNDataSet
            // 
            this.tTNDataSet.DataSetName = "TTNDataSet";
            this.tTNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewAlbumTTNBindingSource
            // 
            this.viewAlbumTTNBindingSource.DataMember = "ViewAlbumTTN";
            this.viewAlbumTTNBindingSource.DataSource = this.tTNDataSet;
            // 
            // viewAlbumTTNTableAdapter
            // 
            this.viewAlbumTTNTableAdapter.ClearBeforeFill = true;
            // 
            // ReortTTNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 473);
            this.Controls.Add(this.reportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReortTTNForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReortTTNForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tTNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAlbumTTNBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private TTNDataSet tTNDataSet;
        private System.Windows.Forms.BindingSource viewAlbumTTNBindingSource;
        private TTNDataSetTableAdapters.ViewAlbumTTNTableAdapter viewAlbumTTNTableAdapter;
    }
}