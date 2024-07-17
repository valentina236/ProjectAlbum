using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseAlbum
{
    public partial class EditProviderForm : Form
    {
        private Database database = new Database();
        public string info = "";
        int ID;

        public EditProviderForm(string row)
        {
            InitializeComponent();
            string[] data = row.Split(';');

            ID = Convert.ToInt16(data[0]);
            TextBoxProviderName.Texts = data[1];
            TextBoxAdress.Texts = data[2];
            maskedTextBoxPhone.Text = data[3];
            maskedTextBoxRasScet.Text = data[4];
            EnableAddButton();
        }

        private void TextBoxProviderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        public string GetData()
        {
            return info;
        }

        private void EnableAddButton()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxProviderName.Texts) &&
                maskedTextBoxPhone.MaskCompleted &&
                !string.IsNullOrWhiteSpace(TextBoxAdress.Texts) &&
                maskedTextBoxRasScet.MaskCompleted)
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

        private void maskedTextBoxPhone_Validating(object sender, CancelEventArgs e)
        {
            EnableAddButton();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
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
                    using (SqlCommand command = new SqlCommand("UpdateProvider", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@provider_cod", ID);
                        command.Parameters.AddWithValue("@provider_name", provider_name);
                        command.Parameters.AddWithValue("@addres", addres);
                        command.Parameters.AddWithValue("@phone_fax", phone_fax);
                        command.Parameters.AddWithValue("@rascet_scet", rascet_scet);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно изменена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        info = ID.ToString() + ";" + provider_name + ";" + addres + ";" + phone_fax + ";" + rascet_scet;
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
            TextBoxProviderName.Clear();
            TextBoxAdress.Clear();
            maskedTextBoxPhone.Clear();
            maskedTextBoxRasScet.Clear();
        }
    }
}