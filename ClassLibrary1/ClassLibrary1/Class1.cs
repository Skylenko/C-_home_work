using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;

namespace TestFramework
{
    [TestFixture]

     class UnitTest1
    {
        private IWebDriver driver;

        [SetUp]
       public void SetupTest()
        {
            //  public IWebDriver driver = new ChromeDriver();
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Manage().Window.Maximize();
        }

        [TearDown]
         void TeardownTest()
        {
            driver.Close();
        }

        [Test]
         void TestMethod1()
        {
            GoogleSearchPage googleSearchPage = new GoogleSearchPage();
            googleSearchPage.Search();
        }
    }
}
