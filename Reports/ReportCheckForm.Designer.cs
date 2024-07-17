namespace DatabaseAlbum.Reports
{
    partial class ReportCheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCheckForm));
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ordersInfoDataSet = new DatabaseAlbum.OrdersInfoDataSet();
            this.viewAlbumChekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewAlbumChekTableAdapter = new DatabaseAlbum.OrdersInfoDataSetTableAdapters.ViewAlbumChekTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ordersInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAlbumChekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "OrdersInfoDataSet";
            reportDataSource1.Value = this.viewAlbumChekBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "DatabaseAlbum.Reports.CheckInfoReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(819, 481);
            this.reportViewer.TabIndex = 0;
            // 
            // ordersInfoDataSet
            // 
            this.ordersInfoDataSet.DataSetName = "OrdersInfoDataSet";
            this.ordersInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewAlbumChekBindingSource
            // 
            this.viewAlbumChekBindingSource.DataMember = "ViewAlbumChek";
            this.viewAlbumChekBindingSource.DataSource = this.ordersInfoDataSet;
            // 
            // viewAlbumChekTableAdapter
            // 
            this.viewAlbumChekTableAdapter.ClearBeforeFill = true;
            // 
            // ReportCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 481);
            this.Controls.Add(this.reportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportCheckForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportCheckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAlbumChekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private OrdersInfoDataSet ordersInfoDataSet;
        private System.Windows.Forms.BindingSource viewAlbumChekBindingSource;
        private OrdersInfoDataSetTableAdapters.ViewAlbumChekTableAdapter viewAlbumChekTableAdapter;
    }
}