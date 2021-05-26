using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Management.DataBase
{
    public interface IDatabase
    {
        void Connect();
        void Close();
    }
}
