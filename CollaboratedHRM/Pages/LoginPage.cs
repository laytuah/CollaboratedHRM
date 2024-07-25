using OpenQA.Selenium;

namespace CollaboratedHRM.Pages
{
     public class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement UsernameTextField => _driver.FindElement(By.Name("username"));
        private IWebElement PasswordTextField => _driver.FindElement(By.Name("password"));
        private IWebElement SignIn_button => _driver.FindElement(By.XPath("//button[@type='submit']"));

        public void InsertUserName(string username)
        {
            UsernameTextField.SendKeys(username);
        }

        public void UpdatePassword(string password) 
        {
            PasswordTextField.Clear();
            PasswordTextField.SendKeys(password);
        }
        public void clickSignIN() 
        {
            SignIn_button.Click();
        }
    }
}
