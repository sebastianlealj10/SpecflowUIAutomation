using OpenQA.Selenium;

namespace SpecflowUIAutomation.PageObjects.MainPage
{
    class HomePage
    {
        private readonly IWebDriver _browser;
        private readonly string _url = @"http://automationpractice.com/index.php";

        public HomePage(IWebDriver driver)
        {
            _browser = driver;
        }

        protected HomePageElementMap Map
        { 
            get
            {
                return new HomePageElementMap(_browser);
            }
        }

        public HomePageValidator Validate()
        {
            return new HomePageValidator(_browser);
        }

        public void SearchItems(string item)
        {
            Map.SearchBar.Clear();
            Map.SearchBar.SendKeys(item);
            Map.SearchButton.Click();
        }
        public void Navigate()
        {
            _browser.Navigate().GoToUrl(_url);
        }
    }
}

