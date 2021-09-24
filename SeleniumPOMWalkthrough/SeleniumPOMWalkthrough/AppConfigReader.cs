using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough
{
	class AppConfigReader
	{
		public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
		public static readonly string UserPageUrl = ConfigurationManager.AppSettings["userpage_url"];
		public static readonly string Item0PageUrl = ConfigurationManager.AppSettings["item0page_url"];
		public static readonly string CartPage_Url = ConfigurationManager.AppSettings["cartpage_url"];
		public static readonly string CheckoutPage_Url = ConfigurationManager.AppSettings["checkoutpage_url"];
		public static readonly string ConfirmOrderPage_Url = ConfigurationManager.AppSettings["confirmorderpage_url"];
		public static readonly string CompleteCheckoutPage_Url = ConfigurationManager.AppSettings["completecheckoutpage_url"];
	}
}
