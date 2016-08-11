using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Demoqa.com.AlertBox
{
    public class AlertBox
    {
        private readonly IWebDriver webdriver;
        private static string url = "http://toolsqa.com/automation-practice-switch-windows/";
        public AlertBox(IWebDriver driver)
        {
            this.webdriver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[@id='alert']")]
        IWebElement alertbtn { get; set; }

        [FindsBy(How = How.Id, Using = "alert")]
        IWebElement alertok { get; set; }
        public void NavigateUrl()
        {
            webdriver.Navigate().GoToUrl(url);
        }

        public void ClickAlert()
        {
            alertbtn.Click();
            webdriver.SwitchTo().Alert().Accept();
        }
    }
}
