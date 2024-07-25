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
        private IWebElement GetLoginName()
        {
            return _driver.FindElement(By.XPath("//p[@class='oxd-userdropdown-name']"));
        }
        public void GetUsername() 
        {
            String confirmLoginName = GetLoginName().Text;
            StringAssert.Contains("Mojisola Otusheso", confirmLoginName);
        }
        private IWebElement GetGraph() 
        {
            return _driver.FindElement(By.XPath("(//canvas)[1]"));
        }
        private IWebElement GetPiechart() 
        {
            return _driver.FindElement(By.CssSelector("canvas[id='3CY4L7Ra']"));
        }
        public bool BarchartDisplay()
        {
           return GetGraph().Displayed;
           
        }
        IWebElement GetDashboard=> _driver.FindElement(By.XPath("//h6[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module']"));
        
        public bool DisplayDashbord()
        {
            return GetDashboard.Displayed;
        }
        
    }
}
