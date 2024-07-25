using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaboratedHRM.Pages
{
     public class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement UsernameTextField()
        {
            return _driver.FindElement(By.Name("username"));
        }
        public void InsertUserName(string username)
        {
            UsernameTextField().SendKeys(username);
        }
        private IWebElement PasswordTextField()
        {
            return _driver.FindElement(By.Name("password"));
        }
        public void UpdatePassword(string password) 
        {
            PasswordTextField().Clear();
            PasswordTextField().SendKeys(password);
        }
        private IWebElement signIN() 
        {
            return _driver.FindElement(By.XPath("//button[@type='submit']"));
        }
        public HomePage clickSignIN() 
        {
            signIN().Click();
            return new HomePage(_driver);
        }
    }
}
