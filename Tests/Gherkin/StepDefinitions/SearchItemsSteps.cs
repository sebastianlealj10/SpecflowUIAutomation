using NUnit.Framework;
using SpecflowUIAutomation.PageObjects;
using SpecflowUIAutomation.PageObjects.MainPage;
using TechTalk.SpecFlow;

namespace SpecflowUIAutomation.Tests.Gherkin.StepDefinitions
{
    [Binding]
    public class SearchItemsSteps
    {
        private int _number;
        private PageBase _pagebase = new PageBase();



        private HomePage homepage;
        [Given(@"I have entered to a website")]
        public void GivenIHaveEnteredToAWebsite()
        {
            homepage = _pagebase.HomePage();
            //homepage.Goto();
        }

        [When(@"I have searched ""(.*)""")]
        public void WhenIHaveSearched(string item)
        {

            homepage.SearchItems(item);
        }

        //private SearchPage searchpage;
        [Then(@"The website shows ""(.*)"" dresses")]
        public void ThenTheWebsiteShowsDresses(int items)
        {
            //searchpage = _pagebase.Searchpage();
            //_number = searchpage.Countdresses();
            Assert.AreEqual(items, _number);
        }

        [BeforeScenario]
        public void SetUp() => _pagebase.Beforetest();

        [AfterScenario]
        public void TearDown() => _pagebase.Aftertest();
    }
}

