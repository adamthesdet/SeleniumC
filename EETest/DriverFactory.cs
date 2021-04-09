using System;
using EEFrameWork.Base;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace EEFrameWork
{
    public class DriverFactory
    {

        public enum BrowserType
        {
            FireFox,
            Chrome
        }
        public static  void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {

                switch (browserType)
                {
                    case BrowserType.FireFox:

                        //Fixed Deprecation
                        var options = new FirefoxOptions();
                        options.SetPreference("BrowserName", "firefox");
                        options.SetPreference("BrowserVersion", "86.0");
                        DriverContext.Driver = new FirefoxDriver(options);
                        //DriverContext.Browser = new Browser(DriverContext.Driver);

                        break;
                    case BrowserType.Chrome:
                        var caps = new ChromeOptions();
                        caps.BrowserVersion = "89";
                        DriverContext.Driver = new ChromeDriver(caps);
                        //DriverContext.Browser = new Browser(DriverContext.Driver);
                        break;
                    default:
                        Console.WriteLine("Nope");
                        break;
                }
        }
    }
}