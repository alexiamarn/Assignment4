using System;
using TechTalk.SpecFlow;
using Microsoft.Playwright;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment4.Pages;
using TechTalk.SpecFlow.Assist;
using Assignment4.Steps;
using System.Collections.Generic;

namespace Assignment4.Features
{
    [Binding]
    public class RegisterSteps
    {
        private readonly RegisterPage _registerPage;
        private readonly ScenarioContext _scenarioContext;

        private string successfullRegistrationMsg = "Your account was created successfully. You are now logged in.";
        private string welcomeMsg = "Welcome ";

        public RegisterSteps(RegisterPage registerPage, ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;            
            _registerPage = registerPage;
        }

        [Given(@"user navigates to registration page")]
        [When(@"user navigates to registration page")]
        public async Task GivenUserNavigatesToHomepageAsync()
        {
            await _registerPage.navigateToRegistrationPage();
        }

        [Given(@"user registers with details")]
        [When(@"user registers with details")]        
        public async Task WhenUserRegistersWithDetailsAsync(Table table)
        {
            var registrationDetails = table.CreateInstance<RegistrationDetailsTableType>();
            await _registerPage.SetRegistrationDetails(registrationDetails);
        }

        [Then(@"the registration gets completed and user with username (.*) gets welcomed")]
        public async Task TheRegistrationGetsCompleted(string username)
        {
            Assert.AreEqual(welcomeMsg + (string)_scenarioContext[username], await _registerPage.GetWelcomeMsg());
            Assert.AreEqual(successfullRegistrationMsg, await _registerPage.GetSuccessfullRegistrationMsg());
        }

        [Then(@"the user gets informed that fields (.*) are required")]
        public async Task ThenTheUserGetsInformedThatFieldsAreRequiredAsync(string fields)
        {
            var expectedErrors = new List<string>();
            string[] fieldsList = fields.Split(",");
            foreach (string field in fieldsList)
            {
                expectedErrors.Add($"{field} is required.");
            }
            var actualErrors = await _registerPage.GetRegisterErrorMsgs();
            Assert.AreEqual(actualErrors, expectedErrors);
        }

        [Then(@"the error message (.*) is displayed")]
        public async void ThenTheErrorMessageIsDisplayed(string msg)
        {
            Assert.AreEqual(await _registerPage.GetUsernameRegisterErrorMsg(), msg);
        }
    }
}
