using EEFrameWork.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace EEFrameWork.Base
{
    public abstract class BasePage  : DriverFactory
    {

        public readonly IWebDriver Driver;
        public DefaultWait<IWebDriver> FluentWait;


        public BasePage()
        {
            this.Driver = DriverContext.Driver;
            WebElementHelper = new WebElementHelper(this);

        }
        public WebElementHelper WebElementHelper { get; }



    }
}