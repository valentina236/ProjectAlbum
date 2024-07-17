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
    public partial class ReportCheckForm : Form
    {
        public ReportCheckForm()
        {
            InitializeComponent();
        }

        private void ReportCheckForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ordersInfoDataSet.ViewAlbumChek". При необходимости она может быть перемещена или удалена.
            this.viewAlbumChekTableAdapter.Fill(this.ordersInfoDataSet.ViewAlbumChek);

            this.reportViewer.RefreshReport();
        }
    }
}
