using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LegoStoreManagementSystem
{
    public class OrderLegoData : Lego
    {
        //public int ID { get; set; }
        //public string LegoID { get; set; } //1
        //public string LegoName { get; set; } //2
        //public string LegoType { get; set; } //3
        //public string LegoStock { get; set; } //4
        //public string LegoPrice { get; set; } //5
        //public string LegoStatus { get; set; } //6
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Glóri\Documents\lego.mdf;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=False");

        public override int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string LegoID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string LegoName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string LegoType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string LegoStock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string LegoPrice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string LegoStatus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string LegoImage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string DateInsert { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string DateUpdate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<OrderLegoData> availableLegoData()
        {
            List<OrderLegoData> listLego = new List<OrderLegoData>();
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectLego = "SELECT * FROM LEGO WHERE lego_status = @legoStatus AND date_delete IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectLego, connect))
                    {
                        cmd.Parameters.AddWithValue("@legoSatus", "Jelenleg elérhető");
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            OrderLegoData adp = new OrderLegoData();
                            adp.ID = (int)reader["id"];
                            adp.LegoName = reader["lego_name"].ToString();
                            adp.LegoType = reader["lego_type"].ToString();
                            adp.LegoStock = reader["lego_stock"].ToString();
                            adp.LegoPrice = reader["lego_price"].ToString();
                            adp.LegoStatus = reader["lego_status"].ToString();

                            listLego.Add(adp);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Sikertelen csatlakozás:" + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listLego;
        }

    }
}


