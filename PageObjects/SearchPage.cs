using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowUIAutomation.PageObjects
{
    class SearchPage
    {
        private IWebDriver driver;
        private IList<IWebElement> Dresses => driver.FindElements(By.CssSelector(".ajax_block_product"));
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public int Countdresses()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            _ = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".ajax_block_product")));
            return Dresses.Count();
        }
    }
}
