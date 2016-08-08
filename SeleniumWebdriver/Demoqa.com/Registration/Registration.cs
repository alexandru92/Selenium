using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Demoqa.com.Registration
{
    [TestClass]
    public class Registration
    {
        LogHelper.LogHelper hlp = new LogHelper.LogHelper();
        public IWebDriver Driver { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            Driver = new FirefoxDriver();
        }

        [TestMethod]
        public void FillRegister()
        {
            RegistrationPageObject regpage = new RegistrationPageObject(Driver);
            regpage.Navigate();
            regpage.FillRegistration("","","","","","","","",1,"","","","","","");
        }
        [TestCleanup]
        public void TestCleanup()
        {
            Driver.Close();
        }

    }
}
