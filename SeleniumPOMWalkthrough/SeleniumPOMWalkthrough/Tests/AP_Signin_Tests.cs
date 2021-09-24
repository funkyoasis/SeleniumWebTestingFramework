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
	public class AP_Signin_Tests
	{

		public AP_Website<ChromeDriver> AP_Website = new AP_Website<ChromeDriver>();

		[Test]
		public void GivenIAmInTheHomePage_WhenISignInWithValidCredentials_Then_IShould_()
		{
			AP_Website.AP_HomePage.VisitHomePage();
			AP_Website.AP_HomePage.InputUserName("standard_user");
			AP_Website.AP_HomePage.InputPassword("secret_sauce");
			AP_Website.AP_HomePage.ClickLoginButton();

			Assert.That(AP_Website.SeleniumDriver.Url.Contains("inventory"));
			//Assert.That(AP_Website.SeleniumDriver.Title, Does.Contain("Login - My Store"));
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
