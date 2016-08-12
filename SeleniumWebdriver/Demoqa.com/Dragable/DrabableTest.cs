using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumWebdriver.Demoqa.com.Dragable
{
    [TestClass]
    public class DragableTest

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
        [Priority(1)]
        [TestMethod]
        public void DragAndDrop()
        {
            Dragable drag = new Dragable(Driver);
            drag.OpenUrl();
            drag.DragandDrop();
        }
    }
}
