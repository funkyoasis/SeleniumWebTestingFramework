using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumPOMWalkthrough.lib.pages
{
	public class AP_Item0Page
	{
		private IWebDriver _seleniumDriver;
		private string _item0PageUrl = AppConfigReader.Item0PageUrl;

		public int shoppingCartNumber { get; set; }
		public AP_Item0Page(IWebDriver seleniumDriver)
		{
			_seleniumDriver = seleniumDriver;
		}

		private IWebElement _inventoryDetailName => _seleniumDriver.FindElement(By.ClassName("inventory_details_name large_size"));
		private IWebElement _inventoryDetailsContainer => _seleniumDriver.FindElement(By.ClassName("inventory_details_desc large_size"));

		private IWebElement _addToCartButton => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));

		private IWebElement _removeButton => _seleniumDriver.FindElement(By.Id("remove-sauce-labs-bike-light"));

		private IWebElement _shoppingCartBadge => _seleniumDriver.FindElement(By.ClassName("shopping_cart_badge"));

		private IWebElement _Itemimage => _seleniumDriver.FindElement(By.CssSelector("[alt=\"Sauce Labs Bike Light\"]"));
		public void GoToItem0Page() => _seleniumDriver.Navigate().GoToUrl(_item0PageUrl);

		public string GetInventoryDetailNameText()
		{
			return _inventoryDetailName.Text;
		}

		public string GetInventoryDetailsText()
		{
			return _inventoryDetailsContainer.Text;
		}
		public void removeButtonClick() => _removeButton.Click();
		public void AddToCartButtonClick() => _addToCartButton.Click();

		public bool IsImageDisplayed()
		{
			return _Itemimage.Displayed;
		}
		public int GetShoppingCartBadgeText()
		{
			try
			{
				return shoppingCartNumber = Convert.ToInt32(_shoppingCartBadge.Text);
			}
			catch (NoSuchElementException)
			{
				return shoppingCartNumber = 0;
			}
		}

		public bool HasSHoppingCartIncreased()
		{
			int count_before = shoppingCartNumber;
			int count_after = Convert.ToInt32(GetShoppingCartBadgeText());
			if (count_after > count_before)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool HasSHoppingCartDecreased()
		{
			int count_before = shoppingCartNumber;
			int count_after = Convert.ToInt32(GetShoppingCartBadgeText());
			if (count_after < count_before)
			{
				return true;
			}
			else
			{
				return false;
			}
		}







	}
		
	
}
