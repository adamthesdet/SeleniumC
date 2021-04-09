using System;
using System.Collections.Generic;
using System.Text;
using EEFrameWork;
using EEFrameWork.Base;
using EETest.Pages;
using NUnit.Framework;

namespace EETest
{
    [TestFixture]
    class BookingTests :Base
    {

    

        [Test]
        public void CreateNewBookingTest()
        {

            OneAndOnlyPage page = new OneAndOnlyPage();
            page.EnterName("Whoop");

        }


    }
}
