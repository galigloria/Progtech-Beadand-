using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace LegoStoreManagementSystem
{
    public class LegoData
    {
        public int ID { get; set; }
        public string LegoID { get; set; }
        public string LegoName { get; set; }
        public string LegoType { get; set; }
        public string LegoStock { get; set; }
        public string LegoPrice { get; set; }
        public string LegoStatus { get; set; }
        public string LegoImage { get; set; }
        public string DateInsert { get; set; }
        public string DateUpdate { get; set; }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Glóri\Documents\lego.mdf;Integrated Security=True;Connect Timeout=30");
        public List<LegoData> LegoDataList()
        {
            List<LegoData> legos = new List<LegoData>();
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                    string selectLego = "SELECT * FROM LEGO WHERE date_delete IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectLego, connection))
                    {
                        SqlDataReader dataAdapter = cmd.ExecuteReader();
                        while (dataAdapter.Read())
                        {
                            LegoData lego = new LegoData();
                            lego.ID = (int)dataAdapter["id"];
                            lego.LegoName = dataAdapter["lego_name"].ToString();
                            lego.LegoType = dataAdapter["lego_type"].ToString();
                            lego.LegoStock = dataAdapter["lego_stock"].ToString();
                            lego.LegoPrice = dataAdapter["lego_price"].ToString();
                            lego.LegoStatus = dataAdapter["lego_status"].ToString();
                           lego.LegoImage = dataAdapter["lego_image"].ToString();
                            lego.DateInsert = dataAdapter["date_insert"].ToString();
                            lego.DateUpdate = dataAdapter["date_update"].ToString();
                            legos.Add(lego);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Sikertelen csatlakozás:" + e);
                }
                finally
                {
                    connection.Close();
                }

            }
            return legos;

        }
        public List<LegoData> availableLegoData()
        {
            List<LegoData> listLego = new List<LegoData>();
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                    string selectLego = "SELECT * FROM LEGO WHERE lego_status = @legoStatus";
                    using (SqlCommand cmd = new SqlCommand(selectLego, connection))
                    {
                        cmd.Parameters.AddWithValue("@legoSatus", "Jelenleg elérhető");
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            LegoData adp = new LegoData();
                            adp.ID = (int)reader["id"];
                            adp.LegoName = reader["lego_name"].ToString();
                            adp.LegoType = reader["lego_type"].ToString();
                            adp.LegoStock = reader["lego_stock"].ToString();
                            adp.LegoPrice = reader["lego_price"].ToString();
                            
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
                    connection.Close();
                }
            }
            return listLego;
        }

    }
}
