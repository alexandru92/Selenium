using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebdriver.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Demoqa.com.Dragable
{
    public class Dragable
    {
        private readonly IWebDriver driver;
        string urldraggable = @"http://www.demoqa.com/draggable";
        public Dragable(IWebDriver webdriver)
        {
            this.driver = webdriver;
            PageFactory.InitElements(webdriver, this);
        }

        [FindsBy(How = How.Id, Using = "draggable")]
        IWebElement draggablebox { get; set; }

        [FindsBy(How = How.ClassName, Using = "inside_contain")]
        IWebElement insidecontainer { get; set; }

        public void OpenUrl()
        {
            driver.Navigate().GoToUrl(urldraggable);
            driver.Manage().Window.Maximize();
        }

        public void DragandDrop()
        { //Drag and drop using extension method
            Actions act = new Actions(driver);
            draggablebox.DragAndDropExt(200, 200, act);
            Thread.Sleep(3000);

            //Actions act = new Actions(driver);
            //act.ClickAndHold(draggablebox);
            //act.MoveToElement(draggablebox, 289, 98).Perform();
            //act.Release(draggablebox);
        }
    }



}
