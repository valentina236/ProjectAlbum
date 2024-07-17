using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DatabaseAlbum
{
    public partial class AddAlbumForm : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Database database = new Database();
        string data;

        public AddAlbumForm()
        {
            InitializeComponent();
            DatabaseMethods.fillFormatComboBox(ComboBoxFormat);
            DatabaseMethods.fillGenreComboBox(ComboBoxGenre);
            DatabaseMethods.fillTypeComboBox(ComboBoxType);
            ComboBoxFormat.Texts = "";
            ComboBoxGenre.Texts = "";
            ComboBoxType.Texts = "";

            this.Width = 717;
            this.Height = 495;
            ButtonClear.Location = new Point(506, 410);
            ButtonClear.Parent.Invalidate();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
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
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        private void TextBox__TextChanged(object sender, EventArgs e)
        {
            EnableAddButton();
            PanelAdd();
            PanelAdd2();
        }

        private void TextBox1__TextChanged(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                ButtonAdd.Enabled = true;
            }
            else
            {
                ButtonAdd.Enabled = false;
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

        private void PanelAdd()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxAlbumName.Texts) && maskedTextBoxDataRelease.MaskCompleted &&
                !string.IsNullOrWhiteSpace(TextBoxArtist.Texts))
            {
                panelAdd.Visible = true;
                this.Width = 717;
                this.Height = 705;
                ButtonClear.Location = new Point(489, 617);
                ButtonClear.Parent.Invalidate();
            }
            else panelAdd.Visible = false;
        }

        private void PanelAdd2()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxManufacter.Texts) && ComboBoxGenre.Texts != "" &&
                ComboBoxFormat.Texts != "")
            {
                panelAdd2.Visible = true;
                this.Width = 717;
                this.Height = 881;
                ButtonClear.Location = new Point(66, 780);
                ButtonClear.Parent.Invalidate();
            }
            else panelAdd2.Visible = false;
        }

        private void TextBoxArtist_Leave(object sender, EventArgs e)
        {
            PanelAdd();
        }

        private void ComboBoxGenre_Leave(object sender, EventArgs e)
        {
            PanelAdd2();
        }

        private void ComboBoxGenre_DropDownClosed(object sender, EventArgs e)
        {
            EnableAddButton();
            PanelAdd2();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxAlbumName.Clear();
            maskedTextBoxDataRelease.Clear();
            TextBoxArtist.Clear();
            TextBoxManufacter.Clear();
            TextBoxUnitPrice.Clear();
            ComboBoxGenre.SelectedIndex = -1;
            ComboBoxType.SelectedIndex = -1;
            ComboBoxFormat.SelectedIndex = -1;

            this.Width = 717;
            this.Height = 495;
            ButtonClear.Location = new Point(506, 410);
            ButtonClear.Parent.Invalidate();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
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
                    using (SqlCommand command = new SqlCommand("AddAlbum", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@album_name", album_name);
                        command.Parameters.AddWithValue("@release_date", formattedDate);
                        command.Parameters.AddWithValue("@artist_name", artist_name);
                        command.Parameters.AddWithValue("@manufacturer_name", manufacturer_name);
                        command.Parameters.AddWithValue("@cod_format", cod_format);
                        command.Parameters.AddWithValue("@cod_genre", cod_genre);
                        command.Parameters.AddWithValue("@cod_type", cod_type);
                        command.Parameters.AddWithValue("@unit_price", unit_price);

                        string id = command.ExecuteScalar().ToString();

                        MessageBox.Show("Успешное добавление", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        data = id + ";" + album_name + ";" + formattedDate + ";" + artist_name + ";" + manufacturer_name +
                               ";" + ComboBoxFormat.Texts + ";" + ComboBoxGenre.Texts + ";" + ComboBoxType.Texts + ";" + price;
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

        public string GetData()
        {
            return data;
        }
    }
}