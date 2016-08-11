using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Demoqa.com.AttributeColor
{
    public class CheckAttribute
    {
        private readonly IWebDriver webdriver;
        private static string url = "http://toolsqa.com/automation-practice-switch-windows/";
        public CheckAttribute(IWebDriver driver)
        {

            this.webdriver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[@id='colorVar']")]
        IWebElement Attribute { get; set; }
        public void NavigateUrl()
        {
            webdriver.Navigate().GoToUrl(url);
        }

        public void AttributeCheck()
        {
            string colorwaited = "rgba(255, 0, 0, 1)";
            WebDriverWait wait = new WebDriverWait(webdriver, TimeSpan.FromSeconds(10));
            string clr = webdriver.FindElement(By.XPath("//button[@id='colorVar']")).GetCssValue("color");
            if (clr == colorwaited)
            {
                string msg = "color red";
                Assert.IsTrue(true, msg);
                Console.WriteLine("color red" + msg);
            }
            else
            {
                string errmsg = "color not red";
                Assert.Fail(errmsg);
            }
        }
    }

}

