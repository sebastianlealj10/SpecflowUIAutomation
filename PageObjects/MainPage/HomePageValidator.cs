using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowUIAutomation.PageObjects.MainPage
{
    
    class HomePageValidator
    {
        private readonly IWebDriver _browser;
        public HomePageValidator(IWebDriver browser)
            {
                _browser = browser;
            }
    
    protected HomePageElementMap Map
    {
        get 
        { 
            return new HomePageElementMap(_browser);
        }
    }
    }
}