using NUnit.Framework;

namespace EEFrameWork.Base
{
    public class Base
    {
        [SetUp]
        public void AhWeGoingToTestNow()
        {

            DriverFactory.OpenBrowser(DriverFactory.BrowserType.FireFox);
            DriverContext.Driver.Navigate().GoToUrl("http://hotel-test.equalexperts.io/");
        }

        [TearDown]
        public void YouGotTested()
        {
            DriverContext.Driver.Quit();

        }
    }
}