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
	public class AP_Signin_Tests_SadPaths
	{

		public AP_Website<ChromeDriver> AP_Website = new AP_Website<ChromeDriver>();

		[Test]
		public void GivenIAmInTheHomePage_WhenISignInWithInvalidCredentials_Epicsadface_ErrorIsDisplayed()
		{
			AP_Website.AP_HomePage.VisitHomePage();
			AP_Website.AP_HomePage.InputUserName("standard_user");
			AP_Website.AP_HomePage.InputPassword("Plankton");
			AP_Website.AP_HomePage.ClickLoginButton();

			Assert.That(AP_Website.AP_HomePage.GetErrorMessage(),Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
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