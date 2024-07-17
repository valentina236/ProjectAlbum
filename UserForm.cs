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
    public partial class UserForm : Form
    {
        private Database database = new Database();

        public UserForm()
        {
            InitializeComponent();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowAlbums(string sql)
        {
            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "AlbumsData");
                    dataGridView.Visible = true;
                    dataGridView.DataSource = ds;
                    dataGridView.DataMember = "AlbumsData";
                    dataGridView.Columns[0].Visible = false;
                    NumberingRow();
                    ShowHeadersAlbum();
                    connection.Close();
                    TextBoxSearch.Visible = true;
                    ButtonSearch.Visible = true;
                    pictureBoxFilter.Visible = true;
                    pictureBoxWelcome.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Не удалось подключится к базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumberingRow()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        public void ShowHeadersAlbum()
        {
            dataGridView.Columns[1].HeaderText = "Название";
            dataGridView.Columns[2].HeaderText = "Дата выпуска";
            dataGridView.Columns[3].HeaderText = "Исполнитель";
            dataGridView.Columns[4].HeaderText = "Производитель";
            dataGridView.Columns[5].HeaderText = "Формат";
            dataGridView.Columns[6].HeaderText = "Жанр";
            dataGridView.Columns[7].HeaderText = "Тип";
            dataGridView.Columns[8].HeaderText = "Цена за единицу(лей)";
        }

        private void ButtonAlbum_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ViewAlbumInfo";
            ShowAlbums(sql);
        }

        private void TextBoxSearch__TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (TextBoxSearch.Texts.Length != 0)
            {
                ButtonSearch.Enabled = true;
            }
            else
            {
                ButtonSearch.Enabled = false;
                sql = "SELECT * FROM ViewAlbumInfo";
                ShowAlbums(sql);
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM ViewAlbumInfo WHERE CONCAT (album_cod, album_name, release_date, artist_name, manufacturer_name, format_name, genre_name, typeName, unit_price) LIKE '%{TextBoxSearch.Texts}%'";
            ShowAlbums(sql);
        }

        private void pictureBoxFilter_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel2.Dock = DockStyle.None;
            panelFilter.Dock = DockStyle.Left;
            panelFilter.Visible = true;
            fillFormatComboBox();
            fillGenreComboBox();
            fillTypeComboBox();
            fillAlbumComboBox();
            ClearAll();
        }

        public void fillFormatComboBox()
        {
            try
            {
                string sql = "SELECT DISTINCT  cod_format, format_name FROM Album_format";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "format_data");
                    ComboBoxFormat.ValueMember = "cod_format";
                    ComboBoxFormat.DisplayMember = "format_name";
                    ComboBoxFormat.DataSource = ds.Tables["format_data"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillGenreComboBox()
        {
            try
            {
                string sql = "SELECT DISTINCT  cod_genre, genre_name FROM Album_genre";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "genre_data");
                    ComboBoxGenre.ValueMember = "cod_genre";
                    ComboBoxGenre.DisplayMember = "genre_name";
                    ComboBoxGenre.DataSource = ds.Tables["genre_data"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillTypeComboBox()
        {
            try
            {
                string sql = "SELECT DISTINCT cod_type, typeName FROM Album_type";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "type_data");
                    ComboBoxType.ValueMember = "cod_type";
                    ComboBoxType.DisplayMember = "typeName";
                    ComboBoxType.DataSource = ds.Tables["type_data"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillAlbumComboBox()
        {
            try
            {
                string sql = "SELECT DISTINCT album_cod, album_name FROM Album";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "album_data");
                    ComboBoxAlbum.ValueMember = "album_cod";
                    ComboBoxAlbum.DisplayMember = "album_name";
                    ComboBoxAlbum.DataSource = ds.Tables["album_data"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonFilterClose_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = false;
            panelFilter.Dock = DockStyle.None;
            panel2.Dock = DockStyle.Left;
            panel2.Visible = true;
            string sql = "SELECT * FROM ViewAlbumInfo";
            ShowAlbums(sql);
        }

        void ClearAll()
        {
            ComboBoxAlbum.SelectedIndex = -1;
            ComboBoxArtist.SelectedIndex = -1;
            ComboBoxManufacter.SelectedIndex = -1;
            ComboBoxFormat.SelectedIndex = -1;
            ComboBoxGenre.SelectedIndex = -1;
            ComboBoxType.SelectedIndex = -1;
            TextBoxPrice1.Clear();
            TextBoxPrice2.Clear();

            string sql = "SELECT * FROM ViewAlbumInfo";
            ShowAlbums(sql);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ApplyFilters()
        {
            string albumsFilter = "", artistFilter = "", ManufacterFilter = "", FormatFilter = "", GenreFilter = "", TypeFilter = "", PriceFilter = "";

            if (ComboBoxAlbum.SelectedIndex != -1)
            {
                albumsFilter = $"album_name = '{ComboBoxAlbum.GetItemText(ComboBoxAlbum.SelectedItem)}'";
            }

            if (ComboBoxArtist.SelectedIndex != -1)
            {
                artistFilter = $"artist_name = '{ComboBoxArtist.GetItemText(ComboBoxArtist.SelectedItem)}'";
            }

            if (ComboBoxManufacter.SelectedIndex != -1)
            {
                ManufacterFilter = $"manufacturer_name = '{ComboBoxManufacter.GetItemText(ComboBoxManufacter.SelectedItem)}'";
            }

            if (ComboBoxFormat.SelectedIndex != -1)
            {
                FormatFilter = $"format_name = '{ComboBoxFormat.GetItemText(ComboBoxFormat.SelectedItem)}'";
            }

            if (ComboBoxGenre.SelectedIndex != -1)
            {
                GenreFilter = $"genre_name = '{ComboBoxGenre.GetItemText(ComboBoxGenre.SelectedItem)}'";
            }

            if (ComboBoxType.SelectedIndex != -1)
            {
                TypeFilter = $"typeName = '{ComboBoxType.GetItemText(ComboBoxType.SelectedItem)}'";
            }

            if (!string.IsNullOrEmpty(TextBoxPrice1.Texts) || !string.IsNullOrEmpty(TextBoxPrice2.Texts))
            {
                double price1 = 0, price2 = 0;
                string unitPrice1 = TextBoxPrice1.Texts.Replace(",", ".");
                string unitPrice2 = TextBoxPrice2.Texts.Replace(",", ".");
                bool validPrice1 = double.TryParse(unitPrice1, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out price1);
                bool validPrice2 = double.TryParse(unitPrice2, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out price2);

                if (validPrice1 && validPrice2)
                {
                    PriceFilter = $"unit_price BETWEEN '{unitPrice1}' AND '{unitPrice2}'";
                }
                else if (validPrice1)
                {
                    PriceFilter = $"unit_price >= '{unitPrice1}'";
                }
                else if (validPrice2)
                {
                    PriceFilter = $"unit_price <= '{unitPrice2}'";
                }
            }

            string sql = "SELECT * FROM ViewAlbumInfo WHERE ";
            List<string> filters = new List<string> { albumsFilter, artistFilter, ManufacterFilter, FormatFilter, GenreFilter, TypeFilter, PriceFilter };
            filters.RemoveAll(string.IsNullOrEmpty);
            if (filters.Count > 0)
            {
                sql += string.Join(" AND ", filters);
            }
            else
            {
                sql += "1=1";
            }

            ShowAlbums(sql);
        }

        private void TextBoxPrice_Leave(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void TextBoxPrice__TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            RJTextBox rjTextBox = (RJTextBox)sender;
            if (e.KeyChar == '.') e.KeyChar = ',';

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == ',' && rjTextBox.Texts.IndexOf(',') > -1)
                e.Handled = true;
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            string info = "Раздел \"Альбомы\" - предназначен для отображения полной информации об альбомах\n\n";
            HelpForm f = new HelpForm(info);
            f.Height = 522;
            f.Width = 1007;
            f.ShowDialog();
        }
    }
}