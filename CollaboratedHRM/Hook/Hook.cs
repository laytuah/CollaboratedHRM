using CollaboratedHRM.Setup;
using TechTalk.SpecFlow;

namespace CollaboratedHRM.Hook
{
    [Binding]
    internal class Hook
    {

        BasePage _basepage;
        public Hook(BasePage basepage)
        {
            _basepage = basepage;   
        }
        [BeforeScenario]
        public void BeforeScenario() 
        { 
            _basepage.InitializeBrowser(_basepage.GetDataparsar().ExtractData("Browser"));
        }
        [AfterScenario]
        public void AfterScenario() 
        {
            _basepage.CloseApplicationUnderTest();
        }
    }
}
