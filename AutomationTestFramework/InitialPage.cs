using NUnit.Framework;
using AutomationFramework;

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
