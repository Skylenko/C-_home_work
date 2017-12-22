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
    class GoogleSearchPage:Common
    {
        public const string Title = "Hotline - сравнить цены в интернет-магазинах Украины";

        public void Search()
        {
            IWebElement searchFild = driver.FindElement(By.Id("lst - ib"));
            IWebElement hotlineLink = driver.FindElement(By.XPath("//a[@href='/url?sa=t&rct=j&q=&esrc=s&source=web&cd=1&cad=rja&uact=8&ved=0ahUKEwjEnoCGmtTXAhXrDpoKHbD1DBsQFggyMAA&url=http%3A%2F%2Fhotline.ua%2F&usg=AOvVaw2yXP-286qiD6XLUmjrKXnt']"));
            IWebElement searchButton = driver.FindElement(By.XPath("//span[@class='sbico _wtf _Qtf']"));

            searchFild.Clear();
            searchFild.SendKeys("hotline");
            searchButton.Click();
            hotlineLink.Click();
            String title = driver.Title;
            Assert.AreEqual(title, Title);
        }
    }
}
