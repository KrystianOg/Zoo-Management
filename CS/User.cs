using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Management.CS
{
    public class User 
    {
        private string EmployeeID;
        private string Name;
        private string LastName;
        private DateTime BirthDate;
        private string NameOfPosition;
        private string Email;
        private bool EmailVerification;

        public User(string email)
        {
            this.Email = email;
        }
    }

}
