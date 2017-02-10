using NUnit.Framework;
using AutomationFramework;

namespace AutomationTestFramework
{
    class InitialPage: setupclass
    {
       [Test]
        public void homepage_FirstPage()
        {
            way2automation w2 = new way2automation(this.Driver);
            w2.Navigate();
            var phone= w2.phonenumber.Text;
            Assert.AreEqual(phone, "+91-9711-191-558");
            var email = w2.email.Text;
            Assert.AreEqual(email, "trainer@way2automation.com");
          }
       }
}
