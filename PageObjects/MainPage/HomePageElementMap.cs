using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecflowUIAutomation.PageObjects.MainPage
{
    class HomePageElementMap
    {
        private readonly IWebDriver _browser;
        

        public HomePageElementMap(IWebDriver driver)
        {
            _browser = driver;
        }

        public IWebElement SearchBar
        {
            get
            {
                return _browser.FindElement(By.Id("search_query_top")); 
            }
        }


        public IWebElement SearchButton
        {
            get
            {
                return _browser.FindElement(By.Name("submit_search"));
            }
        }

    }

}
