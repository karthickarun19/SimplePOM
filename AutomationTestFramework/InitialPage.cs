using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace AutomationTestFramework
{
    class InitialPage: Googletest
    {
            
        [Test]
        public void SearchTextInGoogle_FirstPage()
        {
            GooglePage googlepage = new GooglePage(this.Driver);
            googlepage.Navigate();
            googlepage.Search("selenium webdriver");
            
        }
    }
}
