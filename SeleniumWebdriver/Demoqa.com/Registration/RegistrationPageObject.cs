using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumWebdriver.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumWebdriver.Demoqa.com.Registration
{
    public class RegistrationPageObject
    {
        private readonly IWebDriver webdriver;
        private readonly string url = @"http://demoqa.com/registration/";
        public RegistrationPageObject(IWebDriver registrationdriver)
        {
            this.webdriver = registrationdriver;
            PageFactory.InitElements(registrationdriver, this);
        }
        [FindsBy(How = How.Id, Using = "name_3_firstname")]
        IWebElement Fnamefield { get; set; }

        [FindsBy(How = How.Id, Using = "name_3_lastname")]
        IWebElement Lnamefield { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='single']")]
        IList<IWebElement> SingleRadioField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='dance']")]
        IList<IWebElement> CheckBoxDance { get; set; }

        [FindsBy(How = How.Id, Using = "dropdown_7")]
        IWebElement CountryDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/main/article/div/div/div[3]/form/ul/li[4]/div/select/option[149]")]
        IWebElement SelectRoCountry { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/main/article/div/div/div[3]/form/ul/li[5]/div/div/div[1]/select/option[3]")]
        IWebElement February { get; set; }

        [FindsBy(How = How.Id, Using = "mm_date_8")]
        IList<IWebElement> MonthDD { get; set; }

        [FindsBy(How = How.Id, Using = "dd_date_8")]
        IWebElement DayDD { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/main/article/div/div/div[3]/form/ul/li[5]/div/div/div[2]/select/option[20]")]
        IWebElement day19 { get; set; }

        [FindsBy(How = How.Id, Using = "yy_date_8")]
        IWebElement YearDD { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/main/article/div/div/div[3]/form/ul/li[5]/div/div/div[3]/select/option[24]")]
        IWebElement Year1992 { get; set; }

        [FindsBy(How = How.Id, Using = "phone_9")]
        IWebElement Phone { get; set; }

        [FindsBy(How = How.Id, Using = "username")]
        IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "email_1")]
        IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "profile_pic_10")]
        IWebElement ProfilePictureGet { get; set; }

        [FindsBy(How = How.Id, Using = "description")]
        IWebElement Description { get; set; }

        [FindsBy(How = How.Id, Using = "password_2")]
        IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "confirm_password_password_2")]
        IWebElement PasswordConfirm { get; set; }

        [FindsBy(How = How.Name, Using = "pie_submit")]
        IWebElement Submitbtn { get; set; }

        public void Navigate()
        {
            webdriver.Navigate().GoToUrl(url);
        }
        public void clicks()
        {
            if (!SingleRadioField.ElementAt(0).Selected)
            {
                SingleRadioField.ElementAt(0).Click();
            }

            if (!CheckBoxDance.ElementAt(0).Selected)
            {
                CheckBoxDance.ElementAt(0).Click();
            }
            SelectElement elementselected = new SelectElement(CountryDropDown);
            elementselected.SelectByText("Romania");
            February.ClickExtAndSleep();
            DayDD.ClicksExt();
            day19.ClickExtAndSleep();
            YearDD.ClicksExt();
            Year1992.ClickExtAndSleep();

            //Thread.Sleep(1000);
            //February.Click();
            //Thread.Sleep(1000);
            //February.Click();
            //DayDD.Click();
            //Thread.Sleep(1000);
            //day19.Click();
            //YearDD.Click();
            //Thread.Sleep(1000);
         /*   YearDD.ClicksExt(); */// ext method click demo
            
        }
        public void FillRegistration(string firstname, string lastname, string phonenumber, string username, string email, string description, string password, string passwordconfirm)
        {
            Fnamefield.SendKeys(firstname);
            Lnamefield.SendKeys(lastname);
            Phone.SendKeys(phonenumber);
            Username.SendKeys(username);
            Email.SendKeys(email);
            Thread.Sleep(2000);
            Description.SendKeys(description);
            Password.SendKeys(password);
            PasswordConfirm.SendKeys(passwordconfirm);
        }

        public void Months12()
        {
            SelectElement elementselected = new SelectElement(webdriver.FindElement(By.Id("mm_date_8")));
            IList<IWebElement> elementcount = elementselected.Options;
            int countmonths = elementcount.Count();

            for (int i = 1; i < countmonths; i++)
            {
                if (countmonths == 13)
                {
                    string okmsg = "12 months in list and month text";
                    Assert.IsTrue(countmonths == 13, okmsg);
                }
                else
                {
                    string errmsg = "Month list changed";
                    Assert.Fail(errmsg, countmonths);
                }
            }
        }
        
        public void uploadpic(IWebDriver driver)
        {
            //File.Exists(url);
            webdriver.Navigate();
            webdriver.FindElement(By.Id("profile_pic_10")).SendKeys(@"D:\images.png");
            Submitbtn.Click();
        }
    }

}
