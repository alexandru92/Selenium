using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace SeleniumWebdriver.Demoqa.com.AttributeColor
{
    [TestClass]
    public class AttributeTest
    {
        LogHelper.LogHelper hlp = new LogHelper.LogHelper();
        public IWebDriver Driver { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            Driver = new FirefoxDriver();
        }
        [TestMethod]
        public void CheckColor()
        {
            CheckAttribute chkattr = new CheckAttribute(Driver);
            try
            {
                chkattr.NavigateUrl();
                Thread.Sleep(10000);
                chkattr.AttributeCheck();
            }
            catch(Exception ex)
            {
                hlp.LogError(ex);
            }
        }
    }
}
