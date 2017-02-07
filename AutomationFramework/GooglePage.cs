using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework
{
   public  class GooglePage
    {
        public readonly IWebDriver driver;
        public readonly string url = @"https://www.google.com/";

        public GooglePage(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(browser, this);
        }
        [FindsBy(How =How.Id,Using = "gs_lc0")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='_fZl']")]
        public IWebElement GoButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='resultStats']")]
        public IWebElement ResultsCountDiv { get; set; }

         public void Navigate()
        {
            this.driver.Navigate().GoToUrl(this.url);
        }
        public void Search(string textToType)
        {
            this.SearchBox.SendKeys(textToType);
            this.GoButton.Click();
        }
        
    }
}
