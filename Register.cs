using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Lego
{
    public partial class Register : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Glóri\Documents\lego.mdf;Integrated Security=True;Connect Timeout=30");
        public Register()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_login_Click(object sender, EventArgs e)
        {
            Login loginFrom = new Login();
            loginFrom.Show();
            this.Hide();
        }

        private void register_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showpassword.Checked ? '\0' : '*';
            register_mpassword.PasswordChar = register_showpassword.Checked ? '\0' : '*';
        }
        public bool FieldsIsEmpty()
        {
            if (register_username.Text == "" || register_password.Text == "" || register_mpassword.Text == "")
            {
                return true;
            }
            else
                return false;
        }

        private void register_signup_Click(object sender, EventArgs e)
        {
            if (FieldsIsEmpty())
                MessageBox.Show("Hiányos felhasználónév vagy jelszó.Kérem, adjon meg minden adatot a sikeres regisztrációhoz! ", "Hiba Üzenet!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if(sqlConnection.State == ConnectionState.Closed)
                {
                    try
                    {
                        sqlConnection.Open();
                        string selectUserName = "SELECT*FROM USERS WHERE username=@usern";
                        using (SqlCommand checkName = new SqlCommand(selectUserName, sqlConnection))
                        {
                            checkName.Parameters.AddWithValue("@usern", sqlConnection);
                            SqlDataAdapter dataAdapter = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            if (dataTable.Rows.Count >= 1)
                            {
                                string takenName = register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1);
                                MessageBox.Show(takenName + "már létezik!", "Hiba üzenet!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else if(register_password != register_mpassword)
                            {
                                MessageBox.Show("A jelszavak nem egyeznek meg!", "Hiba üzenet!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length < 10)
                            {
                                MessageBox.Show("A jelszó hosszának legalább 10 karakternek kell lennie!", "Hiba üzenet!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insert = "INSERT INTO Users(username,password,profile_image,role,status,reg_date) VALUES (@usern,@passWrd,@image,@role,@status,@date)";
                                DateTime today = DateTime.Today;
                                using(SqlCommand command=new SqlCommand(insert, sqlConnection))
                                {
                                    command.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    command.Parameters.AddWithValue("@passWrd", register_password.Text.Trim());
                                    command.Parameters.AddWithValue("@image","");
                                    command.Parameters.AddWithValue("@role","Pénztáros");
                                    command.Parameters.AddWithValue("@status","Jóváhagyva");
                                    command.Parameters.AddWithValue("@date",today);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Sikeres regisztráció!", "Információ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Login login = new Login();
                                    login.Show();
                                    this.Hide();

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sikertelen regisztráció:+"+ex, "Hiba üzenet!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
                
               
            }
                
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
