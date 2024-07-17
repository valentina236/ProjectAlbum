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
    public partial class AddProviderForm : Form
    {
        private Database database = new Database();
        string data;

        public AddProviderForm()
        {
            InitializeComponent();
        }

        private void TextBoxProviderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string provider_name = TextBoxProviderName.Texts;
            string addres = TextBoxAdress.Texts;
            string phone_fax = maskedTextBoxPhone.Text;
            phone_fax = "+" + string.Concat(phone_fax.Where(char.IsDigit));
            string rascet_scet = maskedTextBoxRasScet.Text;

            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("AddProvider", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@provider_name", provider_name);
                        command.Parameters.AddWithValue("@addres", addres);
                        command.Parameters.AddWithValue("@phone_fax", phone_fax);
                        command.Parameters.AddWithValue("@rascet_scet", rascet_scet);

                        string id = command.ExecuteScalar().ToString();

                        MessageBox.Show("Успешное добавление", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        data = id + ";" + provider_name + ";" + addres + ";" + phone_fax + ";" + rascet_scet;
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

        private void EnableAddButton()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxProviderName.Texts) &&
                maskedTextBoxPhone.MaskCompleted &&
                !string.IsNullOrWhiteSpace(TextBoxAdress.Texts) &&
                maskedTextBoxRasScet.MaskCompleted)
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

        private void maskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            EnableAddButton();
        }

        private void maskedTextBox__TextChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxProviderName.Clear();
            TextBoxAdress.Clear();
            maskedTextBoxPhone.Clear();
            maskedTextBoxRasScet.Clear();
        }
    }
}
