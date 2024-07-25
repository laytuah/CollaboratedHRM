Feature: Login_UI

Scenario: User can Login
	Given That OrangeHRM has loaded successfully
	When user insert "Admin" has username
	And user inserts "admin123" as password
	And user clicks on Login Button
	Then Then user is logged in successfully