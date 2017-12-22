using System;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace UnitTestProject2
{
    [TestFixture]
    public class UnitTest1
    {
        public IWebDriver driver;

        [SetUp]
        void SetupTest()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://rozetka.com.ua/");

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        void TeardownTest()
        {
            driver.Close();
        }

        [Test]
        public void Search()
        {
            IWebElement searchField = driver.FindElement(By.XPath("//input[@class='rz-header-search-input-text passive']"));
            IList<IWebElement> elements = driver.FindElements(By.XPath("//div[@class='g-i-tile-i-title clearfix']"));
            IWebElement show32elements = driver.FindElement(By.XPath("//span[@class ='g-i-more-link-text']"));

            searchField.SendKeys("Hyundai");

        }
    }
}
