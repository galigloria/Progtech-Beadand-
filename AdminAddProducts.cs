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
using System.IO;

namespace LegoStoreManagementSystem
{
    public partial class AdminAddProducts : UserControl
    { 
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Glóri\Documents\lego.mdf;Integrated Security=True;Connect Timeout=30");

        public AdminAddProducts()
        {
            InitializeComponent();
            DisplayLegoData();
        }

        public bool FieldIsEmpty()
        {
            if (AdminAddProducts_id.Text == "" || AdminAddProducts_name.Text == ""
                || AdminAddProducts_type.SelectedIndex == -1 || AdminAddProducts_stock.Text == ""
                || AdminAddProducts_price.Text == "" || AdminAddProducts_condition.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DisplayLegoData()
        {
            LegoData legoData = new LegoData();
            List<LegoData> listLego = legoData.LegoDataList();
            DataGridView1.DataSource = listLego;
        }
        private void AdminAddProducts_import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
                string imagePath = "";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dlg.FileName;
                    AdminAddProducts_imageView.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba:" + ex, "Hiba üzenet!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LegoClear()
        {
            AdminAddProducts_id.Text = "";
            AdminAddProducts_name.Text = "";
            AdminAddProducts_type.SelectedIndex = -1;
            AdminAddProducts_stock.Text = "";
            AdminAddProducts_price.Text = "";
            AdminAddProducts_condition.SelectedIndex = -1;
            AdminAddProducts_imageView = null;

        }





        private void AdminAddProducts_deletebtn_Click(object sender, EventArgs e)
        {
            if (FieldIsEmpty())
            {
                MessageBox.Show("Kérem, az összes mezőt töltse ki!", "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult check = MessageBox.Show("Biztosan törölni  akarja a Lego ID-t:" + AdminAddProducts_id.Text.Trim() + "?", "Figyelmeztetés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        try
                        {
                            conn.Open();
                            string updateData = "UPDATE LEGO SET date_delete = @dateDelete WHERE lego_id = legoID";
                            DateTime today = DateTime.Now;
                            using (SqlCommand update = new SqlCommand(updateData, conn))
                            {

                                update.Parameters.AddWithValue("@dateDelete", today);
                                update.Parameters.AddWithValue("@legoID", AdminAddProducts_id.Text.Trim());
                                update.ExecuteNonQuery();
                                LegoClear();
                                MessageBox.Show("Sikeres törlés!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LegoClear();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Sikertelen csatlakozás:" + ex, "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }






        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != 1)
            {
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex];
                AdminAddProducts_id.Text = row.Cells[1].Value.ToString();
                AdminAddProducts_name.Text = row.Cells[2].Value.ToString();
                AdminAddProducts_type.Text = row.Cells[3].Value.ToString();
                AdminAddProducts_stock.Text = row.Cells[4].Value.ToString();
                AdminAddProducts_price.Text = row.Cells[5].Value.ToString();
                AdminAddProducts_condition.Text = row.Cells[6].Value.ToString();
                string imagePath = row.Cells[7].ToString();

                try
                {
                    if (imagePath != null)
                    {
                        AdminAddProducts_imageView.Image = Image.FromFile(imagePath);

                    }
                    else
                    {
                        AdminAddProducts_imageView.Image = null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sikertelen kp feltöltés:" + ex, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }



        }

        private void AdminAddProducts_updatebtn_Click(object sender, EventArgs e)
        {
            if (FieldIsEmpty())
            {
                MessageBox.Show("Kérem, az összes mezőt töltse ki!", "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult check = MessageBox.Show("Biztosan módosítani akarja a Lego ID-t:" + AdminAddProducts_id.Text.Trim() + "?", "Figyelmeztetés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        try
                        {
                            conn.Open();
                            string updateData = "UPDATE LEGO SET lego_name = @legoName" +
                                ", lego_type = @legoType, lego_stock = @legoStock, lego_price = @legoPrice, lego_status = @legoStatus " +
                                ", date_update = @dateUpdate WHERE lego_id = @legoID";
                            DateTime today = DateTime.Now;
                            using (SqlCommand update = new SqlCommand(updateData, conn))
                            {
                                update.Parameters.AddWithValue("@legoName", AdminAddProducts_name.Text.Trim());
                                update.Parameters.AddWithValue("@legoType", AdminAddProducts_type.Text.Trim());
                                update.Parameters.AddWithValue("@legoStock", AdminAddProducts_stock.Text.Trim());
                                update.Parameters.AddWithValue("@legoPrice", AdminAddProducts_price.Text.Trim());
                                update.Parameters.AddWithValue("@legoStatus", AdminAddProducts_condition.Text.Trim());
                                update.Parameters.AddWithValue("@dateUpdate", today);
                                update.Parameters.AddWithValue("@legoID", AdminAddProducts_id.Text.Trim());
                                update.ExecuteNonQuery();
                                LegoClear();
                                MessageBox.Show("Sikeres hozzáadás!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DisplayLegoData();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Sikertelen csatlakozás:" + ex, "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }

        }


      
        private void AdminAddProducts_clearBtn_Click_1(object sender, EventArgs e)
        {
            LegoClear();
        }

        private void AdminAddProducts_addBtn_Click_1(object sender, EventArgs e)
        {
            if (FieldIsEmpty())
            {
                MessageBox.Show("A mezők nem lehetnek üresek!", "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();
                        string selectLegoID = "SELECT * FROM LEGO WHERE lego_id = @legoID";
                        using (SqlCommand selectLegID = new SqlCommand(selectLegoID, conn))
                        {
                            selectLegID.Parameters.AddWithValue("@legoID", AdminAddProducts_id.Text.Trim());
                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectLegID);
                            DataTable dataTable = new DataTable();
                            sqlDataAdapter.Fill(dataTable);
                            if (dataTable.Rows.Count >= 1)
                            {
                                MessageBox.Show("Lego ID:" + AdminAddProducts_id.Text.Trim() + "már foglalat!", "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertData = "INSERT INTO LEGO (lego_id,lego_name,lego_type,lego_stock,lego_price,lego_status,lego_image,date_insert) VALUES"
                                    + "(@legoID,@legoName,@legoType,@legoStock,@legoPrice,@legoStatus,@legoImage,@dateInsert)";
                                string path = "D:\\Lego(1)\\Lego\\Lego\\Lego\\Lego\\Lego_Directory\\";
                                string name = AdminAddProducts_id.Text.Trim() + ".jpg";
                                string imagePath = Path.Combine(path, name);

                                //string path = "@C:\\Users\\Glóri\\Downloads\\Lego(1)\\Lego\\Lego\\Lego\\Lego\\Directory for Lego\\";
                                //string imagePath= Path.Combine(AdminAddProducts_id.Text.Trim() +
                                //    ".jpg");
                                string directoryPath = Path.GetDirectoryName(path);
                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }
                                File.Copy(AdminAddProducts_imageView.ImageLocation, imagePath, true);
                                DateTime today = DateTime.Today;
                                using (SqlCommand cmd = new SqlCommand(insertData, conn))
                                {
                                    cmd.Parameters.AddWithValue("@legoID", AdminAddProducts_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@legoName", AdminAddProducts_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@legoType", AdminAddProducts_type.Text.Trim());
                                    cmd.Parameters.AddWithValue("@legoStock", AdminAddProducts_stock.Text.Trim());
                                    cmd.Parameters.AddWithValue("@legoPrice", AdminAddProducts_price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@legoStatus", AdminAddProducts_condition.Text.Trim());
                                    cmd.Parameters.AddWithValue("@legoImage", path);
                                    cmd.Parameters.AddWithValue("@dateInsert", today);
                                    cmd.ExecuteNonQuery();
                                    LegoClear();

                                    MessageBox.Show("A hozzáadás sikeresen megtörént!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sikertelen csatlakozás:" + ex, "Hiba üzenet",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
