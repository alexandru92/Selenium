using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWebdriver.FbLoginTest
{
    public class PageObjectFBPage
    {
        private readonly IWebDriver webdriver;
        private readonly string url = @"http://www.facebook.com";
        public PageObjectFBPage(IWebDriver fbstartpage)
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
            EmailBox.Clear();
            EmailBox.SendKeys(emailfill);
            EmailBox.Submit();
            PasswordBox.Clear();
            PasswordBox.SendKeys(passwordfill);
            PasswordBox.Submit();
            ClickLogin.Click();

        }
    }
}