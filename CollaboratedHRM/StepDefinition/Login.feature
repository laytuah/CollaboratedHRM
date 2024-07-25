Feature: Feature1

A short summary of the feature

@tag1
Scenario: User can Login
	Given That OrangeHRM has loaded successfully
	When user insert "Admin" has username
	And user inserts "admin123" as password
	And user clicks on Login Button
	Then Then user is logged in successfully
