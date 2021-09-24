Feature:Cart
	Simple calculator for adding two numbers

@mCart
Scenario: Go to cart page 
	Given I am On the UserPage
	And I Have Items in my Cart
	When I Click the checkout button
	Then I am taken to the cart page

@mCart
Scenario: Go to Checkout Page 
	Given I am On the UserPage
	And I Have Items in my Cart
	When I Click the checkout button
	Then I am taken to the cart page
	When I Click the Red Checkout button
	Then I am taken to the Checkout page



