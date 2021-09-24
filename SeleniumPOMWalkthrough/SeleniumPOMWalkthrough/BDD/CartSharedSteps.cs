using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib.pages;
using TechTalk.SpecFlow.Assist;
using SeleniumPOMWalkthrough.Utils;


namespace SeleniumPOMWalkthrough.BDD
{
	public class CartSharedSteps :sharedSteps
	{

        [Given(@"I am On the UserPage")]
        public void GivenIAmOnTheUserPage()
        {
            base.GivenIAmOnTheHomepage();
            base.GivenIHaveEnteredThePassword("secret_sauce");
            base.GivenIHaveEnteredTheUsername("standard_user");
            base.WhenIClickTheLogInButton();
            base.IAmOnTheUserPage();

        }

        [Given(@"I Have Items in my Cart")]
        public void GivenIHaveItemsInMyCart()
        {
            AP_Website.AP_UserPage.BackpackAddToCartButtonClick();
            AP_Website.AP_UserPage.BikeLightAddToCartButtonClick();
            AP_Website.AP_UserPage.BoltTeeAddToCartButtonClick();
        }

        [When(@"I Click the checkout button")]
        public void WhenIClickTheCheckoutButton()
        {
            AP_Website.AP_UserPage.ClickShoppingCartButton();
        }

        [Then(@"I am taken to the cart page")]
        public void ThenIAmTakenToTheCartPage()
        {
            Assert.That(AP_Website.SeleniumDriver.Url.Contains("cart"));
        }

    }
}
