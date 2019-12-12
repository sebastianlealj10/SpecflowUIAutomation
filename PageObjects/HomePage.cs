using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowUIAutomation.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;
        private IWebElement SearchBar => driver.FindElement(By.Id("search_query_top"));
        private IWebElement SearchButton => driver.FindElement(By.Name("submit_search"));
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void SearchItems(string item)
        {
            SearchBar.SendKeys(item);
            SearchButton.Click();
        }
        public void Goto()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
    }
}

