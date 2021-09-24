using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumPOMWalkthrough.lib.pages
{
	public class CartPage
	{

		private IWebDriver _seleniumDriver;
		private string _cartPageUrl = AppConfigReader.CartPage_Url;
		private string _checkoutPageUrl = AppConfigReader.CheckoutPage_Url;
		public CartPage(IWebDriver seleniumDriver)
		{
			_seleniumDriver = seleniumDriver;
		}

		private IWebElement _redCheckoutButton => _seleniumDriver.FindElement(By.Id("checkout"));

		public void ClickRedCheckoutButton()
		{
			_redCheckoutButton.Click();
		}

	}

}
