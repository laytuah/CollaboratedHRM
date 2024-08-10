using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace CollaboratedHRM.Pages
{
    public class AddEmployeePage : BasePage
    {
        public AddEmployeePage(IWebDriver driver) : base(driver) { }

        By FirstName = By.Name("firstName");

        By MiddleName = By.Name("middleName");

        By LastName = By.Name("lastName");

        By SaveButton = By.XPath("//div[2]/button[2]");
        

        public void fillFirstName(string name)
        {
            Driver.FindElement(FirstName).SendKeys(name);
        }        

        public void fillMiddleName(string middlename)
        {
            Driver.FindElement(MiddleName).SendKeys(middlename);
        }

        public void fillInLastName(string lastname)
        {
            Driver.FindElement(LastName).SendKeys(lastname);
        }        

        public PersonalDetailsPage clickSaveButton()
        {
            Driver.FindElement(SaveButton).Click();
            return new PersonalDetailsPage(Driver);
        }
    }
}
