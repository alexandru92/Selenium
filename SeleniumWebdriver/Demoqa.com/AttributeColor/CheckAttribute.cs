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

        [FindsBy(How = How.Id, Using = "colorVar")]
        IWebElement Attribute { get; set; }
        public void NavigateUrl()
        {
            webdriver.Navigate().GoToUrl(url);
        }

        public void AttributeCheck()
        {
            WebDriverWait wait = new WebDriverWait(webdriver, TimeSpan.FromSeconds(10));
            string color = Attribute.GetAttribute("color");
           
            if (color.Equals("red"))
            {
                string msg = "color red";
                Assert.IsTrue(true, msg);
            }
            else
            {
                string errmsg = "color not red";
                Assert.Fail(errmsg);
            }
        }
    }

}

