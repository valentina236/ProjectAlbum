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
    public partial class SellerForm : Form
    {
        private Database database = new Database();
        string mode = "";

        public SellerForm()
        {
            InitializeComponent();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonAlbum_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ViewAlbumInfo";
            ShowAlbums(sql);
        }

        private void ShowAlbums(string sql)
        {
            try
            {
                mode = "album";
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
                    ButtonAdd.Visible = false;
                    TextBoxSearch.Visible = true;
                    ButtonSearch.Visible = true;
                    pictureBoxFilter.Visible = true;
                    pictureBoxWelcome.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NumberingRow()
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

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ViewAlbumChek";
            ShowCheck(sql);
        }

        public void ShowHeadersCheck()
        {
            dataGridView.Columns[0].HeaderText = "Номер покупки";
            dataGridView.Columns[0].Width = 120;
            dataGridView.Columns[1].HeaderText = "Дата покупки";
            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[2].HeaderText = "Время покупки";
            dataGridView.Columns[2].Width = 130;
            dataGridView.Columns[3].HeaderText = "Название альбома";
            dataGridView.Columns[3].Width = 300;
            dataGridView.Columns[4].HeaderText = "Исполнитель";
            dataGridView.Columns[5].HeaderText = "Цена за единицу(лей)";
            dataGridView.Columns[6].HeaderText = "Кол-во";
            dataGridView.Columns[6].Width = 130;
            dataGridView.Columns[7].HeaderText = "Общая сумма(лей)";
        }

        public void ShowCheck(string sql)
        {
            try
            {
                mode = "check";
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "ChecksData");
                    dataGridView.Visible = true;
                    dataGridView.DataSource = ds;
                    dataGridView.DataMember = "ChecksData";
                    NumberingRow();
                    ShowHeadersCheck();
                    connection.Close();
                    ButtonAdd.Visible = true;
                    TextBoxSearch.Visible = true;
                    ButtonSearch.Visible = true;
                    pictureBoxFilter.Visible = false;
                    pictureBoxWelcome.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string row = "";
            if (mode == "check")
            {
                AddChekForm f = new AddChekForm();
                f.ShowDialog();
                string sql = "SELECT * FROM ViewAlbumChek";
                ShowCheck(sql);
            }

            string[] data;
            if (!string.IsNullOrEmpty(row))
            {
                data = row.Split(';');
                DataSet ds = new DataSet();
                ds = (DataSet)(dataGridView.DataSource);
                DataTable dt = ds.Tables[0];
                dt.Rows.Add(data);
                NumberingRow();
            }
            else return;
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
                if (mode == "album")
                {
                    sql = "SELECT * FROM ViewAlbumInfo";
                    ShowAlbums(sql);
                }
                if (mode == "check")
                {
                    sql = "SELECT * FROM ViewAlbumChek";
                    ShowCheck(sql);
                }
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (mode == "album")
            {
                string sql = $"SELECT * FROM ViewAlbumInfo WHERE CONCAT (album_cod, album_name, release_date, artist_name, manufacturer_name, format_name, genre_name, typeName, unit_price) LIKE '%{TextBoxSearch.Texts}%'";
                ShowAlbums(sql);
            }
            if (mode == "check")
            {
                string sql = $"SELECT * FROM ViewAlbumChek WHERE CONCAT (check_number, date_of_sale, album_name, artist_name, unit_price, number_of_albums, TotalCount) LIKE '%{TextBoxSearch.Texts}%'";
                ShowCheck(sql);
            }
        }

        private void pictureBoxFilter_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panelFilter.Visible = true;
            DatabaseMethods.fillFormatComboBox(ComboBoxFormat);
            DatabaseMethods.fillGenreComboBox(ComboBoxGenre);
            DatabaseMethods.fillTypeComboBox(ComboBoxType);
            DatabaseMethods.fillAlbumComboBox(ComboBoxAlbum);
            ClearAll();
        }

        private void ButtonFilterClose_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = false;
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

        public void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
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
            string info = "Раздел \"Альбомы\" - предназначен для отображения полной информации об альбомах\n\n" +
                           "Раздел \"Покупки\" - предназначен для отображения полной информации\n о покупках, осуществленных в магазин покупателями\n\n";
            HelpForm f = new HelpForm(info);
            f.Height = 522;
            f.Width = 1007;
            f.ShowDialog();
        }
    }
}