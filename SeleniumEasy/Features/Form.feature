Feature: Form
	

@Scenario1
Scenario: fill in form and submit
	Given I am on the homepage
	And  user Fills in details '<FirstName>' '<LastName>' '<Email>' '<Phone>' '<Address>' '<City>' '<ZipCode>' '<Website>'
	And I tick yes or no do you have hosting?
	And I enter project description
	When I click send

Examples: 
|FirstName|LastName|Email         |Phone          |Address      | City    |ZipCode |Website           |
|James    |Smith   |test@test.com |(164) 698-0669 |1410 Broadway| New York|10018   |www.caleromdsl.com|

