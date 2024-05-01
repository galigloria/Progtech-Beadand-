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
    public partial class Login : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Glóri\Documents\lego.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void user_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void user_signup_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

       

        private void user_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            user_password.PasswordChar = user_showpassword.Checked ? '\0' : '*';

        }
        public bool FieldsIsEmpty()
        {
            if (user_name.Text == "" || user_password.Text == "" )
            {
                return true;
            }
            else
                return false;
        }
        private void user_login_Click(object sender, EventArgs e)
        {
            if (FieldsIsEmpty())
            {
                MessageBox.Show("Kérem, minden mezőt töltsön ki!", "Hiba üzenet!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    try
                    {
                        sqlConnection.Open();
                        string selectAcc = "SELECT*FROM USERS WHERE username=@usern and password=@pass and status=@status";
                        using (SqlCommand comand = new SqlCommand(selectAcc, sqlConnection))
                        {
                            comand.Parameters.AddWithValue("@usern",user_name.Text.Trim());
                            comand.Parameters.AddWithValue("@password", user_password.Text.Trim());
                            comand.Parameters.AddWithValue("@status","Aktív");
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(comand);
                            DataTable dataTable = new DataTable();

                            dataAdapter.Fill(dataTable);
                            if (dataTable.Rows.Count >= 1)
                            {
                               
                                MessageBox.Show("Sikeres bejelentkezés!","Infó", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Admin admin = new Admin();
                                admin.Show();
                                this.Hide();

                            }
                            else 
                            {
                                MessageBox.Show("A felhasználónév vagy jelszó helytelen vagy a felhasználó nincs jóváhagyva!", "Hiba üzenet!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                           
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sikertelen bejelentkezés:+" + ex, "Hiba üzenet!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
