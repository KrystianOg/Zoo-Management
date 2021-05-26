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
        public void TryUserLogin_User_True()
        {
            //AAA
            //arrange
            var DB = new DataBase();

            //act
            bool result=DB.Login();
            //assert
            Assert.IsTrue(result);
        }
    }

    
}
