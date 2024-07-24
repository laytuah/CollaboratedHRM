using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaboratedHRM.Pages
{
    public class HomePage
    {

        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement LoginName() 
        {
            return _driver.FindElement(By.XPath("//p[@class='oxd-userdropdown-name']"));
        }
        public void GetUsername() 
        {
            String confirmLoginName = LoginName().Text;
            StringAssert.Contains("Mojisola Otusheso", confirmLoginName);
        }
    }
}
