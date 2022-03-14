﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Assignment4.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("User Registration")]
    public partial class UserRegistrationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Register.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "User Registration", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Succesfull Registration")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.TestCaseAttribute("Test", "Tester", "TestAdress", "TestCity", "TestState", "1234", "12345", "123456", "tst", "tst123", null)]
        [NUnit.Framework.TestCaseAttribute("Test", "Tester", "TestAdress", "TestCity", "TestState", "1234", "", "123456", "tst", "tst123", null)]
        public void SuccesfullRegistration(string firstname, string lastname, string address, string city, string state, string zipCode, string phone, string ssn, string username, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "smoke"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("firstname", firstname);
            argumentsOfScenario.Add("lastname", lastname);
            argumentsOfScenario.Add("address", address);
            argumentsOfScenario.Add("city", city);
            argumentsOfScenario.Add("state", state);
            argumentsOfScenario.Add("zipCode", zipCode);
            argumentsOfScenario.Add("phone", phone);
            argumentsOfScenario.Add("ssn", ssn);
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Succesfull Registration", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 testRunner.Given("user navigates to registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "First Name",
                            "Last Name",
                            "Address",
                            "City",
                            "State",
                            "Zip Code",
                            "Phone #",
                            "SSN",
                            "Username",
                            "Password"});
                table1.AddRow(new string[] {
                            string.Format("{0}", firstname),
                            string.Format("{0}", lastname),
                            string.Format("{0}", address),
                            string.Format("{0}", city),
                            string.Format("{0}", state),
                            string.Format("{0}", zipCode),
                            string.Format("{0}", phone),
                            string.Format("{0}", ssn),
                            string.Format("{0}", username),
                            string.Format("{0}", password)});
#line 6
 testRunner.When("user registers with details", ((string)(null)), table1, "When ");
#line hidden
#line 9
 testRunner.Then("the registration gets completed and user with username tst gets welcomed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User cannot register when required fields are not set")]
        [NUnit.Framework.TestCaseAttribute("", "", "", "", "", "", "", "", "", "", "First name,Last name,Address,City,State,Zip Code,Social Security Number,Username," +
            "Password,Password confirmation", null)]
        [NUnit.Framework.TestCaseAttribute("", "", "", "", "", "", "1234", "", "", "", "First name,Last name,Address,City,State,Zip Code,Social Security Number,Username," +
            "Password,Password confirmation", null)]
        [NUnit.Framework.TestCaseAttribute("Test", "", "", "", "", "", "", "", "", "", "Last name,Address,City,State,Zip Code,Social Security Number,Username,Password,Pa" +
            "ssword confirmation", null)]
        [NUnit.Framework.TestCaseAttribute("Test", "Tester", "", "", "", "", "", "", "", "", "Address,City,State,Zip Code,Social Security Number,Username,Password,Password con" +
            "firmation", null)]
        [NUnit.Framework.TestCaseAttribute("Test", "Tester", "TestAdress", "", "", "", "", "", "", "", "City,State,Zip Code,Social Security Number,Username,Password,Password confirmatio" +
            "n", null)]
        public void UserCannotRegisterWhenRequiredFieldsAreNotSet(string firstname, string lastname, string address, string city, string state, string zipCode, string phone, string ssn, string username, string password, string errorFields, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("firstname", firstname);
            argumentsOfScenario.Add("lastname", lastname);
            argumentsOfScenario.Add("address", address);
            argumentsOfScenario.Add("city", city);
            argumentsOfScenario.Add("state", state);
            argumentsOfScenario.Add("zipCode", zipCode);
            argumentsOfScenario.Add("phone", phone);
            argumentsOfScenario.Add("ssn", ssn);
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            argumentsOfScenario.Add("errorFields", errorFields);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User cannot register when required fields are not set", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 16
 testRunner.Given("user navigates to registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "First Name",
                            "Last Name",
                            "Address",
                            "City",
                            "State",
                            "Zip Code",
                            "Phone #",
                            "SSN",
                            "Username",
                            "Password"});
                table2.AddRow(new string[] {
                            string.Format("{0}", firstname),
                            string.Format("{0}", lastname),
                            string.Format("{0}", address),
                            string.Format("{0}", city),
                            string.Format("{0}", state),
                            string.Format("{0}", zipCode),
                            string.Format("{0}", phone),
                            string.Format("{0}", ssn),
                            string.Format("{0}", username),
                            string.Format("{0}", password)});
#line 17
 testRunner.When("user registers with details", ((string)(null)), table2, "When ");
#line hidden
#line 20
 testRunner.Then(string.Format("the user gets informed that fields {0} are required", errorFields), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User with existing username cannot register")]
        public void UserWithExistingUsernameCannotRegister()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User with existing username cannot register", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 29
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 30
 testRunner.Given("user navigates to registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "First Name",
                            "Last Name",
                            "Address",
                            "City",
                            "State",
                            "Zip Code",
                            "Phone #",
                            "SSN",
                            "Username",
                            "Password"});
                table3.AddRow(new string[] {
                            "Test",
                            "Tester",
                            "TestAdress",
                            "TestCity",
                            "TestState",
                            "1234",
                            "12345",
                            "123456",
                            "tst",
                            "tst123"});
#line 31
 testRunner.And("user registers with details", ((string)(null)), table3, "And ");
#line hidden
#line 34
 testRunner.When("user navigates to registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "First Name",
                            "Last Name",
                            "Address",
                            "City",
                            "State",
                            "Zip Code",
                            "Phone #",
                            "SSN",
                            "Username",
                            "Password"});
                table4.AddRow(new string[] {
                            "Test",
                            "Tester",
                            "TestAdress",
                            "TestCity",
                            "TestState",
                            "1234",
                            "12345",
                            "123456",
                            "tst",
                            "tst123"});
#line 35
 testRunner.And("user registers with details", ((string)(null)), table4, "And ");
#line hidden
#line 38
 testRunner.Then("the error message This username already exists. is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
