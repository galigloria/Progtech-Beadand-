using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegoStoreManagementSystem
{
    public partial class EmployeeAddUser : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Glóri\Documents\lego.mdf;Integrated Security=True;Connect Timeout=30");
        public EmployeeAddUser()
        {
            InitializeComponent();
            ShowUser();

        }
        public void ShowUser()
        {
            UserData data = new UserData();
            List<UserData> datas = data.usersDatas();
        }
        public bool emptyFields()
        {
            if (EmployeeAddUser_username.Text == "" || EmployeeAddUser_password.Text == ""
                || EmployeeAddUser_role.Text == "" || EmployeeAddUser_status.Text == ""
                || EmployeeAddUser_imageView.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void EmployeeAddUser_deletebtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!", "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Biztos, hogy törölni szeretné a felhasználónevet: " + EmployeeAddUser_username.Text.Trim()
                    + "?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();
                            string deleteData = "DELETE FROM users WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                ClearFields();

                                MessageBox.Show("Sikeresen törlődött!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ShowUser();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Sikertelen csatlakozás: " + ex, "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
        }

        private void EmployeeAddUser_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Minden mezőt ki kell tölteni", "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectUsern = "SELECT * FROM  users WHERE  username = @usern";

                        using (SqlCommand checkUsern = new SqlCommand(selectUsern, connect))
                        {
                            checkUsern.Parameters.AddWithValue("@usern", EmployeeAddUser_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                string usern = EmployeeAddUser_username.Text.Substring(0, 1).ToUpper() + EmployeeAddUser_username.Text.Substring(1);
                                MessageBox.Show(usern + " Ez a felhasználónév már foglalt", "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, profile_image, role, status, date_reg)" +
                                    "VALUES(@usern, @pass, @image, @role, @status, @date)";
                                DateTime today = DateTime.Today;

                                string path = Path.Combine(@"C:\Users\Glóri\Documents\lego\User_Directory\"
                                    + EmployeeAddUser_username.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(EmployeeAddUser_imageView.ImageLocation, path, true);


                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", EmployeeAddUser_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", EmployeeAddUser_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@role", EmployeeAddUser_role.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", EmployeeAddUser_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", today);

                                    cmd.ExecuteNonQuery();
                                    ClearFields();

                                    MessageBox.Show("Sikeresen hozzáadva!", "Információ!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    ShowUser();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Csatlakozás sikertelen: " + ex, "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            
        }

        private void EmployeeAddUser_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png|*.jpg*.png)";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    EmployeeAddUser_imageView.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex, "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int id = 0;
        private void UserData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = UserData.Rows[e.RowIndex];
            id = (int)row.Cells[0].Value;
            EmployeeAddUser_username.Text = row.Cells[1].Value.ToString();
            EmployeeAddUser_password.Text = row.Cells[2].Value.ToString();
            EmployeeAddUser_role.Text = row.Cells[3].Value.ToString();
            EmployeeAddUser_status.Text = row.Cells[4].Value.ToString();

            string imagePath = row.Cells[5].Value.ToString();

            try
            {
                if (imagePath != null)
                {
                    EmployeeAddUser_imageView.Image = Image.FromFile(imagePath);
                }
                else
                {
                    EmployeeAddUser_imageView.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nincs kép: "+ ex, "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EmployeeAddUser_updatebtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!", "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Biztos, hogy módosítani szeretné a felhasználónevet: " + EmployeeAddUser_username.Text.Trim()
                    + "?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE users SET username = @usern, password = @pass, role = @role, status = @status WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", EmployeeAddUser_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", EmployeeAddUser_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", EmployeeAddUser_role.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", EmployeeAddUser_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                ClearFields();

                                MessageBox.Show("Sikeresen módosult!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ShowUser();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Sikertelen csatlakozás: " + ex, "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
        }
        public void ClearFields()
        {
            EmployeeAddUser_username.Text = "";
            EmployeeAddUser_password.Text = "";
            EmployeeAddUser_role.SelectedIndex = -1;
            EmployeeAddUser_status.SelectedIndex = -1;
            EmployeeAddUser_imageView.Image = null;
        }

        private void EmployeeAddUser_clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
