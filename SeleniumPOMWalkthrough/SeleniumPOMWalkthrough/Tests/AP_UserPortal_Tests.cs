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
	class AP_UserPortal_Tests
	{
		public AP_Website<ChromeDriver> AP_Website = new AP_Website<ChromeDriver>();
		
		[Test]
		public void WhenImOnTheInventoryPage_WhenIClickTheBasket_ThenIShouldBeAbleToViewMyCart()
		{
			AP_Website.AP_HomePage.VisitHomePage();
			AP_Website.AP_HomePage.InputUserName("standard_user");
			AP_Website.AP_HomePage.InputPassword("secret_sauce");
			AP_Website.AP_HomePage.ClickLoginButton();
			AP_Website.AP_UserPage.ClickShoppingCartButton();
			var result = AP_Website.AP_UserPage.GetHeaderText();
			Assert.That(result, Does.Contain("YOUR CART"));
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
