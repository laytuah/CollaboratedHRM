using OpenQA.Selenium;

namespace CollaboratedHRM.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        private IWebElement UsernameTextField => Driver.FindElement(By.Name("username"));
        private IWebElement PasswordTextField => Driver.FindElement(By.Name("password"));
        private IWebElement SignIn_button => Driver.FindElement(By.XPath("//button[@type='submit']"));

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
