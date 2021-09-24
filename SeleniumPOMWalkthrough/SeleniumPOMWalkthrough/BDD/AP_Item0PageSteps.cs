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
    [Scope(Feature ="AP_Item0Page")]
    public class AP_Item0PageSteps : sharedSteps
    {
        private Credentials _credentials;

        [When(@"I click Item_zero link")]
        public void WhenIClickItem_ZeroLink()
        {
            AP_Website.AP_UserPage.ClickItem0Link();
        }

        [Then(@"I should be in Item_zero Page")]
        public void ThenIShouldBeInItem_ZeroPage()
        {
            Assert.That(AP_Website.SeleniumDriver.Url.Contains("item.html?id=0"));
        }

        [When(@"I click the add to cart button")]
        public void WhenIClickTheAddToCartButton()
        {
            AP_Website.AP_Item0Page.GetShoppingCartBadgeText();
            AP_Website.AP_Item0Page.AddToCartButtonClick();
        }

        [Then(@"shopping cart should increase by one\.")]
        public void ThenShoppingCartShouldIncreaseByOne_()
        {
            Assert.That(AP_Website.AP_Item0Page.HasSHoppingCartIncreased(), Is.EqualTo(true));
        }
        
        [Then(@"The Item Image is displayed")]
        public void ThenTheItemImageIsDisplayed()
        {
            Assert.That(AP_Website.AP_Item0Page.IsImageDisplayed(), Is.EqualTo(true));
        }


        [When(@"I click the remove button")]
        public void WhenIClickTheRemoveButton()
        {
            AP_Website.AP_Item0Page.removeButtonClick();
        }

        [Then(@"shopping cart should decrease by one\.")]
        public void ThenShoppingCartShouldDecreaseByOne_()
        {
            Assert.That(AP_Website.AP_Item0Page.HasSHoppingCartDecreased(), Is.EqualTo(true));
        }


    }
}
