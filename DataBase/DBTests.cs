using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zoo_Management.DataBase;


namespace Zoo_Management.DataBase
{
    [TestClass]
    public class DBTests
    {
        [TestMethod]
        public void CanConnectToOracleDB_True()
        {
            var DB = new DataBase();

            var result=DB.Connect();
            
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TryUserLogin_User_True()
        {
            //AAA
            //arrange
            var DB = new DataBase();
            DB.Connect();

            //act
            //bool result=DB.Login();
            //assert
            //Assert.IsTrue(result);
        }

        [TestMethod]
        public void TryCreateOrder_User_OrderId()
        {
            var DB = new DataBase();
            DB.Connect();

            //
            var res=DB.CreateOrder();
            //
            Assert.IsTrue(res.Length>0&&!res.Equals("null"));

        }
    }

    
}
