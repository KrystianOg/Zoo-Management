using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;


namespace Zoo_Management.CS.User
{
    interface IUser
    {
        bool Login(string email,string password);
        void Register(string email,string password);
        void RemoveUser();
        void EditUserDetails();
        void EditUserPrivileges();
        void GenerateRegisterCode();
    }
    
}
