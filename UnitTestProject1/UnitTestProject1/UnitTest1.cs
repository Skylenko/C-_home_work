using System;
using Selenium;
using NUnit;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1
{
    [TestFixture]
    public class Test
    {
        private IWebDriver driver;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TeardownTest()
        {
            driver.Quit();
        }

        [Test]
        public void TheTest()
        {
            string Title = "Hotline - сравнить цены в интернет-магазинах Украины";

            driver.Navigate().GoToUrl("https://www.google.com.ua/?gfe_rd=cr&dcr=0&ei=jm0RWvboK4Xb8AehpKTQCQ");

            IWebElement searchFild = driver.FindElement(By.XPath("//input[@id='lst-ib']"));
            searchFild.Click();
            searchFild.SendKeys("hotline");
            driver.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='rso']/div[1]/div/div/div/div/h3/a")));
            IWebElement hotlineLink = driver.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div/div/div/h3/a"));
            hotlineLink.Click();

            String title = driver.Title;
            Assert.AreEqual(title, Title);
        }
    }
}


