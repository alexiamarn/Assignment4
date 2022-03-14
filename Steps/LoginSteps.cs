using Assignment4.Pages;
using NUnit.Framework;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Assignment4.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;
        private readonly ScenarioContext _scenarioContext;

        public LoginSteps(LoginPage loginPage, ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _loginPage = loginPage;
        }

        [Given(@"user navigates to homepage")]
        public async Task GivenUserNavigatesToHomepageAsync()
        {
            await _loginPage.navigateToLoginPage();
        }

        [When(@"user logins with username (.*) and password (.*)")]
        public async Task GivenUserLoginsWithUsernameAndPasswordAsync(string username, string pwd)
        {
            await _loginPage.SetCredentials(username, pwd);
            await _loginPage.SubmitLogin();
        }

        [Then(@"the user is successfully logged in")]
        public async Task TheUserIsSuccessfullyLoggedIn()
        {
            StringAssert.Contains($"Welcome", await _loginPage.GetWelcomeMsg());
        }

        [Then(@"the message (.*) is displayed")]
        public async Task TheMessageIsDisplayed(string message)
        {
            Assert.AreEqual(message, await _loginPage.GetLoginErrorMsg());
        }
    }
}
