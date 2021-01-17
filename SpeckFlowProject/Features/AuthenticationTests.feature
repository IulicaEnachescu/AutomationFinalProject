Feature: AuthenticationTests
	In order to validate login
	As an admin user
	I want to authenticate into casqad.org

#@LoginUsingParams
#Scenario: ValidateLoginUsingParams
#	Given I navigate to authentication page
#	When I login with user 'admin.test3@gmail.com'
#		And password 'password123'
#	Then I am logged in


@LoginUsingExamples
Scenario Outline: ValidateLoginUsingExamples
	Given I navigate to authentication page
	When I login with following credentials
	| userEmail        | userPassword		 |
	| <userEmailValue> | <userPasswordValue> |
	Then I am logged in

	Examples:
	| userEmailValue         | userPasswordValue |
	| admin.test3@gmail.com  | password123       |


@LoginUsingNullCheck
Scenario Outline: ValidateLoginNullCheck
	Given I navigate to authentication page
	When I login with following credentials
	| userEmail        | userPassword		 |
	| <userEmailValue> | <userPasswordValue> |
	Then I am not logged in

	Examples:
	| userEmailValue         | userPasswordValue |
	| admin.test3@gmail.com  |                   |

	@LoginUsingInvalidEmail
Scenario Outline: ValidateLoginInvalidCheck
	Given I navigate to authentication page
	When I login with following credentials
	| userEmail        | userPassword		 |
	| <userEmailValue> | <userPasswordValue> |
	Then I am not logged in

	Examples:
	| userEmailValue         | userPasswordValue |
	| admin.test3@gmail.com  |  password                 |
	
@ValidateAdministrarePage
Scenario: ValidateAdministrarePage
	Given I navigate to authentication page
	When I login with following credentials
	| userEmail             | userPassword |
	| admin.test3@gmail.com | password123  |
	When I click administrare
	Then I see adauga produs nou

@ValidateAdaugaProdusPage
Scenario: ValidateAdaugaProdusPage
	Given I navigate to authentication page
	When I login with following credentials
	| userEmail             | userPassword |
	| admin.test3@gmail.com | password123  |
	When I click administrare
	And I click adauga produs
	Then I see adauga produsul button

@ValidateCosPage
Scenario: ValidateCosPage
	Given I navigate to authentication page
	When I login with following credentials
	| userEmail             | userPassword |
	| admin.test3@gmail.com | password123  |
	When I click cos
	Then I see comanda acum button

@ValidateDeconectareButton
Scenario: ValidateDeconectareButton
	Given I navigate to authentication page
	When I login with following credentials
	| userEmail             | userPassword |
	| admin.test3@gmail.com | password123  |
	When I click deconectare button
	Then I see autentificare on home page