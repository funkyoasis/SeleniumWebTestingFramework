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
    [Scope(Feature ="Cart")]
    public class CartSteps :CartSharedSteps
    {
        private Credentials credentials;

        [When(@"I Click the Red Checkout button")]
        public void WhenIClickTheRedCheckoutButton()
        {
            AP_Website.CartPage.ClickRedCheckoutButton();
        }

        [Then(@"I am taken to the Checkout page")]
        public void ThenIAmTakenToTheCheckoutPage()
        {
            Assert.That(AP_Website.SeleniumDriver.Url.Contains("checkout"));
        }

    }
}
