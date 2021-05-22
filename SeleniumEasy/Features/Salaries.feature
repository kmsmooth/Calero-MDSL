Feature: Salaries
	

@Scenario3
Scenario: read salaries and verify highest salary
	Given I navigate Url "https://www.seleniumeasy.com/test/table-sort-search-demo.html"
	When I read the salaries of all the "software engineer" at the company
	Then I shoud able to verify that the highest salary for a software engineer is $206,850/y

	