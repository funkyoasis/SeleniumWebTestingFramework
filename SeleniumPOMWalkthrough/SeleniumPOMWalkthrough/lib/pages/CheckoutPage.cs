using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace SeleniumPOMWalkthrough.lib.pages
{
	public class CheckoutPage
	{
		private IWebDriver _seleniumDriver;
		private string _checkoutPageUrl = AppConfigReader.CheckoutPage_Url;
		public CheckoutPage(IWebDriver seleniumDriver)
		{
			_seleniumDriver = seleniumDriver;
		}
	}
}
