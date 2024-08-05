using BoDi;
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
        BasePage _basePage;
        public LoginStepDefinition(IObjectContainer objectContainer)
        {
            _loginPage = objectContainer.Resolve<LoginPage>();
            _homePage = objectContainer.Resolve<HomePage>();
            _basePage = objectContainer.Resolve<BasePage>();    
        }
        [Given(@"That OrangeHRM has loaded successfully")]
        public void GivenThatOrangeHRMHasLoadedSuccessfully()
        {
            _basePage.LoadApplicationUnderTest();
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
