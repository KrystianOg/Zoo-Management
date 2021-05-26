using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Zoo_Management.CS.User
{
    public class User : IUser
    {
        private string EmployeeID;
        private string Name;
        private string LastName;
        private DateTime BirthDate;
        private string NameOfPosition;
        private string Email;
        private bool EmailVerification;

        public bool Login(string email,string password)
        {
            using (OracleCommand cmd = new OracleCommand("login", DataBase.DataBase.con))
            {
                cmd.CommandType = CommandType.StoredProcedure;


            }

            return true;
        }

        public void Register()
        {
            using (OracleCommand cmd = new OracleCommand("register", DataBase.DataBase.con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
        }

        public void RemoveUser()
        {
            using (OracleCommand cmd = new OracleCommand("remove_user", DataBase.DataBase.con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
        }

        public void EditUserDetails()
        {
            using (OracleCommand cmd = new OracleCommand("edit_user_details", DataBase.DataBase.con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
        }

        public void EditUserPrivileges()
        {
            using (OracleCommand cmd = new OracleCommand("edit_ser_privileges", DataBase.DataBase.con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
        }

        public void GenerateRegisterCode()
        {
            using (OracleCommand cmd = new OracleCommand("login", DataBase.DataBase.con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
        }
    }
}
