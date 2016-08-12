using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ExtensionMethods
{
    public class Loginextensionmethod
    {
        private readonly IWebDriver webdriver;
        private readonly string url = @"http://www.facebook.com";
        public Loginextensionmethod(IWebDriver fbstartpage)
        {
            this.webdriver = fbstartpage;
            PageFactory.InitElements(fbstartpage, this);
        }
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailBox { get; set; }

        [FindsBy(How = How.Id, Using = "pass")]
        public IWebElement PasswordBox { get; set; }
       
        [FindsBy(How = How.XPath, Using = "//input[@id='u_0_o']")]
        public IWebElement ClickLogin { get; set; }

        public void Navigate()
        {
            webdriver.Navigate().GoToUrl(url);
        }

        public void FillLogin(string emailfill, string passwordfill)
        {
            //fill login with Extension method that clears the field and holds value
            EmailBox.FillLoginExt(emailfill);
            PasswordBox.FillLoginExt(passwordfill);
            ClickLogin.Click();
            //EmailBox.Clear();
            //EmailBox.SendKeys(emailfill);
            //EmailBox.Submit();
            //PasswordBox.Clear();
            //PasswordBox.SendKeys(passwordfill);
            //PasswordBox.Submit();
            //ClickLogin.Click();

        }
    }
}
