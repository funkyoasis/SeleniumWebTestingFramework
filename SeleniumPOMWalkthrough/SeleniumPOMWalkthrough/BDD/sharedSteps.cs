using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib.pages;
using TechTalk.SpecFlow.Assist;
using SeleniumPOMWalkthrough.Utils;

[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(10)]

namespace SeleniumPOMWalkthrough.BDD
{
	public class sharedSteps
	{
        private Credentials _credentials;
        public AP_Website<ChromeDriver> AP_Website { get; } = new AP_Website<ChromeDriver>();


        [Given(@"I am on the Homepage")]
        public void GivenIAmOnTheHomepage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
        }

        [Given(@"I have entered the username ""(.*)""")]
        public void GivenIHaveEnteredTheUsername(string username)
        {
            AP_Website.AP_HomePage.InputUserName(username);
        }

        [Given(@"I have entered the password ""(.*)""")]
        public void GivenIHaveEnteredThePassword(string password)
        {
            AP_Website.AP_HomePage.InputPassword(password);
        }

        [When(@"I click the log in button")]
        public void WhenIClickTheLogInButton()
        {
            AP_Website.AP_HomePage.ClickLoginButton();
        }
        
        [Given(@"I have the given credentials")]
        public void GivenIHaveEnteredTheGivenCredentials(Table credentials)
        {
            _credentials = new Credentials();
            _credentials.Username = Convert.ToString(credentials.Rows[0][0]);
            _credentials.Password = Convert.ToString(credentials.Rows[0][1]);
        }

        [When(@"I enter these credentials")]
        public void WhenIEnterTheseCredentials()
        {
            AP_Website.AP_HomePage.InputPassword(_credentials.Password);
            AP_Website.AP_HomePage.InputUserName(_credentials.Username);
        }


        [Then(@"I am On the UserPage")]
        public void IAmOnTheUserPage()
        {
            Assert.That(AP_Website.SeleniumDriver.Url.Contains("inventory"));
        }

        [AfterScenario]
		public void DisposeWebDriver()
		{
			AP_Website.SeleniumDriver.Dispose();
		}
	


	}

	
}
