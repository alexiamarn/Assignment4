using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Pages
{
    public class LoginPage
    {
        private IPage _page;
        public LoginPage(IPage page)
        {
            _page = page;
        }
        public ILocator UsernameField => _page.Locator("[name='username']");
        public ILocator PasswordField => _page.Locator("[name='password']");
        public ILocator SubmitBtn => _page.Locator("input[type=submit]");
        public ILocator SuccessfullLoginMsg => _page.Locator("#leftPanel .smallText");
        public ILocator InvalidLoginErrorMsg => _page.Locator("#rightPanel .error");

        public string loginUrl => "http://parabank.parasoft.com/parabank/index.htm";

        public async Task navigateToLoginPage()
        {
            await _page.GotoAsync(loginUrl);
        }

        public async Task SetCredentials(string username, string pwd)
        {
            await UsernameField.FillAsync(username);
            await PasswordField.FillAsync(pwd);
        }

        public async Task SubmitLogin()
        {
            await SubmitBtn.ClickAsync();
        }

        public async Task<string?> GetWelcomeMsg()
        {
            return await SuccessfullLoginMsg.TextContentAsync();
        }

        public async Task<string?> GetLoginErrorMsg()
        {
            return await InvalidLoginErrorMsg.TextContentAsync();
        }
    }
}

