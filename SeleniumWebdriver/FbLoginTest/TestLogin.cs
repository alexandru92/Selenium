using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumWebdriver.FbLoginTest
{
    [TestClass]
    public class TestLogin
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            Driver = new FirefoxDriver();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }
        [TestCleanup]
        public void TearDownTest()
        {
            Driver.Quit();
        }
        [TestMethod]

        public void Login()
        {
            PageObjectFBPage loginfb = new PageObjectFBPage(Driver);
            loginfb.Navigate();
            string email = ""; // type your email
            string password = ""; // type your password
            loginfb.FillLogin(email, password);
        }
    }
}
