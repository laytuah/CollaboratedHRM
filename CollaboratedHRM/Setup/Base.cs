using BoDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace CollaboratedHRM.Setup
{
    [Binding]
    public class Base
    {
        private readonly IObjectContainer _objectContainer;
        public IWebDriver _driver;
        string baseUrl = "https://opensource-demo.orangehrmlive.com/";

        public Base(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
            ChromeOptions options = new ChromeOptions();
            _driver = new ChromeDriver(options);
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
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
