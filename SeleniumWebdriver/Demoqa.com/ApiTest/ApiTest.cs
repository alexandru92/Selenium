using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace SeleniumWebdriver.Demoqa.com.ApiTest
{
    [TestClass]
    public class ApiTest
    {
        LogHelper.LogHelper hlp = new LogHelper.LogHelper();
        public IWebDriver Driver { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            Driver = new FirefoxDriver();
        }
        [TestMethod]
        public void ApiTestMethod()
        {
            ApiGoogleMaps apitest = new ApiGoogleMaps(Driver);
            apitest.NavigateUrl();
        }
        [TestCleanup]
        public void TestCleanup()
        {
            Driver.Close();
        }

    }
    
}
