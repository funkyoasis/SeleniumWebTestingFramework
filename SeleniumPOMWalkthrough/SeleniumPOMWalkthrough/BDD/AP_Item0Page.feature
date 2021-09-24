Feature: AP_Item0Page
	I Want to be able to do various things within an item's page

@Item0Page
	Scenario: Sucessfully Navigate to Item0 Page
	Given I am on the Homepage
	And I have entered the username "standard_user"
	And I have entered the password "secret_sauce"
	When I click the log in button
	Then I am On the UserPage
	When I click Item_zero link
	Then I should be in Item_zero Page

	@Item0Page
	Scenario: Item Image is shown 
	Given I am on the Homepage
	And I have entered the username "standard_user"
	And I have entered the password "secret_sauce"
	When I click the log in button
	Then I am On the UserPage
	When I click Item_zero link
	Then I should be in Item_zero Page
	Then The Item Image is displayed

	@Item0Page
	Scenario: Add Sauce Labs Bike Light to Cart
	Given I am on the Homepage
	And I have entered the username "standard_user"
	And I have entered the password "secret_sauce"
	When I click the log in button
	Then I am On the UserPage
	When I click Item_zero link
	Then I should be in Item_zero Page
	When I click the add to cart button
	Then shopping cart should increase by one.


	@Item0Page
	Scenario: Remove Sauce Labs Bike Light to Cart
	Given I am on the Homepage
	And I have entered the username "standard_user"
	And I have entered the password "secret_sauce"
	When I click the log in button
	Then I am On the UserPage
	When I click Item_zero link
	Then I should be in Item_zero Page
	When I click the add to cart button
	Then shopping cart should increase by one.
	When I click the remove button
	Then shopping cart should decrease by one.



