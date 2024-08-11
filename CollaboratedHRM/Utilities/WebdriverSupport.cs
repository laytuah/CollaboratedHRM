using BoDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports;
using NUnit.Framework.Interfaces;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium.DevTools.V125.Page;
using AventStack.ExtentReports.Reporter.Configuration;



namespace CollaboratedHRM.Utilities
{
    public class WebdriverSupport
    {
        
        private readonly IObjectContainer _objectContainer;
        public IWebDriver _driver;
        ExtentTest test;
        ExtentReports extent;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;

        public WebdriverSupport(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;

        }
        
       


        public void InitializeBrowser(string browser)
        {
          //test=  extent.CreateTest(TestContext.CurrentContext.Test.Name);
            switch (browser.ToLower())
            {
                case "firefox":
                    _driver = new FirefoxDriver();
                    break;
                case "chrome":
                    ChromeOptions chromeOptions = new ChromeOptions();
                    _driver = new ChromeDriver(chromeOptions);
                    break;
                case "edge":
                    EdgeOptions edgeOptions = new EdgeOptions();
                    _driver = new EdgeDriver(edgeOptions);
                    break;
                default:
                    throw new ArgumentException("Unsupported browser: " + browser);
            }
            _objectContainer.RegisterInstanceAs(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void CloseApplicationUnderTest()
        {
           
  
            _driver?.Quit();
            
        }
       
    }

}
