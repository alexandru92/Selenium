using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Demoqa.com.HomePage
{
    public class HomePageObject
    {

        private readonly IWebDriver driver;
        string urlhome = @"http://www.demoqa.com";
        public HomePageObject(IWebDriver homestart)
        {
            this.driver = homestart;
            PageFactory.InitElements(homestart, this);
        }
        [FindsBy(How = How.Id, Using = "ui-id-1")]
        IWebElement Tab1Content { get; set; }

        [FindsBy(How = How.Id, Using = "tabs-1")]
        IWebElement Tab1Text { get; set; }

        [FindsBy(How = How.Id, Using = "ui-id-2")]
        IWebElement Tab2Content { get; set; }

        [FindsBy(How = How.Id, Using = "tabs-2")]
        IWebElement Tab2Text { get; set; }

        [FindsBy(How = How.Id, Using = "ui-id-3")]
        IWebElement Tab3Content { get; set; }

        [FindsBy(How = How.Id, Using = "tabs-3")]
        IWebElement Tab3Text { get; set; }
        public void OpenUrl()
        {
            driver.Navigate().GoToUrl(urlhome);
        }
        public void NavigateTabs(IWebDriver webdriver)
        {
            //Wait 5 seconds and then click
            Thread.Sleep(5000);
            Tab1Content.Click();
            Assert.IsTrue(Tab1Content.Displayed && Tab1Text.Text.Contains("Content 1"));
            Tab2Content.Click();
            Thread.Sleep(5000);
            Assert.IsTrue(Tab2Content.Displayed && Tab2Text.Text.Contains("Content 2"));
            Tab3Content.Click();
            Thread.Sleep(5000);
            Assert.IsTrue(Tab3Content.Displayed && Tab3Text.Text.Contains("Content 3"));
        }
    }
}
