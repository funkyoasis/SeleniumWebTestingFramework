using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace SeleniumPOMWalkthrough.lib.pages
{
	public class CompleteCheckoutPage
	{
		private IWebDriver _seleniumDriver;
		private string _completeCheckoutPageUrl = AppConfigReader.CompleteCheckoutPage_Url;
		public CompleteCheckoutPage(IWebDriver seleniumDriver)
		{
			_seleniumDriver = seleniumDriver;
		}
	}
}
