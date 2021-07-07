using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using MySql.Data;
using MySql.Data.MySqlClient;
using Zoo_Management.CS.Delivery;
using Zoo_Management.CS.User;

namespace Zoo_Management.DataBase
{
    public class DataBase 
    {
        private string Server = "156.17.43.90";
        public string User { set; private get; } = "pwr_20_21_L_019256307";
        public int Port { set; private get; } = 1521;
        public string SID { set; private get; } = "xe";
        public string Password { set; private get; } = "A3sx7H24JK5EBj4e";

        public static MySqlConnection con { get; private set; }

        public bool Connect()
        {
            try
            {
                con = new MySqlConnection();
                con.ConnectionString = $"User Id={User};Password={Password};Data Source={Server}:{Port}";
                Console.WriteLine("Connected to Oracle DB ver: " + con.ServerVersion);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Couldn't connect to data source.");
                return false;
            }
        }

        public bool Login(string login,string password)
        {
            return true;
        }

        public string CreateOrder()
        {
            con.Open();
            using (var cmd = new MySqlCommand{CommandType = CommandType.StoredProcedure, Connection = con,CommandText = "app_delivery.create_order"})
            {

            }
            return null;
        }
        
        public void Close()
        {
            con.Close();
            con.Dispose();
        }
    }
    
}
