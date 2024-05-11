using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LegoStoreManagementSystem
{
   public class CustomerData
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Glóri\Documents\lego.mdf;Integrated Security=True;Connect Timeout=30");
        public int CustomerID { get; set; }
        public string TotalPrice { get; set; }
        public string Amount { get; set; }
        public string ChangeLeg { get; set; }
        public string Date { get; set; }
        public List<CustomerData> allCustomersData()
        {
            List<CustomerData> listData = new List<CustomerData>();
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                    string selectData = "SELECT * FROM CUSTOMERS";
                    using(SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            CustomerData customerData = new CustomerData();
                            customerData.CustomerID = (int)dataReader["customer_id"];
                            customerData.TotalPrice = dataReader["total_price"].ToString();
                            customerData.Date= dataReader["date"].ToString();
                            customerData.Amount = dataReader["amount"].ToString();
                            //customerData.ChangeLeg = dataReader["change_leg"].ToString();
                            listData.Add(customerData);


                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Sikertelen csatlakozás:"+ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            return listData;
        }




    }
}
