using System;
using System.Security.AccessControl;
using EddyNewHome.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CommonGetIp()
        {
            string expectedIp = "210.119.12.75";

            string actualIp = Commons.GetIpAddress();
            Assert.AreEqual(expectedIp, actualIp);

        }
    }
}
