using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseAlbum
{
    public partial class RegistrationForm : Form
    {
        private Database database = new Database();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxLogin.Clear();
            TextBoxPassword.Clear();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                TextBoxPassword.PasswordChar = false;
            }
            else
            {
                TextBoxPassword.PasswordChar = true;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxLogin.Texts) || string.IsNullOrWhiteSpace(TextBoxPassword.Texts))
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string username = TextBoxLogin.Texts.Trim();
                string password = TextBoxPassword.Texts.Trim();
                try
                {
                    string sql = "SELECT RoleName FROM LoginTable WHERE UserName = @username AND UserPassword = @password";

                    using (var connection = database.GetConnection())
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string RoleName = reader["RoleName"].ToString();

                            if (RoleName == "admin")
                            {
                                this.Hide();
                                Form1 f = new Form1();
                                f.ShowDialog();
                            }
                            else if (RoleName == "user")
                            {
                                this.Hide();
                                UserForm f = new UserForm();
                                f.ShowDialog();
                            }
                            else if (RoleName == "seller")
                            {
                                this.Hide();
                                SellerForm f = new SellerForm();
                                f.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Невернный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TextBoxLogin.Clear();
                            TextBoxPassword.Clear();
                            TextBoxLogin.Focus();
                        }
                        reader.Close();
                        connection.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Не удалось подключится к базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
