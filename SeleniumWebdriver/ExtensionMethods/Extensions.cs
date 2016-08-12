using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ExtensionMethods
{
    public static class Extensions
    {
        private static IWebDriver driver;

        public static void ClicksExt(this IWebElement element)
        {
            element.Click();
        }

        public static void ClickExtAndSleep(this IWebElement element)
        {
            element.Click();
            Thread.Sleep(1000);
        }

        public static void FillLoginExt(this IWebElement element, string EnterSomeText)
        {
            element.Clear();
            element.SendKeys(EnterSomeText);
        }

        public static void DragAndDropExt(this IWebElement element, int x, int y, Actions act)
        {
            act.ClickAndHold(element);
            act.MoveToElement(element, x, y).Perform();
            act.Release(element);
        }

    }
}
