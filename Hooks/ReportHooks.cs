using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace Assignment4.Hooks
{
    [Binding]
    public sealed class ReportHooks
    {
        private static ScenarioContext _scenarioContext;
        private static ExtentTest _feature;
        private static ExtentTest _scenario;
        private static ExtentReports _extentReports;
        private static ExtentHtmlReporter _extentHtmlReporter;

        [BeforeTestRun]
        public static void InitializeReport()
        {
            _extentHtmlReporter = new ExtentHtmlReporter(@"C:\TestReport\testreport.html");
            //_extentHtmlReporter.Config.ReportName = "testreport.html";
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(_extentHtmlReporter);
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featurecontext)
        {
            if (featurecontext != null)
                _feature = _extentReports.CreateTest<Feature>(featurecontext.FeatureInfo.Title, featurecontext.FeatureInfo.Description);
        }

        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {
            if (scenarioContext != null)
            {
                _scenarioContext = scenarioContext;
                _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title, scenarioContext.ScenarioInfo.Description);
            }
        }

        [AfterStep]
        public void AfterEachStep()
        {
            ScenarioBlock scenarioBlock = _scenarioContext.CurrentScenarioBlock;
            switch (scenarioBlock)
            {
                case ScenarioBlock.Given:
                    if (_scenarioContext.TestError != null)
                        _scenario.CreateNode<Given>(_scenarioContext.TestError.Message).Fail("\n" + _scenarioContext.TestError.StackTrace);                      
                    else
                        _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Pass("");
                    break;
                case ScenarioBlock.When:
                    if (_scenarioContext.TestError != null)
                        _scenario.CreateNode<When>(_scenarioContext.TestError.Message).Fail("\n" + _scenarioContext.TestError.StackTrace);
                    else
                        _scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Pass("");
                    break;
                case ScenarioBlock.Then:
                    if (_scenarioContext.TestError != null)
                        _scenario.CreateNode<Then>(_scenarioContext.TestError.Message).Fail("\n" + _scenarioContext.TestError.StackTrace);
                    else
                        _scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Pass("");
                    break;
                default:
                    if (_scenarioContext.TestError != null)
                        _scenario.CreateNode<And>(_scenarioContext.TestError.Message).Fail("\n" + _scenarioContext.TestError.StackTrace);
                    else
                        _scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text).Pass("");
                    break;
            }
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            _extentReports.Flush();
        }
    }
}
