Feature: UserRegistration
	Wedsite users want to use the site

Scenario: Regestration Login
	Given That I am on registration form 
	When I login as an user
	Then I see my internet profile
