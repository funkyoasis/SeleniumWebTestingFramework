using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumPOMWalkthrough.lib.pages;
using NUnit.Framework;

namespace SeleniumPOMWalkthrough.Tests
{
	public class Item0Page_Tests
	{
		public AP_Website<ChromeDriver> AP_Website = new AP_Website<ChromeDriver>();

		[Test]
		public void WhenIAmOnTheItemPage_WhenIClick_AddToCartCart_NumberIsIncreased()
		{
			AP_Website.AP_HomePage.VisitHomePage();
			AP_Website.AP_HomePage.InputUserName("standard_user");
			AP_Website.AP_HomePage.InputPassword("secret_sauce");
			AP_Website.AP_HomePage.ClickLoginButton();
			AP_Website.AP_UserPage.ClickItem0Link();
			AP_Website.AP_Item0Page.AddToCartButtonClick();
			var result = AP_Website.AP_Item0Page.GetShoppingCartBadgeText();
			Assert.That(result, Is.EqualTo(1));
		}


		[OneTimeTearDown]
		public void CleanUp()
		{
			//Quits the driver and closes every associated window
			AP_Website.SeleniumDriver.Quit();

			AP_Website.SeleniumDriver.Dispose();
		}


	}
}
