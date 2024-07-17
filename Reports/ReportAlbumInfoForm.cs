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
    public partial class ReportAlbumInfoForm : Form
    {
        public ReportAlbumInfoForm()
        {
            InitializeComponent();
        }

        private void ReportAlbumInfoForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "albumInfoDataSet.ViewAlbumInfo". При необходимости она может быть перемещена или удалена.
            this.viewAlbumInfoTableAdapter.Fill(this.albumInfoDataSet.ViewAlbumInfo);

            this.reportViewer.RefreshReport();
        }
    }
}
