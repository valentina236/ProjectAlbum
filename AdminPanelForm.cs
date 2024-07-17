using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseAlbum
{
    public partial class AdminPanelForm : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Database database = new Database();
        int index;

        public AdminPanelForm()
        {
            InitializeComponent();
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

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            index = dataGridView.SelectedCells[0].RowIndex;
            ButtonDelete.Visible = true;
            ButtonEdit.Visible = true;
        }

        public void NumberingRow()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void ButtonUsers_Click(object sender, EventArgs e)
        {
            ButtonAdd.Visible = true;
            try
            {
                string sql = "SELECT * FROM LoginTable WHERE RoleName = 'user' OR RoleName = 'seller' ";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    dataGridView.Columns.Clear();
                    dataGridView.Rows.Clear();
                    dataGridView.Columns.Add("IdUser", "id");
                    dataGridView.Columns.Add("Login", "Логин");
                    dataGridView.Columns.Add("Password", "Пароль");
                    dataGridView.Columns.Add("Role", "Роль");

                    while (reader.Read())
                    {
                        string IdUser = reader["IdUser"].ToString();
                        string UserName = reader["UserName"].ToString();
                        string UserPassword = reader["UserPassword"].ToString();
                        string RoleName = reader["RoleName"].ToString();

                        dataGridView.Rows.Add(IdUser, UserName, UserPassword, RoleName);
                    }
                    dataGridView.Columns["IdUser"].Visible = false;
                    NumberingRow();
                    dataGridView.Visible = true;
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string row = "";
            AddUserForm f = new AddUserForm();
            f.ShowDialog();
            row = f.GetData();
            string[] data;
            if (!string.IsNullOrEmpty(row))
            {
                data = row.Split(';');
                if (data.Length == dataGridView.Columns.Count)
                {
                    dataGridView.Rows.Add(data);
                    NumberingRow();
                }
                else return;
            }
            else return;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < dataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[index];

                DialogResult result = MessageBox.Show(
                    "Удалить пользователя?",
                    "Удаление",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                    try
                    {
                        using (var connection = database.GetConnection())
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand("DeleteUser", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@UserID", id);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Пользователь успешно удален.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dataGridView.Rows.RemoveAt(index);
                    NumberingRow();
                }
            }
            else return;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < dataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[index];
                string id = selectedRow.Cells[0].Value.ToString();
                string login = selectedRow.Cells[1].Value.ToString();
                string password = selectedRow.Cells[2].Value.ToString();
                string role = selectedRow.Cells[3].Value.ToString();

                string info = id + ';' + login + ';' + password + ';' + role;

                EditUserForm f = new EditUserForm(info);
                f.ShowDialog();

                string row = f.GetData();
                string[] data;
                if (!string.IsNullOrEmpty(row))
                {
                    data = row.Split(';');
                    if (data.Length == dataGridView.Columns.Count)
                    {
                        selectedRow.Cells[0].Value = data[0];
                        selectedRow.Cells[1].Value = data[1];
                        selectedRow.Cells[2].Value = data[2];
                        selectedRow.Cells[3].Value = data[3];
                        NumberingRow();
                    }
                }
                else return;
            }
            else return;
        }

        private void ButtonBackUp_Click(object sender, EventArgs e)
        {
            string FilePath = "";
            bool SaveFileDialog()
            {
                saveFileDialog.Filter = "Backup Files (.bak)|*.bak";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FilePath = saveFileDialog.FileName;
                    return true;
                }
                return false;
            }

            if (SaveFileDialog())
            {
                try
                {
                    using (var connection = database.GetConnection())
                    {
                        connection.Open();
                        string query = "BACKUP DATABASE Album TO DISK = N'" + FilePath + "' WITH NOFORMAT, NOINIT, NAME = N'Album-Full Database Backup', SKIP, NOREWIND, NOUNLOAD";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Успешное создание резервной копиии!\nПуть к файлу резервной копии: " + FilePath, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка создания резервной копии: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonBackUpRestore_Click(object sender, EventArgs e)
        {
            string FilePath = "";
            bool OpenFileDialog()
            {
                openFileDialog.FileName = "backup";
                openFileDialog.Title = "Select backup file";
                openFileDialog.Filter = "Backup files (*.bak)|*.bak|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FilePath = openFileDialog.FileName;
                    return true;
                }
                return false;
            }

            if (OpenFileDialog())
            {
                try
                {
                    using (var connection = database.GetConnection())
                    {
                        connection.Open();
                        bool isDatabaseInUse = IsDatabaseInUse(connection, "Album");
                        if (isDatabaseInUse) DisconnectDatabase(connection, "Album");
                        string query = "USE master RESTORE DATABASE Album FROM DISK = N'" + FilePath + "' WITH REPLACE, FILE = 1,  NOUNLOAD";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Успешное восстановление резервной копиии", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка восстановления резервной копии: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Метод для проверки, используется ли база данных
        private bool IsDatabaseInUse(SqlConnection connection, string databaseName)
        {
            string query = $"SELECT COUNT(*) FROM sys.dm_exec_sessions WHERE database_id = DB_ID('{databaseName}')";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                int sessionCount = (int)cmd.ExecuteScalar();
                return sessionCount > 0;
            }
        }

        // Метод для отключения всех соединений с базой данных
        private void DisconnectDatabase(SqlConnection connection, string databaseName)
        {
            string query = $"ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}