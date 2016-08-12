using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using NUnit.Framework;

namespace SeleniumWebdriver.Demoqa.com.AlertBox
{
    [TestClass]
    public class AlertTest1
    {
        
        LogHelper.LogHelper hlp = new LogHelper.LogHelper();
        public IWebDriver Driver { get; set; }
        
        [TestInitialize]
        public void SetupTest()
        {
            Driver = new FirefoxDriver();
        }
        [Priority(0)]
        [TestMethod]
        public void ClickAlertBox()
        {
            AlertBox bx = new AlertBox(Driver);
            bx.NavigateUrl();
            bx.ClickAlert();
            Thread.Sleep(3000);
        }
    }
}
