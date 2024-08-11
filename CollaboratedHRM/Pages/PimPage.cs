using OpenQA.Selenium;


namespace CollaboratedHRM.Pages
{
    public class PimPage : BasePage
    {
        public PimPage(IWebDriver driver) : base(driver){ }

        By AddButton = By.XPath("//div[2]/div[1]/button");

        By VerifyEmployee = By.XPath("//span[@class='oxd-text oxd-text--span']");

        public AddEmployeePage clickAddButton()
        {
            Driver.FindElement(AddButton).Click();
            return new AddEmployeePage(Driver);
        }

        public bool byVerifyEmployeeDisplayed()
        {
            return Driver.FindElement(VerifyEmployee).Displayed;
        }
    }
}
