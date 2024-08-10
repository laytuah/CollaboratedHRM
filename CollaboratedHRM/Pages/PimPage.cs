using OpenQA.Selenium;


namespace CollaboratedHRM.Pages
{
    public class PimPage : BasePage
    {
        public PimPage(IWebDriver driver) : base(driver){ }

        By AddButton = By.XPath("//div[2]/div[1]/button");

        public AddEmployeePage clickAddButton()
        {
            Driver.FindElement(AddButton).Click();
            return new AddEmployeePage(Driver);
        }
    }
}
