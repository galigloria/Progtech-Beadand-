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
using System.Drawing.Printing;

namespace LegoStoreManagementSystem
{
    public partial class Order : UserControl
    {
        public static int getCustomerID;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Glóri\Documents\lego.mdf;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=False");


        public Order()
        {
            InitializeComponent();
            DisplayAvailableLego();
            DisplayAllLegoOrders();
            DisplayTotalPrice();
            InitializeProductDataGridView();
        }

        public void DisplayAvailableLego()
        {
            LegoData legoData = new LegoData();
            List<LegoData> listLego = legoData.AvailableLegoData();
            productsDataGridView1.DataSource = listLego;
        }

        public void DisplayAllLegoOrders()
        {
            OrderData allLegoOrder = new OrderData();
            List<OrderData> listData = allLegoOrder.orderListData();
            OrderData.Rows.Clear();
            foreach (OrderData orderData in listData)
            {
                OrderData.Rows.Add((OrderData)orderData.Clone());
            }
           
        }

        private float totalPrice;

        public void DisplayTotalPrice()
        { 
         GenerateID();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT SUM(lego_price) FROM ORDERS WHERE customer_ID = @customerID";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@customerID", genId);
                        object value = cmd.ExecuteScalar();
                        if (value != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(value);
                            Order_Price.Text = totalPrice.ToString("0.00");
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sikertelen csatlakozás:" + ex, "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private int genId = 0;

        public void GenerateID()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Glóri\Documents\lego.mdf;Integrated Security=True;Connect Timeout=30;"))
            {
                try
                {
                    con.Open();
                    string selectID = "SELECT MAX(customer_id) FROM CUSTOMERS ";
                    using (SqlCommand cmd = new SqlCommand(selectID, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            int temp = Convert.ToInt32(result);
                            if (temp == 0)
                            {
                                genId += 1;
                            }
                            else if (temp == genId)
                            {
                                genId = temp + 1;
                            }
                        }
                        else
                        {
                            genId = 1;
                        }
                        getCustomerID = genId;
                    }
                }
                finally
                {
                    con.Close();
                }
                
                
            }
        }

        private void Order_Add_Click(object sender, EventArgs e)
        {
            GenerateID();
            if (Order_Type.SelectedIndex == -1  || Order_ProductsName.Text == "" || Order_Quantity.Value == 0
                || Order_ProductsPrice.Text == "")
            {
                MessageBox.Show("Kérem,minden mezőt töltsön ki!", "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        float getPrice = 0;
                        string selectOrder = "SELECT * FROM LEGO WHERE lego_id = @legoID ";
                        using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                        {
                            getOrder.Parameters.AddWithValue("@legoID", Order_ID.Text.Trim());
                            using (SqlDataReader dataReader = getOrder.ExecuteReader())
                            {
                                if (dataReader.Read())
                                {
                                    object readValue = dataReader["lego_price"];
                                    if (readValue != DBNull.Value)
                                    {
                                        getPrice = Convert.ToSingle(readValue);
                                    }
                                }
                            }
                        }
                        string insertOrder = "INSERT INTO ORDERS (customer_ID, lego_id, lego_name, lego_type, lego_price, order_date, lego_quantity )" +
                            "VALUES(@customerID, @legoID, @legoName, @legoType, @legoPrice, @orderDate, @legoQuantity)";
                        DateTime today = DateTime.Today;
                        using (SqlCommand cmd = new SqlCommand(insertOrder, connect))
                        {
                            cmd.Parameters.AddWithValue("@customerID", genId);
                            cmd.Parameters.AddWithValue("@legoID", Order_ID.Text.Trim());
                            cmd.Parameters.AddWithValue("@legoName", Order_ProductsName.Text.Trim());
                            cmd.Parameters.AddWithValue("@legoType", Order_Type.Text.Trim());
                            float totalPrice = getPrice * ((int)Order_Quantity.Value);
                            cmd.Parameters.AddWithValue("@legoPrice", totalPrice);
                            cmd.Parameters.AddWithValue("@orderDate", today);
                            cmd.Parameters.AddWithValue("@legoQuantity", Order_Quantity.Value);
                            cmd.ExecuteNonQuery();
                            DisplayTotalPrice();
                           
                            MessageBox.Show("A hozzáafás sikeresen megtörtént!","Infromáció", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplayAvailableLego();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sikertelen csatlakozás:" + ex, "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void Order_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order_ID.SelectedIndex = -1;
            Order_ID.Items.Clear();
            Order_ProductsName.Text = "";
            Order_ProductsPrice.Text = "";

            string selectedValue = Order_Type.SelectedItem as string;
            if (selectedValue != null)
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        connect.Open();
                        string selectData = $"SELECT * FROM LEGO WHERE lego_type = '{selectedValue}' AND lego_status = @legoStatus AND date_delete IS NULL";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@legoStatus", "Jelenleg elérhető");
                            using (SqlDataReader dataReader = cmd.ExecuteReader())
                            {
                                while (dataReader.Read())
                                {
                                    string legoID = dataReader["lego_id"].ToString();
                                    Order_ID.Items.Add(legoID);
                                }
                            }
                        }
                        DisplayAllLegoOrders();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba:" + ex, "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void Order_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = Order_ID.SelectedItem as string;
            if (selectedValue != null)
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        connect.Open();
                        string selectData = $"SELECT * FROM LEGO WHERE lego_id = '{selectedValue}' AND lego_status = @legoStatus AND date_delete IS NULL";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@legoStatus", "Jelenleg elérhető");
                            using (SqlDataReader dataReader = cmd.ExecuteReader())
                            {
                                while (dataReader.Read())
                                {
                                    string legoName = dataReader["lego_name"].ToString();
                                    string legoPrice = dataReader["lego_price"].ToString();
                                    Order_ProductsName.Text = legoName;
                                    Order_ProductsPrice.Text = legoPrice;
                                }
                            }
                        }
                        DisplayAllLegoOrders();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba:" + ex, "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void Order_Amount_TextChanged(object sender, EventArgs e)
        {
        }

        private void Order_Amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float amount = Convert.ToSingle(Order_Amount.Text);
                    float change = (amount - totalPrice);
                    if (change <= -1)
                    {
                        Order_Amount.Text = "";
                        Order_Change.Text = "";
                    }
                    else
                    {
                        Order_Change.Text = change.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Helytelen összeg:" + ex, "Hiba üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Order_Amount.Text = "";
                    Order_Change.Text = "";
                }
            }
        }

        private void Order_Pay_Click(object sender, EventArgs e)
        {
            if (Order_Amount.Text == "" || OrderData.Rows.Count < 0)
            {
                MessageBox.Show("Hiba történt.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Biztos szeretne fizetni?", "Információ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            GenerateID();
                            DisplayTotalPrice();
                            string insertData = "INSERT INTO CUSTOMERS (customer_id, total_price, date, amount, change_leg) VALUES (@customerId, @totalPrice, @date, @amount, @changeLeg)";
                            DateTime today = DateTime.Today;
                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@customerId", genId);
                                cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                                cmd.Parameters.AddWithValue("@amount", Order_Amount.Text);
                                cmd.Parameters.AddWithValue("@changeLeg", Order_Change.Text); // Corrected parameter name
                                cmd.Parameters.AddWithValue("@date", today);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Sikeres fizetés!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Sikertelen csatlakozás:" + ex, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private int rowIndex = 0;

        private void Order_Receipt_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            DisplayTotalPrice();
            float y = 0;
            int count = 0;
            int colWidth = 120;
            int headerMargin = 10;
            int tableMargin = 20;
            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);
            float margin = e.MarginBounds.Top;
            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;
            string headerText = "Legon Áruház";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left + (OrderData.Columns.Count / 2) * colWidth, y, alignCenter);
            count++;
            y += tableMargin;
            string[] header = { " CustomerID", "LegoID", "LegoName", "LegoType", "LegoPrice", "LegoQuantity" };
            for (int i = 0; i < header.Length - 2; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
            }
            count++;
            float space = e.MarginBounds.Bottom - y;
            while (rowIndex < OrderData.Rows.Count)
            {
                DataGridViewRow row = OrderData.Rows[rowIndex];
                for (int i = 0; i < OrderData.Columns.Count; i++)
                {
                    object cellValue = row.Cells[i].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;
                    y = margin * count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
                }
                count++;
                rowIndex++;
                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
            int labelMargin = (int)Math.Min(space, 90);
            DateTime today = DateTime.Now;

            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("----------------", labelFont).Width;
            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString("Végösszeg: \tFt" + totalPrice + "\n-----------------\nÖsszeg: \tFt" + Order_Amount.Text
                  + "\n\t\t-----------------\nVisszajár: \tFt" + Order_Change.Text, labelFont, Brushes.Black, labelX, y);

            labelMargin = (int)Math.Min(space, -40);
            string labelText = today.ToString();
            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("--------------", labelFont).Width, y);
        }

        //private void OrderTable_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex != 1)
        //    {
        //        DataGridViewRow row = DataGridView1.Rows[e.RowIndex];
        //        Order_ID.Text = row.Cells[1].Value.ToString();
        //        Order_ProductsName.Text = row.Cells[2].Value.ToString();
        //        Order_Type.Text = row.Cells[3].Value.ToString();
        //        Order_Price.Text = row.Cells[4].Value.ToString();
        //        Order_Quantity.Text = row.Cells[5].Value.ToString();
                
        //    }
        //}
        private ProductsDataGridView productsDataGridView;
        private void InitializeProductDataGridView()
        {
            productsDataGridView = new ProductsDataGridView();
            productsDataGridView.Dock = DockStyle.Fill;
            Order_Panel.Controls.Add(productsDataGridView); 
        }

        
    }
}
