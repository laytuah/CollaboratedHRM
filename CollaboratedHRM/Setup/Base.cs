using BoDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace CollaboratedHRM.Setup
{
    [Binding]
    public class Base
    {
        private readonly IObjectContainer _objectContainer;
        public IWebDriver _driver;
        string baseUrl = "https://opensource-demo.orangehrmlive.com/";

        public Base(IObjectContainer objectContainer, string browser)
        {
            _objectContainer = objectContainer;
            _driver = InitializeDriver(browser);
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
        }

        private IWebDriver InitializeDriver(string browser)
        {
            IWebDriver driver;
            switch (browser.ToLower())
            {
                case "firefox":
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    driver = new FirefoxDriver(firefoxOptions);
                    break;
                case "chrome":
                    ChromeOptions chromeOptions = new ChromeOptions();
                    driver = new ChromeDriver(chromeOptions);
                    break;
                case "edge":
                    EdgeOptions edgeOptions = new EdgeOptions();
                    driver = new EdgeDriver(edgeOptions);
                    break;
                default:
                    throw new ArgumentException("Unsupported browser: " + browser);
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return driver;
        }


        public void LoadApplicationUnderTest()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            _driver.Navigate().GoToUrl(baseUrl);
            _driver.Manage().Window.Maximize();

        }

        [AfterScenario]
        public void CloseApplicationUnderTest()
        {
            _driver?.Quit();
        }
    }
}
