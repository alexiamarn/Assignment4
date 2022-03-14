Feature: User Login

@smoke
Scenario: Successfull login with valid credentials
	Given user navigates to homepage
	When user logins with username alex and password 123
	Then the user is successfully logged in


Scenario Outline: User cannot login with invalid credentials - one or both fields is/are empty
	Given user navigates to homepage
	When user logins with username <username> and password <password>
	Then the message Please enter a username and password. is displayed
	Examples:
	| username | password |
	|          |          |
	| alma     |          |
	|          | 12345    |

Scenario Outline: User cannot login with invalid credentials - both fields are filled but invalid
	Given user navigates to homepage
	When user logins with username <username> and password <password>
	Then the message The username and password could not be verified. is displayed
	Examples:
	| username | password |
	| alex     | 12       |       
	| alma     | 12       |
	| al       | 12345    |