Feature: Search items

Scenario: The website shows items
	Given I have entered to a website
	When I have searched "dress"
	Then The website shows "7" dresses
