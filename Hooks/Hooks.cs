using Assignment4.Pages;
using BoDi;
using Microsoft.Playwright;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Assignment4.Hooks
{
    [Binding]
    public sealed class Hooks
    {

        [BeforeScenario]
        public static async Task BeforeScenario(IObjectContainer container)
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions() { Headless = false, SlowMo = 50 });
            var browserContext = await browser.NewContextAsync();
            var page = await browserContext.NewPageAsync();
            container.RegisterInstanceAs(playwright);
            container.RegisterInstanceAs(browser);
            container.RegisterInstanceAs(page);
        }

        [AfterScenario]
        public async Task AfterScenario(IObjectContainer container)
        {
            await container.Resolve<IBrowser>().CloseAsync();
            container.Resolve<IPlaywright>().Dispose();
        }
    }
}
