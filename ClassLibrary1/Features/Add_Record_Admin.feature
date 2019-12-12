Feature: Add_Record_Admin
	Admin wants to add new record to the database

Scenario: New Record
	Given That I am on the edgewords website
	And I have a form to fill out
	When I press submin
	Then the result should be on the screen with alert information, that record was added