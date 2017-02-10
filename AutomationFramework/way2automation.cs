using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace AutomationFramework
{
   public  class way2automation
    {
        public readonly IWebDriver driver;
        public readonly string url = @"http://www.way2automation.com/demo.html";
        
        public way2automation(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(browser, this);
        }
        [FindsBy(How =How.XPath,Using = "//*[@id='wrapper']/header/div/div[2]/ul/li[1]")]
        public IWebElement phonenumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='wrapper']/header/div/div[2]/ul/li[2]/a")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='toggleNav']/li[1]/a")]
        public IWebElement Home { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='toggleNav']/li[7]/a")]
        public IWebElement Alert { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='toggleNav']/li[2]/a")]
        public IWebElement Interactions { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='toggleNav']/li[3]/a")]
        public IWebElement Widget { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='toggleNav']/li[4]/a")]
        public IWebElement FramesandWindows { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='toggleNav']/li[5]/a")]
        public IWebElement DynamicElements { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='toggleNav']/li[6]/a")]
        public IWebElement Registration { get; set; }

        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(this.url);
        }

        
        
        
    }
}
