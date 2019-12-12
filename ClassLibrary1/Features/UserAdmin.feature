Feature: UserAdmin
	Website admins want to manage users

Scenario: Admin Login
	Given That I am on the edgewords web site	
	When I login as an administrator
	Then I see the full admin list of options
	Then I am logout of application
