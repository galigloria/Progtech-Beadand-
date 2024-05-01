using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lego
{
    internal  class Data
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Glóri\Documents\lego.mdf;Integrated Security=True;Connect Timeout=30");
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string DateOfRegistration { get; set; }
        public List<Data> usersDatas()
        {
            List<Data> datas = new List<Data>();
            if(connection.State!= System.Data.ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string selectUsers = "SELECT*FROM Users";
                    using (SqlCommand cmd = new SqlCommand(selectUsers,connection))
                    {
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            Data data = new Data();
                            data.ID = (int)dataReader["id"];
                            data.Name =dataReader["username"].ToString();
                            data.Password = dataReader["password"].ToString();
                            data.Role= dataReader["role"].ToString();
                            data.Status = dataReader["status"].ToString();
                            datas.Add(data);

                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Sikertelen adatbázis csatlakozás:"+ex);
                }
                finally
                {
                    connection.Close();
                }
               
            }
            return datas;
        }
    }
}
