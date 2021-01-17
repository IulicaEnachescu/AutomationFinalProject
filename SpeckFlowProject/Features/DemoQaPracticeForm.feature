Feature: DemoQaTests
	In order to practice my automation skills
	As a tester
	I want to be able to use www.demoqa.com web page for the tests



@CreateDemoQaAccount
#Navigate to the page https://demoqa.com/automation-practice-form. Complete all fields and pess submit button.
Scenario: CreateDemoQaAccount
	Given I go to the 'https://demoqa.com/automation-practice-form' website
	When I fill in the registration form
	| FirstName | LastName | Email         | Gender | MobilePhone   | DateOfBirth | Subjects    | Hobbies       | CurrentAddress         | State   | City    |
	| FirstName | LastName | user@mail.com | Female | 073321234		| 01/11/1988  | Maths, Arts | Sports, Music | Happy street 4, SV, RO | Haryana | Panipat |
	Then I should see the confirmation that the form was submitted

@DemoQaTextBox
#Navigate to the page https://demoqa.com/text-box. Complete all fields and pess submit button.
Scenario: DemoQaTextBox
	Given I go to the 'https://demoqa.com/text-box' website
	When I fill in the text box form
	| FullName	| Email			| CurrentAddress				        | PermanentAddress                      |
	| FirstName | user@mail.com | Happy Street no 1 Iasi Romania		| Happy Street no 1 Iasi Romania |
	Then I should see the confirmation panel
	
	@UseDemoQAButtons
#Navigate to the page https://demoqa.com/buttons. Submit button.
Scenario: UseDemoQAButtons
	Given I go to the 'https://demoqa.com/buttons' website
	When I click the 'ClickMeButton'
	Then I should see the message 'You have done a dynamic click'
	
	@UseDemoQATables
#Navigate to the page https://demoqa.com/webtables. Submit button.
Scenario: UseDemoQATable
	Given I go to the 'https://demoqa.com/webtables' website
	When I search 'Vega'
	Then I should see one row with delete button

	@UseDemoQATables
#Navigate to the page https://demoqa.com/webtables. Submit button.
Scenario: UseDemoQATableDelete
	Given I go to the 'https://demoqa.com/webtables' website
	When I delete first row
	When I search 'Vega'
	Then I should see No rows found message
	
