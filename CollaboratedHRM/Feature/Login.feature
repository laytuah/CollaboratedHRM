Feature: Login_UI

Scenario: User can Login
	Given That OrangeHRM has loaded successfully
	When user insert "Admin" has username
	And user inserts "admin123" as password
	And user clicks on Login Button
	Then Then user is logged in successfully

Scenario: Adding New Employer
	Given That OrangeHRM has loaded successfully
	When user insert "Admin" has username
	And user inserts "admin123" as password
	And user clicks on Login Button
	And user clicks on PIM button
	And user click on Add button
	And user fill in User Employee Firstname, MiddleName, Lastname as 'Akinkunmi', 'Ibrahim' and 'Tiamiyu' respectively
	And user click the save button
	And user fill in OtherId, Driver License Number and License Expiry date as '0700', '55221478' and '2028-02-08' respectively
	And user also fill Nationality, Marital Status, Date of Birth and Gender as 'Nigerian', 'single', '1996-02-05' and Male respectively
	And user click save button	
	Then user verify that new employee is successfully added