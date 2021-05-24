Feature: Age
	

@Scenario2
Scenario: read employees age
	Given I navigate to the homepage
	When I search of users in "San Francisco"
	Then I verify that the average age of all the employees in that office is 46