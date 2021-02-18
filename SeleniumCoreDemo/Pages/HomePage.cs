using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCoreDemo.Pages
{
    public class HomePage
    {
        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }
        public IWebElement linkLogin => Driver.FindElement(By.LinkText("Login"));

        IWebElement linkEmployeeDetails => Driver.FindElement(By.LinkText("Employee Details"));

        public void ClickLogin() => linkLogin.Click();

        public bool IsEmployeeDetails() => linkEmployeeDetails.Displayed;


    }
}
