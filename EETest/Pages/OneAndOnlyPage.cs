using System;
using EEFrameWork.Base;
using EEFrameWork.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace EETest.Pages
{
    public class OneAndOnlyPage : BasePage
    {
        private IWebElement firstName => WebElementHelper.WaitAndFind(By.Id("firstname"));


        public void EnterName(string name)
        {
            firstName.SendKeys(name);
        }   
        //public void EnterSureName(string sureName)
        //{
        //    this.sureName.SendKeys(sureName);
        //}
        //public void EnterPrice(string pricePerNight)
        //{
        //    price.SendKeys(pricePerNight);
        //}


    }
}