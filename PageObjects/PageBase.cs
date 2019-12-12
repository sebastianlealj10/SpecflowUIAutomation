using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
namespace SpecflowUIAutomation.PageObjects
{
    class PageBase
    {
        private static readonly string path = 
            Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

        public IWebDriver _driver;
        public void Beforetest()
        {
            _driver = new ChromeDriver(path + "\\Drivers");
        }
        public HomePage HomePage()
        {
            return new HomePage(_driver);
        }

        public SearchPage Searchpage()
        {
            return new SearchPage(_driver);
        }

        public void Aftertest()
        {
            _driver.Close();
        }
    }
}
