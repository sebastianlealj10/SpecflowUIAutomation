using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
namespace SpecflowUIAutomation.PageObjects.SearchingPage
{
    class SearchPageElementMap
    {
        private readonly IWebDriver _browser;
        private WebDriverWait _wait;
        public SearchPageElementMap(IWebDriver browser, WebDriverWait wait)
        {
            _browser = browser;
            _wait = wait;
        }
        public IList<IWebElement> Items
        {
            get
            {
                _wait.Until(d => d.FindElement(By.CssSelector(".ajax_block_product")));
                return _browser.FindElements(By.CssSelector(".ajax_block_product"));
            }
        }
    }
}
