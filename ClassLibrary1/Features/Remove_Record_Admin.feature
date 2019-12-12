Feature: Remove_Record_Admin
	Admin wants to remove record to the database

@mytag
Scenario: RemoveRecord
	Given That I am on the edgewords websites.
	And I log in as administrator
	When I will enter the name of the user in the field to remove the record
	Then the result will be deleted record from the database