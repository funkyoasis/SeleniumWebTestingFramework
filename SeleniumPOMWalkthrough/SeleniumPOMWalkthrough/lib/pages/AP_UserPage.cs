using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumPOMWalkthrough.lib.pages
{
	public class AP_UserPage
	{
		private IWebDriver _seleniumDriver;
		public AP_UserPage(IWebDriver seleniumDriver)
		{
			_seleniumDriver = seleniumDriver;
		}
		private string _userPageUrl = AppConfigReader.UserPageUrl;

		private string _cartPageUrl = AppConfigReader.CartPage_Url;
		public int shoppingCartNumber { get; set; }

		public string sortedBy { get; set; }
		private IWebElement _shoppingCartButton => _seleniumDriver.FindElement(By.ClassName("shopping_cart_link"));
		private IWebElement _header => _seleniumDriver.FindElement(By.Id("header_container"));
		#region Item List Sorting
		private IWebElement _sortingSelectContainer => _seleniumDriver.FindElement(By.ClassName("select_container"));
		private IWebElement _activeselection => _sortingSelectContainer.FindElement(By.ClassName("active_option"));

		private IWebElement _sortingOptions => _sortingSelectContainer.FindElement(By.ClassName("product_sort_container"));
		private IWebElement _inventoryList => _seleniumDriver.FindElement(By.ClassName("inventory_list"));
		public string GetSortedByOption()
		{
			return sortedBy = _activeselection.Text;
		}

		public void ClickSortBy()
		{
			_sortingOptions.Click();
		}

		public List<string> GetInventoryListOrder()
		{
			List<string> listorder = new List<string> { };
			foreach (IWebElement element in _inventoryList.FindElements(By.ClassName("inventory_item")))
			{
				listorder.Add(element.Text);
			}
			return listorder;
		}

		public void NameZToASortClick()
		{
			//_sortingOptions.FindElement(By.CssSelector("option.az")).Click();
			_sortingOptions.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/div[2]/span/select/option[2]")).Click();
		}
		#endregion

		#region shopping items

		private IWebElement _bikeLightAddToCartButton => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));

		private IWebElement _shoppingCartNumber => _seleniumDriver.FindElement(By.ClassName("shopping_cart_badge"));
		private IWebElement _bikeLightremoveButton => _seleniumDriver.FindElement(By.Id("remove-sauce-labs-bike-light"));
		private IWebElement _Item0PageLink => _seleniumDriver.FindElement(By.Id("item_0_title_link"));

		private IWebElement _backpackAddToCartButton => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
		private IWebElement _backpackRemoveButton => _seleniumDriver.FindElement(By.Id("remove-sauce-labs-backpack"));

		private IWebElement _boltTeeAddToCartButton => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
		private IWebElement _boltTeeRemoveButton => _seleniumDriver.FindElement(By.Id("remove-sauce-labs-bolt-t-shirt"));

		//methods
		public void BikeLightAddToCartButtonClick() => _bikeLightAddToCartButton.Click();
		public void BikeLightRemoveButtonClick() => _bikeLightremoveButton.Click();
		public void ClickItem0Link() => _Item0PageLink.Click();
		public void BackpackAddToCartButtonClick() => _backpackAddToCartButton.Click();
		public void BackpackRemoveButtonClick() => _backpackRemoveButton.Click();
		public void BoltTeeAddToCartButtonClick() => _boltTeeAddToCartButton.Click();
		public void BoltTeeRemoveButtonClick() => _boltTeeRemoveButton.Click();



		#endregion
		public int GetShoppingCartNumber()
		{
			try
			{
				return shoppingCartNumber = Convert.ToInt32(_shoppingCartNumber.Text);
			}
			catch (NoSuchElementException)
			{
				return shoppingCartNumber = 0;
			}
		}

		public bool HasSHoppingCartIncreased()
		{
			int countBefore = shoppingCartNumber;
			int countAfter = Convert.ToInt32(GetShoppingCartNumber());
			return countAfter > countBefore;
			
		}

		public bool HasSHoppingCartDecreased()
		{
			int countBefore = shoppingCartNumber;
			int countAfter = Convert.ToInt32(GetShoppingCartNumber());
			return countBefore > countAfter;
		}
		public void GoToUserPage() => _seleniumDriver.Navigate().GoToUrl(_userPageUrl);

		public void ClickShoppingCartButton() => _shoppingCartButton.Click();
		public string GetHeaderText() => _header.Text;

	
	}
}
