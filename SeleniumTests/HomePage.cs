using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests
{

    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement SearchTextBox => driver.FindElement(By.Name("q"));
        public IWebElement SearchButton => driver.FindElement(By.Name("btnK"));
        public String Title => driver.Title;
        

        public IWebElement FindElement (By by)
        {
            return driver.FindElement(by);
        }

        public bool HasElement(By by)
        {
            return driver.FindElements(by).Count > 0;
        }


    }
}
