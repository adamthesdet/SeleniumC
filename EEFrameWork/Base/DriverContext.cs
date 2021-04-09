using OpenQA.Selenium;

namespace EEFrameWork.Base
{
    public static class DriverContext
    {
        public static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get { return _driver; }

            set { _driver = value; }
        }
    }
}