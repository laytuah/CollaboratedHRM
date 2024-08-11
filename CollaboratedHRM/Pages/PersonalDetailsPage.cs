using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace CollaboratedHRM.Pages
{
    public class PersonalDetailsPage : BasePage
    {
        public PersonalDetailsPage(IWebDriver driver) : base(driver) { }

        By OtherId = By.XPath("//div[@id='app']//form//div[2]/div[1]/div[2]/div/div[2]/input");

        By DriverLicenseNumber = By.XPath("//div[@id='app']//form/div[2]/div[2]/div[1]/div/div[2]/input");

        By LicenseExpiryDate = By.XPath("//div[@id='app']//form/div[2]/div[2]/div[2]/div/div[2]/div/div/input");

        By Nationality = By.XPath("(//div[@class='oxd-select-text-input'])[1]");        

        By MaritalStatus = By.XPath("(//div[@class='oxd-select-text-input'])[2]");

        By DateOfBirth = By.XPath("//div[@id='app']//form/div[3]/div[2]/div[1]/div/div[2]/div/div/input");

        By Gender = By.XPath("//div[@id='app']//form/div[3]/div[2]/div[2]/div/div[2]/div[1]/div[2]/div/label/span");

        By SaveButton = By.XPath("//div[1]/form/div[4]/button");

        public void inputOtherId(string otherid)
        {
            Thread.Sleep(5000);
            Driver.FindElement(OtherId).SendKeys(otherid);
        }

        public void inputDriverLicenseNumber(string license)
        {            
            Driver.FindElement(DriverLicenseNumber).SendKeys(license);
        }

        public void fillLicenseExpiryDate(string licenseDate)
        {            
            Driver.FindElement(LicenseExpiryDate).SendKeys(licenseDate);
        }

        public void selectNationality(string nationality)
        {
            Driver.FindElement(Nationality).Click();            
            Driver.FindElement(By.XPath($"//div[@class='oxd-select-dropdown --positon-bottom']//span[contains(.,'{nationality}')]")).Click();
        }

        public void selectMaritalStatus(string status)
        {
            Driver.FindElement(MaritalStatus).Click();
            Driver.FindElement(By.XPath($"//div[@class='oxd-select-dropdown --positon-bottom']//span[contains(.,'{status}')]")).Click();
        }

        public void fillDateOfBirth(string date)
        {
            Driver.FindElement(DateOfBirth).SendKeys(date);
        }

        public void tickGender()
        {
            Driver.FindElement(Gender).Click();
        }

        public void clickSaveButton()
        {
            Driver.FindElement(SaveButton).Click();
        }
    }
}
