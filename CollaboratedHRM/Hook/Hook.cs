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
            _basepage.InitializeBrowser("firefox");
        }
        [AfterScenario]
        public void AfterScenario() 
        {
            _basepage.CloseApplicationUnderTest();
        }
    }
}
