using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Demoqa.com.findall
{// 36 anchor links in page
    public class AllLinks
    {
        LogHelper.LogHelper hlp = new LogHelper.LogHelper();
        private readonly IWebDriver driver;
        private string url = @"http://www.demoqa.com/";
        public AllLinks(IWebDriver webdriver)
        {
            this.driver = webdriver;
            PageFactory.InitElements(webdriver, this);
            
        }

        [FindsBy(How = How.TagName, Using = "a")]
        IList<IWebElement> Links { get; set; }
        public void Navigate()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void findAll()
        {
            try
            {
                for (int i = 1; i < Links.Count; i = i+1)
                {
                    
                    Console.WriteLine("nr" + Links.ToString() + Links.Count());
                }
            }
            catch (Exception ex)
            {       
                hlp.LogError(ex);
            }

        }
    }
}
