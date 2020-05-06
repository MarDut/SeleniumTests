using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTests
{
    [TestClass]
    public class HomePageTest
    {
        private IWebDriver driver;

        [TestInitialize]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5.0);
            
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Close();
        }

        [TestMethod]
        public void IndexTest()
        {
            HomePage page;
            driver.Url = "https://www.google.pl/";
            page = new HomePage(driver);

            Assert.AreEqual("Google", page.Title);
        }

        [TestMethod]
        public void SearchTest()
        {

            HomePage page;
            driver.Url = "https://www.google.pl/";
            page = new HomePage(driver);

            page.SearchTextBox.SendKeys("aaa");
            page.SearchButton.Click();

            Assert.IsTrue(page.HasElement(By.Id("result-stats")));





        }


    
    }
}
