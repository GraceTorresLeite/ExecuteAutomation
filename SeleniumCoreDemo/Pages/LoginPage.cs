using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCoreDemo.Pages
{
    class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement textUserName => Driver.FindElement(By.Name("UserName"));

        IWebElement textPassword => Driver.FindElement(By.Name("Password"));

        IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@value='Log in']"));

        public void Login(string userName, string password)
        {
            textUserName.SendKeys(userName);
            textPassword.SendKeys(password);
            btnLogin.Submit();
        }
    }
}
