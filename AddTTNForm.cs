using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseAlbum
{
    public partial class AddTTNForm : Form
    {
        private Database database = new Database();

        public AddTTNForm()
        {
            InitializeComponent();
            DatabaseMethods.fillProviderComboBox(ComboBoxProvider);
            ComboBoxProvider.Texts = "";
            DatabaseMethods.fillAlbumComboBox(ComboBoxAlbum);
            ComboBoxAlbum.Texts = "";
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
                ButtonAdd.Enabled = true;
            }
            else
            {
                ButtonAdd.Enabled = false;
            }
        }

        private void TextBox__TextChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }

        private void maskedTextBoxDataPost_Validating(object sender, CancelEventArgs e)
        {
            EnableAddButton();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string dateText = dateTimePicker.Text;

            int provider_cod = Convert.ToInt32(ComboBoxProvider.SelectedValue);
            int album_cod = Convert.ToInt32(ComboBoxAlbum.SelectedValue);
            int number_of_albums = Convert.ToInt32(TextBoxCountAlbums.Texts);
            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("AddTTN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@date_post", dateText);
                        command.Parameters.AddWithValue("@provider_cod", provider_cod);
                        command.Parameters.AddWithValue("@album_cod", album_cod);
                        command.Parameters.AddWithValue("@number_of_albums", number_of_albums);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Успешное добавление", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxCountAlbums.Clear();
            ComboBoxAlbum.Texts = "";
            ComboBoxProvider.Texts = "";
        }
    }
}
