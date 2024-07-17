using Microsoft.Reporting.Map.WebForms.BingMaps;
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
    public partial class AddUserForm : Form
    {
        private Database database = new Database();
        string data;

        public AddUserForm()
        {
            InitializeComponent();
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

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string login = TextBoxLogin.Texts;
            string password = TextBoxPassword.Texts;
            string role = ComboBoxRole.SelectedItem.ToString();

            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("AddUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserName", login);
                        command.Parameters.AddWithValue("@UserPassword", password);
                        command.Parameters.AddWithValue("@RoleName", role);
                        string id = command.ExecuteScalar().ToString();

                        MessageBox.Show("Успешное добавление", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        data = id + ";" + login + ";" + password + ";" + role;
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
            if (!string.IsNullOrWhiteSpace(TextBoxLogin.Texts) &&
                !string.IsNullOrWhiteSpace(TextBoxPassword.Texts) &&
                TextBoxPassword.Texts.Length == 8 &&
                ComboBoxRole.SelectedIndex != -1)
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

        private void ComboBoxRole_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }
    }
}
