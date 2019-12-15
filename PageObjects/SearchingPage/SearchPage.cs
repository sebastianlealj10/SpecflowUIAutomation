using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace SpecflowUIAutomation.PageObjects.SearchingPage
{
    class SearchPage
    {
        private readonly IWebDriver _browser;
        private WebDriverWait _wait;


        public SearchPage(IWebDriver browser, WebDriverWait wait)
        {
            _browser = browser;
            _wait = wait;

        }

        protected SearchPageElementMap Map
        {
            get
            {
                return new SearchPageElementMap(_browser, _wait);
            }
        }

        public SearchPageValidator Validate()
        {
            return new SearchPageValidator(_browser, _wait);
        }

    }
}
