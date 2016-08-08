using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [FindsBy(How = How.ClassName, Using = "input_fields  radio_fields")]
        IWebElement SingleRadioField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='dance']")]
        IWebElement CheckBoxDance { get; set; }

        [FindsBy(How = How.Id, Using = "dropdown_7")]
        IWebElement CountryDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "mm_date_8")]
        IWebElement MonthDD { get; set; }

        [FindsBy(How = How.Id, Using = "dd_date_8")]
        IWebElement DayDD { get; set; }

        [FindsBy(How = How.Id, Using = "yy_date_8")]
        IWebElement YearDD { get; set; }

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
        public void FillRegistration(string firstname, string lastname, string maritalstatus, string hobby, string country, string month, string day, string year, int phonenumber, string username, string email, string profilepicfile, string description, string password, string passwordconfirm)
        {
            Fnamefield.Clear();
            Fnamefield.SendKeys(firstname);
            Lnamefield.Clear();
            Lnamefield.SendKeys(lastname);
            SingleRadioField.Click();
            CheckBoxDance.Clear();
            CheckBoxDance.Click();
            CountryDropDown.Click();
            MonthDD.Click();
            DayDD.Click();
            YearDD.Click();

        }
    }

}
