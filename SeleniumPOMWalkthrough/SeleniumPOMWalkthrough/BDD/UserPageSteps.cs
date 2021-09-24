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
    [Scope(Feature = "UserPage")]
    public class UserPageSteps :sharedSteps
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

        [When(@"I click the ADD TO CART button on an item")]
        public void WhenIClickTheADDTOCARTButtonOnAnItem()
        {
            AP_Website.AP_UserPage.GetShoppingCartNumber();
            AP_Website.AP_UserPage.BikeLightAddToCartButtonClick();
        }
        
        [Then(@"shopping cart should increase by one")]
        public void ThenShoppingCartShouldIncreaseByOne()
        {
            Assert.IsTrue(AP_Website.AP_UserPage.HasSHoppingCartIncreased());
        }

        [When(@"I click the REMOVE button on an item")]
        public void WhenIClickTheREMOVEButtonOnAnItem()
        {
            AP_Website.AP_UserPage.GetShoppingCartNumber();
            AP_Website.AP_UserPage.BikeLightRemoveButtonClick();
        }

        [Then(@"shopping cart should decrease by one")]
        public void ThenShoppingCartShouldDecreaseByOne()
        {
            Assert.IsTrue(AP_Website.AP_UserPage.HasSHoppingCartDecreased());
        }


        #region sorting
        [When(@"i click the sorting button")]
        public void WhenIClickTheSortingButton()
        {
            AP_Website.AP_UserPage.ClickSortBy();
        }

        [When(@"I click Name Z to A")]
        public void WhenIClickNameZToA()
        {
            AP_Website.AP_UserPage.NameZToASortClick();
            AP_Website.AP_UserPage.GetSortedByOption();
        }

        [Then(@"The List is sorted Alphabetically and Reversed")]
        public void ThenTheListIsSortedAlphabeticallyAndReversed()
        {
            AP_Website.AP_UserPage.GetSortedByOption();
            Assert.That(AP_Website.AP_UserPage.sortedBy.ToLower() == "name (z to a)");
        }

        #endregion
    }
}
