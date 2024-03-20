using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unitest;
using System;

namespace Test_Login
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContext;
        public TestContext TestContext
        {

            get { return testContext; }
            set { testContext = value; }

        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "C:\\Users\\nguye\\OneDrive\\code\\Năm II\\Công nghệ phần mềm\\Final Project\\ProjectSaleManagement\\Test_Login\\Data\\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestWithDataSource()
        {
            string a, b;
            a = TestContext.DataRow[0].ToString();
            b = TestContext.DataRow[1].ToString();

            TestLogin test = new TestLogin();
            int res = test.CheckLogin(a, b);
            Assert.AreEqual(res, 1);
        }

    }
}
