using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Demoqa.com.Registration
{
    [TestClass]
    public class Registration
    {
        LogHelper.LogHelper hlp = new LogHelper.LogHelper();
        public IWebDriver Driver { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            Driver = new FirefoxDriver();
        }

        [TestMethod]
        public void FillRegister()
        {
            RegistrationPageObject regpage = new RegistrationPageObject(Driver);
            regpage.Navigate();
            regpage.FillRegistration("alex", "aap", "0845163580", "dxglzcvvxaa", "m1wcvxzgxc@yahoo.com", "text text text", "12345Alex", "12345Alex");
            Thread.Sleep(1000);
            regpage.clicks();
            Thread.Sleep(1000);
            regpage.Months12();
            
            //regpage.HobbyListVerify();
            Thread.Sleep(1000);
            regpage.uploadpic(Driver);

            //Assert.IsTrue(Driver.FindElement(By.ClassName("piereg_message")).Displayed);
            if (Driver.FindElement(By.XPath("/html/body/div/div/div[1]/main/article/div/p")).Text.Equals("Thank you for your registration"))
            {
                try
                {
                    Assert.IsTrue(true, "Registration succes");
                }
                catch (Exception ex)
                {
                    hlp.LogError(ex);
                }
            }

            else /*if (Driver.FindElement(By.LinkText("Username already exists")).Displayed)*/
            {
                string msg = "Test failed, username already exists";
                Assert.Fail(msg);
            }
        }
        [TestCleanup]
        public void TestCleanup()
        {
            Console.ReadLine();
            Driver.Close();
        }

    }
}
