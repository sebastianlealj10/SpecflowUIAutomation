using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecflowUIAutomation.PageObjects.SearchingPage
{
    class SearchPageValidator
    {
        private readonly IWebDriver _browser;
        private WebDriverWait _wait;

        public SearchPageValidator(IWebDriver browser, WebDriverWait wait)
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

        public void ResultsCount(int expectedCount)
        {

            Assert.IsTrue(Map.Items.Count.Equals(expectedCount),"The dresses number is no correct");
        }
    }
}
