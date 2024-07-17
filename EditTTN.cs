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
    public partial class EditTTN : Form
    {
        private Database database = new Database();
        int ID;

        public EditTTN(string row)
        {
            InitializeComponent();
            string[] data = row.Split(';');

            ID = Convert.ToInt16(data[0]);
            dateTimePicker.Text = data[1];
            DatabaseMethods.fillProviderComboBox(ComboBoxProvider);
            DatabaseMethods.fillAlbumComboBox(ComboBoxAlbum);

            int indexProvider = ComboBoxProvider.FindString(data[2]);
            ComboBoxProvider.SelectedIndex = indexProvider;
            int indexAlbum = ComboBoxAlbum.FindString(data[3]);
            ComboBoxAlbum.SelectedIndex = indexAlbum;

            TextBoxCountAlbums.Texts = data[4];
        }

        private void TextBoxDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            RJTextBox rjTextBox = (RJTextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void EnableAddButton()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxCountAlbums.Texts) && ComboBoxProvider.SelectedIndex != -1 && ComboBoxAlbum.SelectedIndex != -1)
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

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            int provider_cod = Convert.ToInt32(ComboBoxProvider.SelectedValue);
            int album_cod = Convert.ToInt32(ComboBoxAlbum.SelectedValue);
            int number_of_albums = Convert.ToInt32(TextBoxCountAlbums.Texts);

            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UpdateTTN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@num_doc", ID);
                        command.Parameters.AddWithValue("@provider_cod", provider_cod);
                        command.Parameters.AddWithValue("@album_cod", album_cod);
                        command.Parameters.AddWithValue("@number_of_albums", number_of_albums);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ComboBoxAlbum.Texts = "";
            ComboBoxProvider.Texts = "";
            TextBoxCountAlbums.Clear();
        }
    }
}
