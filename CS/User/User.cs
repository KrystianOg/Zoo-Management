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
            return true;
        }

        public void Register(string email,string password)
        {
            
        }

        public void RemoveUser()
        {
            
        }

        public void EditUserDetails()
        {
            
        }

        public void EditUserPrivileges()
        {
            
        }

        public void GenerateRegisterCode()
        {
            
        }
    }
}
