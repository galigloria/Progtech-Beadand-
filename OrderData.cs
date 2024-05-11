using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LegoStoreManagementSystem
{
    public class OrderData : ICloneable
    {
        public int CostumerID { get; set; } 
        public string LegoID { get; set; } //1
        public string LegoName { get; set; } //2
        public string LegoType { get; set; } //3
        public float LegoPrice { get; set; } //4
        public int LegoQuantity { get; set; } //5
        private SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Glóri\Documents\lego.mdf;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=False");

        public List<OrderData> orderListData()
        {
            List<OrderData> legoOrderData = new List<OrderData>();
            if(connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    int customerID = 0;
                    string selectCuctomerData = "SELECT MAX(customer_ID) * FROM ORDERS";
                    using(SqlCommand getCustomerData = new SqlCommand(selectCuctomerData,connect))
                    {
                        object result = getCustomerData.ExecuteScalar();
                        if(result != DBNull.Value)
                        {
                            int temp = Convert.ToInt32(result);
                            //if (temp == 0)
                            //{
                            //    customerID = 1;
                            //}
                            //else
                            //{
                            //    customerID = temp;
                            //}
                        }
                        else
                        {
                            Console.WriteLine("Hibás azonosító!");
                        }
                    }
                    string selectOrders = "SELECT * FROM ORDERS WHERE customer_ID = @customerID";
                    using(SqlCommand cmd = new SqlCommand(selectOrders, connect))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerID);
                        SqlDataReader dataReader= cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            OrderData orderData = new OrderData();
                            orderData.CostumerID = (int)dataReader["customer_ID"];
                            orderData.LegoID = dataReader["lego_id"].ToString();
                            orderData.LegoName = dataReader["lego_name"].ToString();
                            orderData.LegoType = dataReader["lego_type"].ToString();
                            orderData.LegoPrice = (float)dataReader["lego_price"];
                            orderData.LegoQuantity = (int)dataReader["lego_quantity"];
                            legoOrderData.Add(orderData);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Hibás csatlakozás:" +ex);
                }
                finally
                {
                    connect.Close();
                }
                
            }
            return legoOrderData;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
