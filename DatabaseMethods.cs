using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseAlbum
{
    public static class DatabaseMethods
    {
        private static Database database = new Database();

        public static void fillFormatComboBox(RJComboBox comboBox)
        {
            try
            {
                string sql = "SELECT DISTINCT cod_format, format_name FROM Album_format";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "format_data");
                    comboBox.ValueMember = "cod_format";
                    comboBox.DisplayMember = "format_name";
                    comboBox.DataSource = ds.Tables["format_data"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void fillGenreComboBox(RJComboBox comboBox)
        {
            try
            {
                string sql = "SELECT DISTINCT cod_genre, genre_name FROM Album_genre";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "genre_data");
                    comboBox.ValueMember = "cod_genre";
                    comboBox.DisplayMember = "genre_name";
                    comboBox.DataSource = ds.Tables["genre_data"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void fillTypeComboBox(RJComboBox comboBox)
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
                    comboBox.ValueMember = "cod_type";
                    comboBox.DisplayMember = "typeName";
                    comboBox.DataSource = ds.Tables["type_data"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void fillAlbumComboBox(RJComboBox comboBox)
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
                    comboBox.ValueMember = "album_cod";
                    comboBox.DisplayMember = "album_name";
                    comboBox.DataSource = ds.Tables["album_data"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void fillProviderComboBox(RJComboBox comboBox)
        {
            try
            {
                string sql = "SELECT DISTINCT provider_cod, provider_name FROM Providerr";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "provider_data");
                    comboBox.ValueMember = "provider_cod";
                    comboBox.DisplayMember = "provider_name";
                    comboBox.DataSource = ds.Tables["provider_data"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
