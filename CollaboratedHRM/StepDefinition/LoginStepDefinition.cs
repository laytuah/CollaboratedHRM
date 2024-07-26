using CollaboratedHRM.Pages;
using CollaboratedHRM.Setup;
using TechTalk.SpecFlow;

namespace CollaboratedHRM.StepDefinition
{
    [Binding]
    public class LoginStepDefinition
    {
        Base _base;
        LoginPage _loginPage;
        HomePage _homePage;
        public LoginStepDefinition(Base basee, LoginPage login, HomePage homePage)
        {
            _base = basee;
            _loginPage = login;
            _homePage = homePage;

        }
        [Given(@"That OrangeHRM has loaded successfully")]
        public void GivenThatOrangeHRMHasLoadedSuccessfully()
        {
            _base.LoadApplicationUnderTest();
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
