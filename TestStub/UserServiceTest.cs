using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stub;

namespace TestStub
{
    [TestClass]
    public class UserServiceTest
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Verify_RemoveStore_With_Null_Parameter()
        {
            User removeUser = null;

            try
            {
                UserServices us = new UserServices();
                us.RemoveStore(removeUser);
                Assert.Fail("Should throw a ArgumentException");
            }
            catch (NullReferenceException e)
            {
                Assert.AreEqual<string>("Argument is null.", e.Message);

            }
        }

        [TestMethod]
        public void Verify_RemoveStore_With_Existing_Store()
        {
            User removeUser = new User();
            removeUser.StoreName = "dev-loja01";

            UserServices us = new UserServices();
            int actual = us.RemoveStore(removeUser);

            Assert.AreEqual<int>(0, actual);
        }
    }
}
