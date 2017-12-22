using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TestFramework
{
    public class CommonTest:Common
    {

        [SetUp]
         void SetupTest()
        {
            driver.Navigate().GoToUrl("https://www.google.com");

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
         void TeardownTest()
        {
            driver.Close();
        }
    }
}


