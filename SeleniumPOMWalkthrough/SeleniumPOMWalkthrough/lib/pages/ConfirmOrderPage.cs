using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace SeleniumPOMWalkthrough.lib.pages
{
	public class ConfirmOrderPage
	{
		private IWebDriver _seleniumDriver;
		private string _confrimOrderUrl = AppConfigReader.ConfirmOrderPage_Url;
		public ConfirmOrderPage(IWebDriver seleniumDriver)
		{
			_seleniumDriver = seleniumDriver;
		}
	}
}
