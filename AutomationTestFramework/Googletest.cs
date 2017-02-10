using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationTestFramework
{
    [TestFixture]
    public class setupclass
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        [SetUp]
        public void SetUpTest()
        {
            Driver = new FirefoxDriver();
            Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
        }

        [TearDown]
        public void TearDown()
        {
            this.Driver.Quit();
        }
    }
}