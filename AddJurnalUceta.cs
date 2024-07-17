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
    public partial class AddJurnalUceta : Form
    {
        private Database database = new Database();

        public AddJurnalUceta()
        {
            InitializeComponent();
            int currentMonth = DateTime.Now.Month;
            ComboBoxMonth.SelectedIndex = currentMonth - 1;
            DatabaseMethods.fillAlbumComboBox(ComboBoxAlbum);
            ComboBoxAlbum.Texts = "";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string month_name = ComboBoxMonth.SelectedItem.ToString();
            int album_cod = Convert.ToInt32(ComboBoxAlbum.SelectedValue);
            int NumbeOfDeliveredAlbums = Convert.ToInt32(TextBoxCountAlbumsDeliver.Texts);
            int NumberOfAlbumsSold = Convert.ToInt32(TextBoxCountSold.Texts);

            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("AddJurnalInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@month_name", month_name);
                        command.Parameters.AddWithValue("@album_cod", album_cod);
                        command.Parameters.AddWithValue("@NumbeOfDeliveredAlbums", NumbeOfDeliveredAlbums);
                        command.Parameters.AddWithValue("@NumberOfAlbumsSold", NumberOfAlbumsSold);
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

        private void TextBoxDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            RJTextBox rjTextBox = (RJTextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void EnableAddButton()
        {
            if ( ComboBoxMonth.SelectedIndex != -1 &&
                !string.IsNullOrWhiteSpace(TextBoxCountAlbumsDeliver.Texts) &&
                !string.IsNullOrWhiteSpace(TextBoxCountSold.Texts) &&
                ComboBoxAlbum.SelectedIndex != -1)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxCountAlbumsDeliver.Clear();  
            TextBoxCountSold.Clear();
            ComboBoxAlbum.Texts = "";
            //ComboBoxMonth.SelectedItem = null;
        }
    }
}