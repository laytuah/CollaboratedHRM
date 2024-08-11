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
        PimPage _pimPage;
        AddEmployeePage _addEmployeePage;
        PersonalDetailsPage _personalDetailsPage;

        public LoginStepDefinition(IObjectContainer objectContainer)
        {
            _loginPage = objectContainer.Resolve<LoginPage>();
            _homePage = objectContainer.Resolve<HomePage>();
            _basePage = objectContainer.Resolve<BasePage>();
            _pimPage = objectContainer.Resolve<PimPage>();
            _addEmployeePage = objectContainer.Resolve<AddEmployeePage>();
            _personalDetailsPage = objectContainer.Resolve<PersonalDetailsPage>();
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

        [When(@"user clicks on PIM button")]
        public void WhenUserClicksOnPIMButton()
        {
            _homePage.clickPimButton();
        }

        [When(@"user click on Add button")]
        public void WhenUserClickOnAddButton()
        {
            _pimPage.clickAddButton();
        }


        [When(@"user fill in User Employee Firstname, MiddleName, Lastname as '([^']*)', '([^']*)' and '([^']*)' respectively")]
        public void WhenUserFillInUserEmployeeFirstnameMiddleNameLastnameAsAndRespectively(string name, string middlename, string lastname)
        {
            _addEmployeePage.fillFirstName(name);
            _addEmployeePage.fillMiddleName(middlename);
            _addEmployeePage.fillInLastName(lastname);
        }

        [When(@"user click the save button")]
        public void WhenUserClickTheSaveButton()
        {
            _addEmployeePage.clickSaveButton();
        }

        [When(@"user fill in OtherId, Driver License Number and License Expiry date as '([^']*)', '([^']*)' and '([^']*)' respectively")]
        public void WhenUserFillInOtherIdDriverLicenseNumberAndLicenseExpiryDateAsAndRespectively(string otherid, string license, string licenseDate)
        {
            _personalDetailsPage.inputOtherId(otherid);
            _personalDetailsPage.inputDriverLicenseNumber(license);
            _personalDetailsPage.fillLicenseExpiryDate(licenseDate);
        }

        [When(@"user also fill Nationality, Marital Status, Date of Birth and Gender as '([^']*)', '([^']*)', '([^']*)' and Male respectively")]
        public void WhenUserAlsoFillNationalityMaritalStatusDateOfBirthAndGenderAsAndMaleRespectively(string nationality, string status, string date)
        {
            _personalDetailsPage.selectNationality(nationality);
            _personalDetailsPage.selectMaritalStatus(status);
            _personalDetailsPage.fillDateOfBirth(date);
            _personalDetailsPage.tickGender();
        }

        [When(@"user click save button")]
        public void WhenUserClickSaveButton()
        {
            _personalDetailsPage.clickSaveButton();
        }

        [Then(@"user verify that new employee is successfully added")]
        public void ThenUserVerifyThatNewEmployeeIsSuccessfullyAdded()
        {
            _pimPage.byVerifyEmployeeDisplayed();
        }


    }
}
