Feature: futureShopper
	As a User, I want to be able to enter my personal 
	information for registration, so that I can register and browse.


@mytag
Scenario: Registration
	Given I navigate to "http://new.futureshoppers.com.ng"
	When I click on close pop up
	When I click on create Account/Log in
	And I enter email address "obey"
	And I click on register button
	Then I should be register with My Account Displayed