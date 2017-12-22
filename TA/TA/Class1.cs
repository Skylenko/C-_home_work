using System;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject2
{
    [TestFixture]
    public class UnitTest1
    {
        public IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Init()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TeardownTest()
        {
            driver.Close();
        }

        [Test]
        public void Search()
        {
            driver.Navigate().GoToUrl("http://rozetka.com.ua/");

            Actions actions = new Actions(driver);

            string text = "Hyundai";
            IWebElement searchField = driver.FindElement(By.XPath("//input[@name='text']"));
            actions.MoveToElement(searchField).Perform();
            searchField.SendKeys(text);
            searchField.SendKeys(Keys.Enter);

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='active']")));

            IList<IWebElement> elements = driver.FindElements(By.XPath("//div[@class='g-i-tile-i-title clearfix']"));

            string title = "";
            foreach (IWebElement element in elements)
            {
                title = element.Text;
            }
            Assert.IsTrue(condition: title.Contains("Hyundai"));

            IWebElement show32elements = driver.FindElement(By.XPath("//span[@class ='g-i-more-link-text']"));
            Assert.IsTrue(show32elements.Displayed);
        }

        [Test]
        public void Filtering()
        {
            driver.Navigate().GoToUrl("http://rozetka.com.ua/mobile-phones/c80003/preset=smartfon/");

            Actions actions = new Actions(driver);
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));

            IWebElement sams = driver.FindElement(By.XPath("//*[@id='filter_producer_12']/label/a/span/i[1]"));
            actions.MoveToElement(sams).Perform();

            sams.Click();
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='reset_filter12']/a")));

            IWebElement apple = driver.FindElement(By.XPath("//*[@id='filter_producer_69']/label/a/span/i[1]"));
            apple.Click();
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='reset_filter69']/a")));

            IWebElement sorting = driver.FindElement(By.XPath("//a[@name='drop_link']"));
            sorting.Click();

            IWebElement sortDropDown = driver.FindElement(By.XPath("//*[@id='sort_view']/div"));

            wait.Until(ExpectedConditions.TextToBePresentInElement(sortDropDown, "от дорогих к дешевым"));

            IWebElement desc = driver.FindElement(By.XPath("//*[@id='filter_sortexpensive']/a"));
            desc.Click();

            IWebElement field = driver.FindElement(By.XPath("//*[@id='sort_view']/a"));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='sort_view']/div")));

            IList <IWebElement> prices = driver.FindElements(By.XPath("//div[@class='g-price-uah']"));

            string getPrice = null;
           
            IList<int> result = new List<int>();
            foreach (IWebElement element in prices)
            {
                getPrice = element.Text;
                var price = int.Parse(getPrice.Replace(" ", "").Substring(0, getPrice.IndexOf('г')-1).Trim());

                result.Add(price);
            }
            Assert.IsTrue(result[0] > result[1]);
        }
    }
}
