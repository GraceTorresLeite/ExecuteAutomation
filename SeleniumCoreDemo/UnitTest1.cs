using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumCoreDemo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            

        }

        [Test]
        public void Test1()
        {
            //Open browser --https://www.youtube.com/watch?v=KlhGcwFBKoY
            IWebDriver webDriver = new ChromeDriver(@"C:\Program Files\Google\Chrome");
            //Navigate to site
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            Thread.Sleep(2000);

            // Identify login 
            IWebElement lnkLogin = webDriver.FindElement(By.LinkText("Login"));

            //Operation
            lnkLogin.Click();

            var txtuserName = webDriver.FindElement(By.Name("UserName"));

            //Assertion
            Assert.That(txtuserName.Displayed, Is.True);

            txtuserName.SendKeys("admin");

            webDriver.FindElement(By.Name("Password")).SendKeys("password");

            webDriver.FindElement(By.XPath("//input[@value='Log in']")).Submit();

            var lnkEmployeeDetails = webDriver.FindElement(By.LinkText("Employee Details"));

            Assert.That(lnkEmployeeDetails.Displayed, Is.True);
        }
    }
}