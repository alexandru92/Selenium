using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SeleniumWebdriver.Demoqa.com.ApiTest
{
    public class ApiGoogleMaps
    {
        LogHelper.LogHelper hlp = new LogHelper.LogHelper();
        private readonly IWebDriver webdriver;
        private static string enterkey = "SighetuMarmatiei";
        private static string link = "http://maps.googleapis.com/maps/api/geocode/json?address=" + enterkey + "&sensor=False";
        public ApiGoogleMaps(IWebDriver driver)
        {
            
            this.webdriver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[@id='colorVar']")]
        IWebElement Attribute { get; set; }

        
        public void NavigateUrl()
        {
            try
            {
                HttpWebRequest myrequest = (HttpWebRequest)WebRequest.Create(link);
                HttpWebResponse myresponse = (HttpWebResponse)myrequest.GetResponse();
                if (myresponse.StatusCode == HttpStatusCode.OK)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.Fail();
                }
                myresponse.Close();
            }
            catch (Exception ex)
            {
                hlp.LogError(ex);
            }
            
        }
    }
}
