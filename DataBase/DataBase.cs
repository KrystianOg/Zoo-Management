using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Zoo_Management.CS.Delivery;
using Zoo_Management.CS.User;

namespace Zoo_Management.DataBase
{
    public class DataBase 
    {
        private static string Server = "156.17.43.90";
        public static string User { set; private get; } = "pwr_20_21_L_019256307";
        public static int Port { set; private get; } = 1521;
        public static string SID { set; private get; } = "xe";
        public static string Password { set; private get; } = "A3sx7H24JK5EBj4e";

        public static OracleConnection con { get; private set; }

        public static void Connect()
        {
            try
            {
                con = new OracleConnection();
                con.ConnectionString = $"User Id={User};Password={Password};Data Source={Server}:{Port}";
                con.Open();
                Console.WriteLine("Connected to Oracle DB ver: " + con.ServerVersion);

            }
            catch (Exception)
            {
                Console.WriteLine("Couldn't connect to data source.");
            }
        }

        public bool Login(string login,string password)
        {

            using (var cmd = new OracleCommand())
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("login_in", login);
                cmd.Parameters.Add("password_in", password);
                con.Open();

                //...


                //...
            }

            return false;
        }
        
        public static void Close()
        {
            con.Close();
            con.Dispose();
        }
    }
    
}
