using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Demoqa.com.findall
{
    [TestClass]
    public class Findall
    {
        public IWebDriver Driver { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            Driver = new FirefoxDriver();
        }
        [TestCleanup]
        public void TearDownTest()
        {
            Driver.Quit();
        }
        [TestMethod]
        public void SearchLinks()
        {
            AllLinks lnk = new AllLinks(Driver);
            lnk.Navigate();
            lnk.findAll();
        
                   
        }
    }
}
