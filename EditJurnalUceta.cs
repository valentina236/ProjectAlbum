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
    public partial class EditJurnalUceta : Form
    {
        private Database database = new Database();
        string month;

        public EditJurnalUceta(string row)
        {
            InitializeComponent();
            string[] data = row.Split(';');
            month = data[0];
            TextBoxMonth.Texts = month;
            DatabaseMethods.fillAlbumComboBox(ComboBoxAlbum);

            int indexAlbum = ComboBoxAlbum.FindString(data[1]);
            ComboBoxAlbum.SelectedIndex = indexAlbum;

            TextBoxCountAlbumsDeliver.Texts = data[2];
            TextBoxCountSold.Texts = data[3];
        }

        private void TextBoxDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            RJTextBox rjTextBox = (RJTextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void EnableAddButton()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxMonth.Texts) &&
                !string.IsNullOrWhiteSpace(TextBoxCountAlbumsDeliver.Texts) &&
                !string.IsNullOrWhiteSpace(TextBoxCountSold.Texts) &&
                ComboBoxAlbum.SelectedIndex != -1)
            {
                ButtonEdit.Enabled = true;
            }
            else
            {
                ButtonEdit.Enabled = false;
            }
        }

        private void TextBox__TextChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            int album_cod = Convert.ToInt32(ComboBoxAlbum.SelectedValue);
            int NumbeOfDeliveredAlbums = Convert.ToInt32(TextBoxCountAlbumsDeliver.Texts);
            int NumberOfAlbumsSold = Convert.ToInt32(TextBoxCountSold.Texts);

            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UpdateJurnalUceta", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@month_name", month);
                        command.Parameters.AddWithValue("@album_cod", album_cod);
                        command.Parameters.AddWithValue("@NumbeOfDeliveredAlbums", NumbeOfDeliveredAlbums);
                        command.Parameters.AddWithValue("@NumberOfAlbumsSold", NumberOfAlbumsSold);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно изменена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxCountAlbumsDeliver.Clear();
            TextBoxCountSold.Clear();
        }
    }
}
