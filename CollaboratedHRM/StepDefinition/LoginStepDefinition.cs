using CollaboratedHRM.Pages;
using CollaboratedHRM.Utilities;
using TechTalk.SpecFlow;

namespace CollaboratedHRM.StepDefinition
{
    [Binding]
    public class LoginStepDefinition
    {
        LoginPage _loginPage;
        HomePage _homePage;
        WebdriverSupport _webdriverSupport;
        public LoginStepDefinition(WebdriverSupport webdriverSupport, LoginPage login, HomePage homePage)
        {
            _loginPage = login;
            _homePage = homePage;
            _webdriverSupport = webdriverSupport;

        }
        [Given(@"That OrangeHRM has loaded successfully")]
        public void GivenThatOrangeHRMHasLoadedSuccessfully()
        {
            _webdriverSupport.LoadApplicationUnderTest();
        }

        [When(@"user insert ""([^""]*)"" has username")]
        public void WhenUserInsertHasUsername(string username)
        {
            _loginPage.InsertUserName(username);
        }

        [When(@"user inserts ""([^""]*)"" as password")]
        public void WhenUserInsertsAsPassword(string password)
        {
            _loginPage.UpdatePassword(password);
        }

        [When(@"user clicks on Login Button")]
        public void WhenUserClicksOnLoginButton()
        {
            _loginPage.clickSignIN();
        }

        [Then(@"Then user is logged in successfully")]
        public void ThenThenUserIsLoggedInSuccessfully()
        {
            Assert.IsTrue(_homePage.IsBarchartDisplay());
            Assert.IsTrue(_homePage.IsConfirmationPieChartDisplayed());
        }
    }
}
