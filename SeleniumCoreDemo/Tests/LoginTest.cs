using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCoreDemo.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumCoreDemo.Tests
{
    class LoginTest
    {
        //Open browser --https://www.youtube.com/watch?v=KlhGcwFBKoY
        IWebDriver webDriver = new ChromeDriver(@"C:\Program Files\Google\Chrome");

        [SetUp]
        public void Setup()
        {
            //Navigate to site
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            Thread.Sleep(2000);

        }

        [Test]
        public void Login()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("admin","password");

            Assert.That(homePage.IsEmployeeDetailsExist, Is.True);

        }

        [TearDown]
        public void TearDown() => webDriver.Quit();
    }
}
