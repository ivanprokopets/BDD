Feature: Edit_Record_Admin
	Admin wants to edit record to the database

Scenario: EditRecord
	Given That I am on the edgewords websites
	And I have a form to fill out as admin  
	When I’ll fill out a form with the data, where I want to change 
	And I have a form to changes information
	Then The result should be on the screen with alert information, that record was edited
