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
    public partial class TotalsAlbumForm : Form
    {
        private Database database = new Database();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public TotalsAlbumForm()
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

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Самый дешевый альбом";
            labelTitle.Visible = true;

            try
            {
                string sql = "SELECT album_name, artist_name, unit_price " +
                             "FROM ViewAlbumInfo " +
                             "WHERE unit_price = (SELECT MIN(unit_price) FROM ViewAlbumInfo)";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        dataGridView.Columns.Clear();
                        dataGridView.Rows.Clear();
                        dataGridView.Columns.Add("AlbumName", "Название");
                        dataGridView.Columns.Add("ArtistName", "Исполнитель");
                        dataGridView.Columns.Add("UnitPrice", "Цена за единицу(лей)");

                        string albumName = reader["album_name"].ToString();
                        string artistName = reader["artist_name"].ToString();
                        decimal unitPrice = Convert.ToDecimal(reader["unit_price"]);

                        dataGridView.Rows.Add(albumName, artistName, unitPrice);
                        NumberingRow();
                        dataGridView.Visible = true;
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonMax_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Самый дорогой альбом";
            labelTitle.Visible = true;

            try
            {
                string sql = "SELECT album_name, artist_name, unit_price " +
                             "FROM ViewAlbumInfo " +
                             "WHERE unit_price = (SELECT Max(unit_price) FROM ViewAlbumInfo)";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        dataGridView.Columns.Clear();
                        dataGridView.Rows.Clear();
                        dataGridView.Columns.Add("AlbumName", "Название");
                        dataGridView.Columns.Add("ArtistName", "Исполнитель");
                        dataGridView.Columns.Add("UnitPrice", "Цена за единицу(лей)");

                        string albumName = reader["album_name"].ToString();
                        string artistName = reader["artist_name"].ToString();
                        decimal unitPrice = Convert.ToDecimal(reader["unit_price"]);

                        dataGridView.Rows.Add(albumName, artistName, unitPrice);
                        NumberingRow();
                        dataGridView.Visible = true;
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void ButtonAvg_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Средняя цена альбомов";
            labelTitle.Visible = true;
            try
            {
                string sql = "SELECT AVG(unit_price) AS AvgPrice FROM ViewAlbumInfo";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        decimal averagePrice = Convert.ToDecimal(result);
                        string formattedAveragePrice = averagePrice.ToString("N3");
                        dataGridView.Columns.Clear();
                        dataGridView.Columns.Add("AvgPrice", "Средняя цена(лей)");
                        dataGridView.Rows.Clear();
                        dataGridView.Rows.Add(formattedAveragePrice);
                        NumberingRow();
                        dataGridView.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Средняя цена не найдена.");
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCount_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Количество альбомов каждого жанра";
            labelTitle.Visible = true;
            try
            {
                string sql = "SELECT genre_name, COUNT(*) AS CountOfAlbums " +
                             "FROM ViewAlbumInfo " +
                             "GROUP BY genre_name";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    dataGridView.Columns.Clear();
                    dataGridView.Rows.Clear();
                    dataGridView.Columns.Add("GenreName", "Жанр");
                    dataGridView.Columns.Add("CountOfAlbums", "Количество альбомов");

                    while (reader.Read())
                    {
                        string genreName = reader["genre_name"].ToString();
                        int countOfAlbums = Convert.ToInt32(reader["CountOfAlbums"]);

                        dataGridView.Rows.Add(genreName, countOfAlbums);
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
