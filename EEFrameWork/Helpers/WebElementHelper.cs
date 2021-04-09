using System;
using EEFrameWork.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace EEFrameWork.Helpers
{
    public class WebElementHelper
    {
        private readonly BasePage _basePage;


        public WebElementHelper(BasePage basePage)
        {
            _basePage = basePage;
            _basePage.FluentWait = new DefaultWait<IWebDriver>(DriverContext.Driver);
            _basePage.FluentWait.Timeout = TimeSpan.FromSeconds(10);
            //TODO add to config
            _basePage.FluentWait.PollingInterval = TimeSpan.FromMilliseconds(1000);
            _basePage.FluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            _basePage.FluentWait.Message = "Element Not Founds";
        }

        public void Click(IWebElement element)
        {

            _basePage.FluentWait.Until(ExpectedConditions.ElementToBeClickable(element))
                .Click();
        }

        public IWebElement WaitAndFind(By by)
        {
            var element =
                _basePage.FluentWait.Until(ExpectedConditions.ElementIsVisible(by));
            return element;
        }

        public SelectElement GetDropDown(IWebElement element)
        {
            var selectElement = new SelectElement(element);
            return selectElement;
        }
    }
}