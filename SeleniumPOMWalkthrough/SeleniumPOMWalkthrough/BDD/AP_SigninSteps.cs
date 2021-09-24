using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib.pages;
using TechTalk.SpecFlow.Assist;
using SeleniumPOMWalkthrough.Utils;

namespace SeleniumPOMWalkthrough.BDD
{
    [Binding]
    [Scope(Feature = "AP_Signin")]
    public class AP_SigninSteps : sharedSteps
    {
        private Credentials _credentials;
        
        [Then(@"I should See a ""(.*)"" error")]
        public void ThenIShouldSeeAError(string error)
        {
            Assert.That(AP_Website.AP_HomePage.GetErrorMessage(), Does.Contain(error));
        }
        
        



    }
}
