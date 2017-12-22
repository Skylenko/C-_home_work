using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace TestFramework
{
    [TestClass]

    public class UnitTest1 : CommonTest
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            GoogleSearchPage googleSearchPage = new GoogleSearchPage();
            googleSearchPage.Search();
        }
    }
}
