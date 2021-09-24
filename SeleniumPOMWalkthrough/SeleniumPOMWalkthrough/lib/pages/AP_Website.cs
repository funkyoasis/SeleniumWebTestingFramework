using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumPOMWalkthrough.lib.driver_config;

namespace SeleniumPOMWalkthrough.lib.pages
{
	public class AP_Website<T> where T:IWebDriver, new()
	{
		public IWebDriver SeleniumDriver { get; set; }
		public AP_HomePage AP_HomePage { get; set; }
		public AP_UserPage AP_UserPage { get; set; }
		public AP_Item0Page AP_Item0Page { get; set; }
		public CartPage CartPage { get; set; }
		public CheckoutPage CheckoutPage { get; set; }
		public CompleteCheckoutPage CompleteCheckoutPage { get; set; }
		public ConfirmOrderPage ConfirmOrderPage { get; set; }
		public AP_Website(int pageLoadInSecs = 10, int implicitWaitInSec = 10)
		{
			SeleniumDriver = new SeleniumDriverConfig<T>(pageLoadInSecs, implicitWaitInSec).Driver;

			AP_HomePage = new AP_HomePage(SeleniumDriver);
			AP_UserPage = new AP_UserPage(SeleniumDriver);
			AP_Item0Page = new AP_Item0Page(SeleniumDriver);
			CartPage = new CartPage(SeleniumDriver);
			CheckoutPage = new CheckoutPage(SeleniumDriver);
			CompleteCheckoutPage = new CompleteCheckoutPage(SeleniumDriver);
			ConfirmOrderPage = new ConfirmOrderPage(SeleniumDriver);

		}

		//delete cookies
		public void  DeleteCookies()=>SeleniumDriver.Manage().Cookies.DeleteAllCookies();

	}
}
