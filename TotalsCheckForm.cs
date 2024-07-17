using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseAlbum
{
    public partial class TotalsCheckForm : Form
    {
        private Database database = new Database();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public TotalsCheckForm()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // check if the click was on the title bar
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
                }
            }
        }

        private void ButtonBestSelling_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Самый(ые) продаваемый(ые) альбом(ы)";
            labelTitle.Visible = true;

            try
            {
                string sql = @"SELECT album_name, artist_name, SUM(number_of_albums) AS TotalSales
                               FROM ViewAlbumChek
                               GROUP BY album_name, artist_name
                               HAVING SUM(number_of_albums) = (SELECT MAX(AlbumsSales)
                                                               FROM (SELECT SUM(number_of_albums) AS AlbumsSales
                                                                     FROM ViewAlbumChek
                                                                     GROUP BY album_name, artist_name) AS Sales)";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    dataGridView.Columns.Clear();
                    dataGridView.Rows.Clear();
                    dataGridView.Columns.Add("AlbumName", "Название");
                    dataGridView.Columns.Add("ArtistName", "Исполнитель");
                    dataGridView.Columns.Add("TotalSales", "Общее количество продаж");

                    while (reader.Read())
                    {
                        string albumName = reader["album_name"].ToString();
                        string artistName = reader["artist_name"].ToString();
                        int totalSales = Convert.ToInt32(reader["TotalSales"]);

                        dataGridView.Rows.Add(albumName, artistName, totalSales);
                    }
                    NumberingRow();
                    dataGridView.Visible = true;
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NumberingRow()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void ButtonEarnings_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Статистика продаж альбомов по артистам";
            labelTitle.Visible = true;

            try
            {
                string sql = @"SELECT artist_name, 
                                      SUM(number_of_albums) AS SoldUnits, 
                                      SUM(TotalCount) AS TotalSales
                               FROM ViewAlbumChek
                               GROUP BY artist_name";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    dataGridView.Columns.Clear();
                    dataGridView.Rows.Clear();
                    dataGridView.Columns.Add("ArtistName", "Исполнитель");
                    dataGridView.Columns.Add("SoldUnits", "Количество проданных альбомов");
                    dataGridView.Columns.Add("TotalSales", "Общая сумма(лей)");

                    while (reader.Read())
                    {
                        string artistName = reader["artist_name"].ToString();
                        int soldUnits = Convert.ToInt32(reader["SoldUnits"]);
                        decimal totalSales = Convert.ToDecimal(reader["TotalSales"]);

                        dataGridView.Rows.Add(artistName, soldUnits, totalSales);
                    }
                    NumberingRow();
                    dataGridView.Visible = true;
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
