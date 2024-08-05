using OpenQA.Selenium;

namespace CollaboratedHRM.Pages
{
    public class BasePage
    {
        public IWebDriver Driver;
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void LoadApplicationUnderTest()
        {
            Driver.Navigate().GoToUrl(_webGetDataparsar().ExtractData("BaseUrl"));
            Driver.Manage().Window.Maximize();
        }
    }
}
