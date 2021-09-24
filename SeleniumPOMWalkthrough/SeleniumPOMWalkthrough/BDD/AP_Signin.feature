Feature: AP_Signin
	I want to be able to sign in to my account

@login
Scenario: Invalid password
	Given I am on the Homepage
	And I have entered the username "standard_user"
	And I have entered the password "dsfsdhfkdj"
	When I click the log in button
	Then I should See a "Epic sadface: Username and password do not match any user in this service" error
@login
	Scenario: Valid credentials
	Given I am on the Homepage
	And I have entered the username "standard_user"
	And I have entered the password "secret_sauce"
	When I click the log in button
	Then I am On the UserPage

	Scenario: Valid credentials alternate
	Given I am on the Homepage
	And I have the given credentials
	| Username      | Password |
	| standard_user |secret_sauce  |
	When I enter these credentials
	And I click the log in button
	Then I am On the UserPage

	@login
Scenario: Empty Fields
	Given I am on the Homepage
	When I click the log in button
	Then I should See a "Epic sadface: Username is required" error


Scenario: Locked Out User
	Given I am on the Homepage
	And I have entered the username "locked_out_user"
	And I have entered the password "secret_sauce"
	When I click the log in button
	Then I should See a "Epic sadface: Sorry, this user has been locked out." error



