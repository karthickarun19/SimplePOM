using AutomationFramework;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;


namespace  AutomationTestFramework
{
    [TestFixture]
   public class Googletest
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set;}

        [SetUp]
        public void SetUpTest()
        {
            this.Driver = new FirefoxDriver();
           this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
        }

        [TearDown]
        public void TearDown()
        {
            this.Driver.Quit();
        }

       


    }
}
