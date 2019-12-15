using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SpecflowUIAutomation.PageObjects.MainPage;
using SpecflowUIAutomation.PageObjects.SearchingPage;
using System;
using System.IO;

namespace SpecflowUIAutomation.Tests
{
    [TestFixture]
    public class SearchItems
    {
        private static readonly string path =
            Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        [SetUp]
        public void SetupTest()
        {
            Driver = new ChromeDriver(path + "\\drivers");
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
        }

        [TearDown]
        public void TeardownTest()
        {
            Driver.Quit();
        }

        [Test]
        public void SearchDresses()
        {
            var storeHomePage = new HomePage(Driver);
            storeHomePage.Navigate();
            storeHomePage.SearchItems("dress");
            var storeSearchPage = new SearchPage(Driver, Wait);
            storeSearchPage.Validate().ResultsCount(7);
        }
    }
}
