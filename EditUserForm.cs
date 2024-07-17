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
    public partial class EditUserForm : Form
    {
        private Database database = new Database();
        public string info = "";
        int ID;

        public EditUserForm(string row)
        {
            InitializeComponent();
            string[] data = row.Split(';');

            ID = Convert.ToInt16(data[0]);
            TextBoxLogin.Texts = data[1];
            TextBoxPassword.Texts = data[2];

            int indexRole = ComboBoxRole.FindString(data[3]);
            ComboBoxRole.SelectedIndex = indexRole;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxLogin.Clear();
            TextBoxPassword.Clear();
            ComboBoxRole.Texts = "";
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            string login = TextBoxLogin.Texts;
            string password = TextBoxPassword.Texts;
            string role = ComboBoxRole.SelectedItem.ToString();

            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UpdateUserInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@IdUser", ID);
                        command.Parameters.AddWithValue("@UserName", login);
                        command.Parameters.AddWithValue("@UserPassword", password);
                        command.Parameters.AddWithValue("@RoleName", role);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Информация пользователя успешно изменена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        info = ID + ";" + login + ";" + password + ";" + role;
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

        public string GetData()
        {
            return info;
        }

        private void EnableAddButton()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxLogin.Texts) &&
                !string.IsNullOrWhiteSpace(TextBoxPassword.Texts) &&
                ComboBoxRole.SelectedIndex != -1)
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

        private void ComboBoxRole_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }
    }
}
