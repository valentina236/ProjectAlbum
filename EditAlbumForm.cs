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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DatabaseAlbum
{
    public partial class EditAlbumForm : Form
    {
        private Database database = new Database();
        public string info = "";
        int ID;

        public EditAlbumForm(string row)
        {
            InitializeComponent();
            string[] data = row.Split(';');

            ID = Convert.ToInt16(data[0]);
            TextBoxAlbumName.Texts = data[1];
            maskedTextBoxDataRelease.Text = data[2];
            TextBoxArtist.Texts = data[3];
            TextBoxManufacter.Texts = data[4];
            DatabaseMethods.fillFormatComboBox(ComboBoxFormat);
            DatabaseMethods.fillGenreComboBox(ComboBoxGenre);
            DatabaseMethods.fillTypeComboBox(ComboBoxType);

            int indexFormat = ComboBoxFormat.FindString(data[5]);
            ComboBoxFormat.SelectedIndex = indexFormat;
            int indexGenre = ComboBoxGenre.FindString(data[6]);
            ComboBoxGenre.SelectedIndex = indexGenre;
            int indexType = ComboBoxType.FindString(data[7]);
            ComboBoxType.SelectedIndex = indexType;
            TextBoxUnitPrice.Texts = data[8];
        }
        private void TextBox__TextChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
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

        private void EnableAddButton()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxAlbumName.Texts) &&
                maskedTextBoxDataRelease.MaskCompleted &&
                !string.IsNullOrWhiteSpace(TextBoxArtist.Texts) &&
                !string.IsNullOrWhiteSpace(TextBoxManufacter.Texts) &&
                !string.IsNullOrWhiteSpace(TextBoxUnitPrice.Texts) &&
                ComboBoxGenre.SelectedIndex != -1 &&
                ComboBoxType.SelectedIndex != -1 &&
                ComboBoxFormat.SelectedIndex != -1)
            {
                ButtonEdit.Enabled = true;
            }
            else
            {
                ButtonEdit.Enabled = false;
            }
        }

        private void ComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }

        private void maskedTextBoxDataRelease_Validating(object sender, CancelEventArgs e)
        {
            EnableAddButton();
        }

        public string GetData()
        {
            return info;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            string album_name = TextBoxAlbumName.Texts;

            string dateText = maskedTextBoxDataRelease.Text;
            DateTime release_date;
            string formattedDate;
            if (DateTime.TryParseExact(dateText, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out release_date))
            {
                formattedDate = release_date.ToString("yyyy-MM-dd");
            }
            else
            {
                MessageBox.Show("Дата должна быть в формате гггг-мм-дд");
                return;
            }

            string artist_name = TextBoxArtist.Texts;
            string manufacturer_name = TextBoxManufacter.Texts;
            int cod_format = Convert.ToInt32(ComboBoxFormat.SelectedValue);
            int cod_genre = Convert.ToInt32(ComboBoxGenre.SelectedValue);
            int cod_type = Convert.ToInt32(ComboBoxType.SelectedValue);
            double price = Convert.ToDouble(TextBoxUnitPrice.Texts);

            // Заменяем запятую на точку
            string unitPriceText = TextBoxUnitPrice.Texts.Replace(",", ".");
            unitPriceText = unitPriceText.Trim();
            double unit_price = double.Parse(unitPriceText, System.Globalization.CultureInfo.InvariantCulture);

            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UpdateAlbum", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@album_cod", ID);
                        command.Parameters.AddWithValue("@album_name", album_name);
                        command.Parameters.AddWithValue("@release_date", formattedDate);
                        command.Parameters.AddWithValue("@artist_name", artist_name);
                        command.Parameters.AddWithValue("@manufacturer_name", manufacturer_name);
                        command.Parameters.AddWithValue("@cod_format", cod_format);
                        command.Parameters.AddWithValue("@cod_genre", cod_genre);
                        command.Parameters.AddWithValue("@cod_type", cod_type);
                        command.Parameters.AddWithValue("@unit_price", unit_price);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно изменена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        info = ID.ToString()+ ";" + album_name + ";" + formattedDate + ";" + artist_name + ";" + manufacturer_name +
                               ";" + ComboBoxFormat.Texts + ";" + ComboBoxGenre.Texts + ";" + ComboBoxType.Texts + ";" + price;
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

        private void radioButtonAlbumName_CheckedChanged(object sender, EventArgs e)
        {
            panelAlbumName.Visible = true;
            panelDateRelease.Visible = false;
            panelArtist.Visible = false;
            panelProvider.Visible = false;
            panelFormat.Visible = false;
            panelGnre.Visible = false;
            panelAlbumType.Visible = false;
            panelPrice.Visible = false;
        }

        private void radioButtonDateRelease_CheckedChanged(object sender, EventArgs e)
        {
            panelAlbumName.Visible = false;
            panelArtist.Visible = false;
            panelProvider.Visible = false;
            panelFormat.Visible = false;
            panelGnre.Visible = false;
            panelAlbumType.Visible = false;
            panelPrice.Visible = false;
            panelDateRelease.Visible = true;
        }

        private void radioButtonArtist_CheckedChanged(object sender, EventArgs e)
        {
            panelAlbumName.Visible = false;
            panelDateRelease.Visible = false;
            panelProvider.Visible = false;
            panelFormat.Visible = false;
            panelGnre.Visible = false;
            panelAlbumType.Visible = false;
            panelPrice.Visible = false;
            panelArtist.Visible = true;
        }

        private void radioButtonpProvider_CheckedChanged(object sender, EventArgs e)
        {
            panelAlbumName.Visible = false;
            panelDateRelease.Visible = false;
            panelArtist.Visible = false;
            panelFormat.Visible = false;
            panelGnre.Visible = false;
            panelAlbumType.Visible = false;
            panelPrice.Visible = false;
            panelProvider.Visible = true;
        }

        private void radioButtonFormat_CheckedChanged(object sender, EventArgs e)
        {
            panelAlbumName.Visible = false;
            panelDateRelease.Visible = false;
            panelArtist.Visible = false;
            panelProvider.Visible = false;
            panelGnre.Visible = false;
            panelAlbumType.Visible = false;
            panelPrice.Visible = false;
            panelFormat.Visible = true;
        }

        private void radioButtonGenre_CheckedChanged(object sender, EventArgs e)
        {
            panelAlbumName.Visible = false;
            panelDateRelease.Visible = false;
            panelArtist.Visible = false;
            panelProvider.Visible = false;
            panelFormat.Visible = false;
            panelAlbumType.Visible = false;
            panelPrice.Visible = false;
            panelGnre.Visible = true;
        }

        private void radioButtonType_CheckedChanged(object sender, EventArgs e)
        {
            panelAlbumName.Visible = false;
            panelDateRelease.Visible = false;
            panelArtist.Visible = false;
            panelProvider.Visible = false;
            panelFormat.Visible = false;
            panelGnre.Visible = false;
            panelPrice.Visible = false;
            panelAlbumType.Visible = true;
        }

        private void radioButtonPrice_CheckedChanged(object sender, EventArgs e)
        {
            panelAlbumName.Visible = false;
            panelDateRelease.Visible = false;
            panelArtist.Visible = false;
            panelProvider.Visible = false;
            panelFormat.Visible = false;
            panelGnre.Visible = false;
            panelAlbumType.Visible = false;
            panelPrice.Visible = true;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            if (radioButtonAlbumName.Checked) TextBoxAlbumName.Clear();
            else if (radioButtonDateRelease.Checked) maskedTextBoxDataRelease.Clear();
            else if (radioButtonArtist.Checked) TextBoxArtist.Clear();
            else if (radioButtonpProvider.Checked) TextBoxManufacter.Clear();
            else if (radioButtonGenre.Checked) ComboBoxGenre.Texts = "";
            else if (radioButtonType.Checked) ComboBoxType.Texts = "";
            else if (radioButtonFormat.Checked) ComboBoxFormat.Texts = "";
            else if (radioButtonPrice.Checked) TextBoxUnitPrice.Clear();
        }
    }
}