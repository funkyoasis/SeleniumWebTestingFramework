Feature: UserPage
	Simple calculator for adding two numbers

@Items
Scenario: Add Item to cart
	Given I am On the UserPage
	When I click the ADD TO CART button on an item
	Then shopping cart should increase by one

@Items
Scenario: Remove Item from cart
	Given I am On the UserPage
	When I click the ADD TO CART button on an item
	Then shopping cart should increase by one
	When I click the REMOVE button on an item
	Then shopping cart should decrease by one


@sorting
Scenario: Sort Items By Name Z to A
	Given I am On the UserPage
	When i click the sorting button
	And I click Name Z to A
	Then The List is sorted Alphabetically and Reversed
