using Assignment4.Steps;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Assignment4.Pages
{
    public class RegisterPage
    {
        private IPage _page;
        private readonly ScenarioContext _scenarioContext;
        public RegisterPage(IPage page, ScenarioContext scenarioContext)
        {
            _page = page;
            _scenarioContext = scenarioContext;
        }

        public string RegisterInputField(string fieldName) => $"input[id='{fieldName}']";
        public ILocator SubmitBtn => _page.Locator("input[value=Register]");
        public ILocator SuccessfullRegistrationMsg => _page.Locator("#rightPanel p");
        public ILocator WelcomeMsg => _page.Locator("#rightPanel .title");
        public string RegisterErrorMsgs => "#customerForm .error";
        public ILocator UsernameFieldErrorMsg => _page.Locator("span[id='customer.username.errors']");

        public string registerUrl => "http://parabank.parasoft.com/parabank/register.htm";

        public async Task navigateToRegistrationPage()
        {
            await _page.GotoAsync(registerUrl);
        }

        public async Task SetRegistrationDetails(RegistrationDetailsTableType details)
        {
            await _page.FillAsync(RegisterInputField("customer.firstName"), details.FirstName);
            await _page.FillAsync(RegisterInputField("customer.lastName"), details.LastName);
            await _page.FillAsync(RegisterInputField("customer.address.street"), details.Address);
            await _page.FillAsync(RegisterInputField("customer.address.city"), details.City);
            await _page.FillAsync(RegisterInputField("customer.address.state"), details.State);
            await _page.FillAsync(RegisterInputField("customer.address.zipCode"), details.ZipCode);
            await _page.FillAsync(RegisterInputField("customer.phoneNumber"), details.Phone);
            await _page.FillAsync(RegisterInputField("customer.ssn"), details.Ssn);
            string randomUsername = string.Empty;
            if (details.Username != string.Empty)
            {
                           
                if (_scenarioContext.ContainsKey(details.Username))
                    randomUsername = (string)_scenarioContext[details.Username];
                else
                {
                    Random rnd = new Random();
                    int num = rnd.Next();
                    randomUsername = details.Username + num.ToString();
                    _scenarioContext.Add(details.Username, randomUsername);
                }                   
            }
            
            await _page.FillAsync(RegisterInputField("customer.username"), randomUsername);
            
            await _page.FillAsync(RegisterInputField("customer.password"), details.Password);
            await _page.FillAsync(RegisterInputField("repeatedPassword"), details.Password);
            await SubmitBtn.ClickAsync();
        }

        public async Task<string?> GetWelcomeMsg()
        {
            return await WelcomeMsg.TextContentAsync();
        }

        public async Task<string?> GetSuccessfullRegistrationMsg()
        {
            return await SuccessfullRegistrationMsg.TextContentAsync();
        }

        public async Task<IReadOnlyList<string>> GetRegisterErrorMsgs()
        {
            await _page.WaitForSelectorAsync(RegisterErrorMsgs);
            var errors = _page.Locator(RegisterErrorMsgs);
            return await errors.AllTextContentsAsync();
        }
        public async Task<string?> GetUsernameRegisterErrorMsg()
        {
            return await UsernameFieldErrorMsg.TextContentAsync();
        }
    }
}
