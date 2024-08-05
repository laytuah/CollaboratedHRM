using CollaboratedHRM.Configuration;
using CollaboratedHRM.Utilities;
using TechTalk.SpecFlow;

namespace CollaboratedHRM.Hook
{
    [Binding]
    internal class Hook
    {
        WebdriverSupport _webdriverSupport;
        public Hook(WebdriverSupport webdriverSupport)
        {
            _webdriverSupport = webdriverSupport;
        }
        [BeforeScenario]
        public void BeforeScenario()
        {
            _webdriverSupport.InitializeBrowser(ConfigurationManager.BrowserName);
        }
        [AfterScenario]
        public void AfterScenario()
        {
            _webdriverSupport.CloseApplicationUnderTest();
        }
    }
}
