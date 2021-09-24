using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumPOMWalkthrough.lib.pages
{
	public class AP_HomePage
	{
		#region Properties
		private IWebDriver _seleniumDriver;

		private string _homePageUrl = AppConfigReader.BaseUrl;

		private IWebElement _loginButton => _seleniumDriver.FindElement(By.Id("login-button"));

		private IWebElement _passwordField => _seleniumDriver.FindElement(By.Id("password"));

		private IWebElement _usernameField => _seleniumDriver.FindElement(By.Id("user-name"));

		private IWebElement _errorMessage => _seleniumDriver.FindElement(By.CssSelector("*[data-test=\"error\"]"));

		//private  IWebElement _errorMessage => _seleniumDriver.FindElement(By.CssSelector(""))
		#endregion

		//constructor that sets the driver to be the driver from the config
		public AP_HomePage(IWebDriver seleniumDriver)
		{
			_seleniumDriver = seleniumDriver;
		}

		//Methods to interact with the web element
		public void VisitHomePage() => _seleniumDriver.Navigate().GoToUrl(_homePageUrl);

		public void ClickLoginButton() => _loginButton.Click();

		public void InputUserName(string username) => _usernameField.SendKeys(username);

		public void InputPassword(string password) => _passwordField.SendKeys(password);

		public string GetErrorMessage()
		{
			return _errorMessage.Text;
		}
		
	}
}
