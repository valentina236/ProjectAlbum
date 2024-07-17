using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseAlbum.Reports
{
    public partial class DiagramAlbumGenreForm : Form
    {
        public DiagramAlbumGenreForm()
        {
            InitializeComponent();
        }

        private void DiagramAlbumGenreForm_Load(object sender, EventArgs e)
        {
            var myDataTable = (DataTable)this.albumInfoDataSet.ViewAlbumInfo;
            ReportDataSource rds = new ReportDataSource("DiagramDataSet", myDataTable as DataTable);

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);

            viewAlbumInfoTableAdapter.Fill(albumInfoDataSet.ViewAlbumInfo);

            this.reportViewer.RefreshReport();
        }
    }
}
