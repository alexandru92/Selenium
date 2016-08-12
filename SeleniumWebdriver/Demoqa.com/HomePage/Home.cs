using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumWebdriver.Demoqa.com.HomePage
{

    [TestClass]
    public class Home
    {
        LogHelper.LogHelper hlp = new LogHelper.LogHelper();
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            Driver = new FirefoxDriver();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }
        [Priority(1)]
        [TestMethod]

        public void SwitchTabs()
        {
            HomePageObject homepageobj = new HomePageObject(Driver);
            try
            {
                homepageobj.OpenUrl();
                homepageobj.NavigateTabs(Driver);
            }
            catch (Exception ex)
            {
                hlp.LogError(ex);
            }
        }
        [TestCleanup]
        public void TearDownTest()
        {
            Driver.Close();
        }
    }
}
