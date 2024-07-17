using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DatabaseAlbum
{
    public partial class Form1 : Form
    {
        private Database database = new Database();
        string mode = "";
        int index;
        private Size originalSize;
        private Point originalLocation;

        public Form1()
        {
            InitializeComponent();
            originalSize = dataGridView.Size;
            originalLocation = dataGridView.Location;
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
                    ButtonAdd.Visible = true;
                    TextBoxSearch.Visible = true;
                    ButtonSearch.Visible = true;
                    pictureBoxFilter.Visible = true;
                    ButtonCount.Visible = true;
                    panelReports.Visible = false;
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
            dataGridView.Size = originalSize;
            dataGridView.Location = originalLocation;
        }

        private void ButtonProvider_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Providerr";
            ShowProviders(sql);
        }

        private void ShowProviders(string sql)
        {
            try
            {
                mode = "provider";
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "ProvidersData");
                    dataGridView.Visible = true;
                    dataGridView.DataSource = ds;
                    dataGridView.DataMember = "ProvidersData";
                    dataGridView.Columns[0].Visible = false;
                    NumberingRow();
                    ShowHeadersProvider();
                    connection.Close();
                    ButtonAdd.Visible = true;
                    TextBoxSearch.Visible = true;
                    ButtonSearch.Visible = true;
                    pictureBoxFilter.Visible = false;
                    ButtonCount.Visible = false;
                    panelReports.Visible = false;
                    pictureBoxWelcome.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowHeadersProvider()
        {
            dataGridView.Columns[1].HeaderText = "Название";
            dataGridView.Columns[2].HeaderText = "Адрес";
            dataGridView.Columns[3].HeaderText = "Телефон";
            dataGridView.Columns[4].HeaderText = "Расчётный счет";
            dataGridView.Size = originalSize;
            dataGridView.Location = originalLocation;
        }

        private void ButtonTTN_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ViewAlbumTTN";
            ShowTTN(sql);
        }

        public void ShowHeadersTTN()
        {
            dataGridView.Columns[0].HeaderText = "Номер документа";
            dataGridView.Columns[0].Width = 130;
            dataGridView.Columns[1].HeaderText = "Дата поставки";
            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[2].HeaderText = "Имя поставщика";
            dataGridView.Columns[3].HeaderText = "Название альбома";
            dataGridView.Columns[3].Width = 300;
            dataGridView.Columns[4].HeaderText = "Исполнитель";
            dataGridView.Columns[5].HeaderText = "Цена за единицу(лей)";
            dataGridView.Columns[6].HeaderText = "Кол-во";
            dataGridView.Columns[6].Width = 120;
            dataGridView.Columns[7].HeaderText = "Общая сумма(лей)";
            dataGridView.Size = originalSize;
            dataGridView.Location = originalLocation;
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
            dataGridView.Size = originalSize;
            dataGridView.Location = originalLocation;
        }

        private void ButtonUcet_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ViewAlbumJurnal";
            ShowUcet(sql);
        }

        public void ShowHeadersUcet()
        {
            dataGridView.Columns[0].HeaderText = "Месяц";
            dataGridView.Columns[1].HeaderText = "Название альбома";
            dataGridView.Columns[2].HeaderText = "Исполнитель";
            dataGridView.Columns[3].HeaderText = "Кол-во поставленных альбомов";
            dataGridView.Columns[4].HeaderText = "Кол-во проданных альбомов";
            dataGridView.Columns[5].HeaderText = "Остаток";
            dataGridView.Size = originalSize;
            dataGridView.Location = originalLocation;
        }

        private void форматыАльбомовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Album_format";
            ShowAlbumsFormat(sql);
        }

        private void ShowAlbumsFormat(string sql)
        {
            try
            {
                mode = "format";
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "AlbumsFormat");
                    dataGridView.Visible = true;
                    dataGridView.DataSource = ds;
                    dataGridView.DataMember = "AlbumsFormat";
                    dataGridView.Columns[0].Visible = false;
                    NumberingRow();
                    ShowHeadersAlbumsDetails("Название формата");
                    connection.Close();
                    ButtonAdd.Visible = false;
                    TextBoxSearch.Visible = true;
                    ButtonSearch.Visible = true;
                    pictureBoxFilter.Visible = false;
                    ButtonCount.Visible = false;
                    panelReports.Visible = false;
                    pictureBoxWelcome.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowHeadersAlbumsDetails(string name)
        {
            dataGridView.Columns[1].HeaderText = name;
            dataGridView.Width = 600;
            dataGridView.Height = 500;
            dataGridView.Location = new Point(624, 252);
        }

        private void типыАльбомовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Album_type";
            ShowAlbumsType(sql);
        }

        private void ShowAlbumsGenre(string sql)
        {
            try
            {
                mode = "genre";
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "AlbumsGenre");
                    dataGridView.Visible = true;
                    dataGridView.DataSource = ds;
                    dataGridView.DataMember = "AlbumsGenre";
                    dataGridView.Columns[0].Visible = false;
                    NumberingRow();
                    ShowHeadersAlbumsDetails("Название жанра");
                    connection.Close();
                    ButtonAdd.Visible = false;
                    TextBoxSearch.Visible = true;
                    ButtonSearch.Visible = true;
                    pictureBoxFilter.Visible = false;
                    ButtonCount.Visible = false;
                    panelReports.Visible = false;
                    pictureBoxWelcome.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void жанрыАльбомовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Album_genre";
            ShowAlbumsGenre(sql);
        }

        private void ShowAlbumsType(string sql)
        {
            try
            {
                mode = "genre";
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "AlbumsType");
                    dataGridView.Visible = true;
                    dataGridView.DataSource = ds;
                    dataGridView.DataMember = "AlbumsType";
                    dataGridView.Columns[0].Visible = false;
                    NumberingRow();
                    ShowHeadersAlbumsDetails("Название типа");
                    connection.Close();
                    ButtonAdd.Visible = false;
                    TextBoxSearch.Visible = true;
                    ButtonSearch.Visible = true;
                    pictureBoxFilter.Visible = false;
                    ButtonCount.Visible = false;
                    panelReports.Visible = false;
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
            if (mode == "album")
            {
                AddAlbumForm f = new AddAlbumForm();
                f.ShowDialog();
                row = f.GetData();
            }
            if (mode == "provider")
            {
                AddProviderForm f = new AddProviderForm();
                f.ShowDialog();
                row = f.GetData();
            }
            if (mode == "ttn")
            {
                AddTTNForm f = new AddTTNForm();
                f.ShowDialog();
                string sql = "SELECT * FROM ViewAlbumTTN";
                ShowTTN(sql);
            }
            if (mode == "check")
            {
                AddChekForm f = new AddChekForm();
                f.ShowDialog();
                string sql = "SELECT * FROM ViewAlbumChek";
                ShowCheck(sql);
            }
            if (mode == "ucet")
            {
                AddJurnalUceta f = new AddJurnalUceta();
                f.ShowDialog();
                string sql = "SELECT * FROM ViewAlbumJurnal";
                ShowUcet(sql);
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

        public void ShowTTN(string sql)
        {
            try
            {
                mode = "ttn";
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "TTNData");
                    dataGridView.Visible = true;
                    dataGridView.DataSource = ds;
                    dataGridView.DataMember = "TTNData";
                    NumberingRow();
                    ShowHeadersTTN();
                    connection.Close();
                    ButtonAdd.Visible = true;
                    TextBoxSearch.Visible = true;
                    ButtonSearch.Visible = true;
                    pictureBoxFilter.Visible = false;
                    ButtonCount.Visible = false;
                    panelReports.Visible = false;
                    pictureBoxWelcome.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    ButtonCount.Visible = true;
                    panelReports.Visible = false;
                    pictureBoxWelcome.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowUcet(string sql)
        {
            try
            {
                mode = "ucet";
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "UcetData");
                    dataGridView.Visible = true;
                    dataGridView.DataSource = ds;
                    dataGridView.DataMember = "UcetData";
                    NumberingRow();
                    ShowHeadersUcet();
                    connection.Close();
                    ButtonAdd.Visible = true;
                    TextBoxSearch.Visible = true;
                    ButtonSearch.Visible = true;
                    pictureBoxFilter.Visible = false;
                    ButtonCount.Visible = false;
                    panelReports.Visible = false;
                    pictureBoxWelcome.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            index = dataGridView.SelectedCells[0].RowIndex;
            if(mode!="format" && mode!= "genre" && mode != "type")
            {
                ButtonDelete.Visible = true;
                ButtonEdit.Visible = true;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < dataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[index];

                DialogResult result = MessageBox.Show(
                    "Удалить информацию?",
                    "Удаление",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    if (mode == "provider")
                    {
                        int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                        try
                        {
                            using (var connection = database.GetConnection())
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand("DeleteRecordsProvider", connection))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@recordID", id);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Запись успешно удалена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"{ex.Message}", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (mode == "album")
                    {
                        int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                        try
                        {
                            using (var connection = database.GetConnection())
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand("DeleteRecordsAlbum", connection))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@recordID", id);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Запись успешно удалена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"{ex.Message}", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (mode == "ttn")
                    {
                        int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                        try
                        {
                            using (var connection = database.GetConnection())
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand("DeleteRecordsTTN", connection))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@recordID", id);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Запись успешно удалена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"{ex.Message}", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (mode == "check")
                    {
                        int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                        try
                        {
                            using (var connection = database.GetConnection())
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand("DeleteRecordsCheck", connection))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@recordID", id);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Запись успешно удалена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"{ex.Message}", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (mode == "ucet")
                    {
                        string month = selectedRow.Cells[0].Value.ToString();
                        string album = selectedRow.Cells[1].Value.ToString();
                        try
                        {
                            using (var connection = database.GetConnection())
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand("DeleteRecordsUcet", connection))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@month", month);
                                    command.Parameters.AddWithValue("@name", album);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Запись успешно удалена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"{ex.Message}", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    DataSet ds = new DataSet();
                    ds = (DataSet)(dataGridView.DataSource);
                    DataTable dt = ds.Tables[0];
                    dt.Rows.RemoveAt(index);
                    dataGridView.DataSource = ds;
                    NumberingRow();
                }
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
                if (mode == "provider")
                {
                    sql = "SELECT * FROM Providerr";
                    ShowProviders(sql);
                }
                if (mode == "album")
                {
                    sql = "SELECT * FROM ViewAlbumInfo";
                    ShowAlbums(sql);
                }
                if (mode == "ttn")
                {
                    sql = "SELECT * FROM ViewAlbumTTN";
                    ShowTTN(sql);
                }
                if (mode == "check")
                {
                    sql = "SELECT * FROM ViewAlbumChek";
                    ShowCheck(sql);
                }
                if (mode == "ucet")
                {
                    sql = "SELECT * FROM ViewAlbumJurnal";
                    ShowUcet(sql);
                }
                if (mode == "format")
                {
                    sql = "SELECT * FROM Album_format";
                    ShowAlbumsFormat(sql);
                }
                if (mode == "genre")
                {
                    sql = "SELECT * FROM Album_genre";
                    ShowAlbumsGenre(sql);
                }
                if (mode == "type")
                {
                    sql = "SELECT * FROM Album_type";
                    ShowAlbumsType(sql);
                }
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if(mode == "provider")
            {
                string sql = $"SELECT * FROM Providerr WHERE CONCAT(provider_cod, provider_name, addres, phone_fax, rascet_scet) LIKE '%{TextBoxSearch.Texts}%'";
                ShowProviders(sql);
            }
            if (mode == "album")
            {
                string sql = $"SELECT * FROM ViewAlbumInfo WHERE CONCAT (album_cod, album_name, release_date, artist_name, manufacturer_name, format_name, genre_name, typeName, unit_price) LIKE '%{TextBoxSearch.Texts}%'";
                ShowAlbums(sql);
            }
            if (mode == "ttn")
            {
                string sql = $"SELECT * FROM ViewAlbumTTN WHERE CONCAT (num_doc, date_post, provider_name, album_name, artist_name, unit_price, number_of_albums, TotalCount) LIKE '%{TextBoxSearch.Texts}%'";
                ShowTTN(sql);
            }
            if (mode == "check")
            {
                string sql = $"SELECT * FROM ViewAlbumChek WHERE CONCAT (check_number, date_of_sale, album_name, artist_name, unit_price, number_of_albums, TotalCount) LIKE '%{TextBoxSearch.Texts}%'";
                ShowCheck(sql);
            }
            if (mode == "ucet")
            {
                string sql = $"SELECT * FROM ViewAlbumJurnal WHERE CONCAT (month_name, album_name, artist_name, NumbeOfDeliveredAlbums, remainder) LIKE '%{TextBoxSearch.Texts}%'";
                ShowUcet(sql);
            }
            if (mode == "format")
            {
                string sql = $"SELECT * FROM Album_format WHERE format_name LIKE '%{TextBoxSearch.Texts}%'";
                ShowAlbumsFormat(sql);
            }
            if (mode == "genre")
            {
                string sql = $"SELECT * FROM Album_genre WHERE genre_name LIKE '%{TextBoxSearch.Texts}%'";
                ShowAlbumsGenre(sql);
            }
            if (mode == "type")
            {
                string sql = $"SELECT * FROM Album_type WHERE typeName LIKE '%{TextBoxSearch.Texts}%'";
                ShowAlbumsType(sql);
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < dataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[index];
                if (mode == "album") 
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    string album_name = selectedRow.Cells[1].Value.ToString();
                    DateTime release_date = (DateTime)selectedRow.Cells[2].Value;
                    string formattedDate = release_date.ToString("yyyy-MM-dd");
                    string artist_name = selectedRow.Cells[3].Value.ToString();
                    string manufacturer_name = selectedRow.Cells[4].Value.ToString();
                    string format = selectedRow.Cells[5].Value.ToString();
                    string genre = selectedRow.Cells[6].Value.ToString();
                    string type = selectedRow.Cells[7].Value.ToString();
                    string price = selectedRow.Cells[8].Value.ToString();

                    string info = id + ';' + album_name + ';' + formattedDate + ';' + artist_name + ';' + manufacturer_name + ';' + format + ';' + genre + ';' + type + ';' + price;

                    EditAlbumForm f = new EditAlbumForm(info);
                    f.ShowDialog();

                    string row = f.GetData();
                    string[] data;
                    if (!string.IsNullOrEmpty(row))
                    {
                        data = row.Split(';');
                        DataSet ds = new DataSet();
                        ds = (DataSet)(dataGridView.DataSource);
                        DataTable dt = ds.Tables[0];
                        dt.Rows[index][0] = data[0];
                        dt.Rows[index][1] = data[1];
                        dt.Rows[index][2] = data[2];
                        dt.Rows[index][3] = data[3];
                        dt.Rows[index][4] = data[4];
                        dt.Rows[index][5] = data[5];
                        dt.Rows[index][6] = data[6];
                        dt.Rows[index][7] = data[7];
                        dt.Rows[index][8] = data[8];
                        NumberingRow();
                    }
                    else return;
                }
                if (mode == "provider")
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    string provider_name = selectedRow.Cells[1].Value.ToString();
                    string addres = selectedRow.Cells[2].Value.ToString();
                    string phone_fax = selectedRow.Cells[3].Value.ToString();
                    string rascet_scet = selectedRow.Cells[4].Value.ToString();

                    string info = id + ';' + provider_name + ';' + addres + ';' + phone_fax + ';' + rascet_scet;

                    EditProviderForm f = new EditProviderForm(info);
                    f.ShowDialog();

                    string row = f.GetData();
                    string[] data;
                    if (!string.IsNullOrEmpty(row))
                    {
                        data = row.Split(';');
                        DataSet ds = new DataSet();
                        ds = (DataSet)(dataGridView.DataSource);
                        DataTable dt = ds.Tables[0];
                        dt.Rows[index][0] = data[0];
                        dt.Rows[index][1] = data[1];
                        dt.Rows[index][2] = data[2];
                        dt.Rows[index][3] = data[3];
                        dt.Rows[index][4] = data[4];
                        NumberingRow();
                    }
                    else return;
                }
                if (mode == "ttn")
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    string dateText = selectedRow.Cells[1].Value.ToString(); ;
                    string provider = selectedRow.Cells[2].Value.ToString(); ;
                    string album = selectedRow.Cells[3].Value.ToString();
                    string number_of_albums = selectedRow.Cells[6].Value.ToString();

                    string info = id + ';' + dateText + ';' + provider + ';' + album + ';' + number_of_albums;

                    EditTTN f = new EditTTN(info);
                    f.ShowDialog();
                    string sql = "SELECT * FROM ViewAlbumTTN";
                    ShowTTN(sql);

                }
                if (mode == "check")
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    string date_of_sale = selectedRow.Cells[1].Value.ToString();
                    string sale_time = selectedRow.Cells[2].Value.ToString();
                    string album = selectedRow.Cells[3].Value.ToString();
                    string number_of_albums = selectedRow.Cells[6].Value.ToString();

                    string info = id + ';' + date_of_sale + ';' + sale_time + ';' + album + ';' + number_of_albums;

                    EditCheckForm f = new EditCheckForm(info);
                    f.ShowDialog();
                    string sql = "SELECT * FROM ViewAlbumChek";
                    ShowCheck(sql);
                }
                if (mode == "ucet")
                {
                    string month = selectedRow.Cells[0].Value.ToString();
                    string album = selectedRow.Cells[1].Value.ToString();
                    string NumbeOfDeliveredAlbums = selectedRow.Cells[3].Value.ToString();
                    string NumberOfAlbumsSold = selectedRow.Cells[4].Value.ToString();

                    string info = month + ';' + album + ';' + NumbeOfDeliveredAlbums + ';' + NumberOfAlbumsSold;

                    EditJurnalUceta f = new EditJurnalUceta(info);
                    f.ShowDialog();
                    string sql = "SELECT * FROM ViewAlbumJurnal";
                    ShowUcet(sql);
                }
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

        private void ButtonCount_Click(object sender, EventArgs e)
        {
            if(mode=="album")
            {
                TotalsAlbumForm f = new TotalsAlbumForm();
                f.ShowDialog();
            }
            if (mode == "check")
            {
                TotalsCheckForm f = new TotalsCheckForm();
                f.ShowDialog();
            }
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

        private void ButtonRaportOpen_Click(object sender, EventArgs e)
        {
            panelReports.Visible = true;
            ButtonAdd.Visible = false;
            ButtonDelete.Visible = false;
            ButtonEdit.Visible = false;
            pictureBoxFilter.Visible = false;
            ButtonCount.Visible = false;
            ButtonSearch.Visible = false;
            TextBoxSearch.Visible = false;
            dataGridView.Visible = false;
            pictureBoxWelcome.Visible = false;
        }

        private void ButtonAlbumInfoReport_Click(object sender, EventArgs e)
        {
            Reports.ReportAlbumInfoForm f = new Reports.ReportAlbumInfoForm();
            f.ShowDialog();
        }

        private void ButtonTTNInfoForm_Click(object sender, EventArgs e)
        {
            Reports.ReortTTNForm f = new Reports.ReortTTNForm();
            f.ShowDialog();
        }

        private void ButtonCheckInfoReport_Click(object sender, EventArgs e)
        {
            Reports.ReportCheckForm f = new Reports.ReportCheckForm();
            f.ShowDialog();
        }

        private void ButtonDiagramReport_Click(object sender, EventArgs e)
        {
            Reports.DiagramAlbumGenreForm f = new Reports.DiagramAlbumGenreForm();
            f.ShowDialog();
        }

        private void ButtonAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanelForm f = new AdminPanelForm();
            this.Hide();
            f.ShowDialog();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            string info = "Раздел \"Альбомы\" -  предназначен для отображения полной информации об альбомах.\n Нажав на стрелку правой кнопкой мыши, будет доступна дополнительная \nинформация об альбомах\n\n" +
                  "Раздел \"Поставщики\" - предназначен для отображения информации о поставщиках,\n которые поставляют альбомы в магазин\n\n" +
                  "Раздел \"ТТН(накладная)\" - предназначен для отображения полной информации\n о поставках, осуществленных в магазин\n\n" +
                  "Раздел \"Покупки\" - предназначен для отображения полной информации\n о покупках, осуществленных в магазин покупателями\n\n" +
                  "Раздел \"Журнал учета\" - предназначен для отображения учета продаж,\n в котором есть количество поставленных и проданных кроссовок и их остаток.\n\n" +
                  "Раздел \"Отчеты\" - предоставляет возможность просмотреть интересующую информацию\n и распечатать\n\n" +
                  "Раздел \"Панель админа\" - предоставляет возможность управлять пользователями\n базы данных, создавать резервные копии и восстановить их";
            HelpForm f = new HelpForm(info);
            f.ShowDialog();
        }
    }
}