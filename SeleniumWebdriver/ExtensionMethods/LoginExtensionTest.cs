using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebdriver.ExtensionMethods
{
    [TestClass]
    public class LoginExtensionTest
    {
        private static IWebDriver Driver { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            Driver = new FirefoxDriver();

        }
        [TestMethod]

        [TestCleanup]
        public void TearDownTest()
        {
            Driver.Quit();
        }
        [Priority(0)]
        [TestMethod]
        public void LoginExtMethod()
        {
            Loginextensionmethod loginfb = new Loginextensionmethod(Driver);
            loginfb.Navigate();
            string email = ""; // type your email
            string password = ""; // type your password
            loginfb.FillLogin(email, password);
        }
    }
}
