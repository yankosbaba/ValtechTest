Feature: User should be able to add ToDO items
		Make Items active
		And also clear items

Scenario: Assert that Latest News is showing
	Given I have nagivated to Valtech page
	Then Assert that Latest news is showing

Scenario: Assert that Service page is showing
	Given I have nagivated to Valtech page
	When I click on Service Page
	Then Assert that Service page is showing

Scenario: Assert that About page is showing
	Given I have nagivated to Valtech page
	When I click on About Page
	Then Assert that About page is showing

Scenario: Assert that Work page is showing
	Given I have nagivated to Valtech page
	When I click on Work Page
	Then Assert that Work page is showing

Scenario: Assert that Contact page is showing number of offices
	Given I have nagivated to Valtech page
	When I click on Contact Page
	Then Assert that number of offices is showing
	
