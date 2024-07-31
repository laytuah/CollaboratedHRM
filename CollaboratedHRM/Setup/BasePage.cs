using BoDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using CollaboratedHRM.Utilities;

namespace CollaboratedHRM.Setup
{
   
    public class BasePage
    {
        private readonly IObjectContainer _objectContainer;
        public IWebDriver _driver;
        
        
        public BasePage(IObjectContainer objectContainer) 
        {
            _objectContainer = objectContainer;

        }

        //public Base(IObjectContainer objectContainer)
        //{
        //    _objectContainer = objectContainer;
        //    ChromeOptions options = new ChromeOptions();
        //    _driver = new ChromeDriver(options);
        //    _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
        //}
        public void InitializeBrowser(string browser)
        {
          
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

        public void LoadApplicationUnderTest()
        {
       
            _driver.Navigate().GoToUrl(GetDataparsar().ExtractData("BaseUrl"));
            _driver.Manage().Window.Maximize();

        }
        public JsonReader GetDataparsar()
        {
            return new JsonReader();
        }

        public void CloseApplicationUnderTest()
        {
            _driver?.Quit();
        }
    }
}
