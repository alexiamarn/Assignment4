Feature: User Registration

@smoke
Scenario Outline: Succesfull Registration
	Given user navigates to registration page
	When user registers with details
	| First Name  | Last Name | Address    | City     | State     | Zip Code  | Phone # | SSN    | Username   | Password   |
	| <firstname> |<lastname> | <address>  | <city>   | <state>   | <zipCode> | <phone> | <ssn>  | <username> | <password> |
	Then the registration gets completed and user with username tst gets welcomed
	Examples:
		| firstname |lastname | address    | city     | state     | zipCode | phone | ssn    | username | password |
		| Test      | Tester  | TestAdress | TestCity | TestState | 1234    | 12345 | 123456 | tst      | tst123   |
		| Test      | Tester  | TestAdress | TestCity | TestState | 1234    |       | 123456 | tst      | tst123   |

Scenario Outline: User cannot register when required fields are not set
	Given user navigates to registration page
	When user registers with details
	| First Name  | Last Name  | Address   | City   | State   | Zip Code  | Phone # | SSN   | Username   | Password   |
	| <firstname> | <lastname> | <address> | <city> | <state> | <zipCode> | <phone> | <ssn> | <username> | <password> |
	Then the user gets informed that fields <errorFields> are required
	Examples:
	| firstname | lastname | address    | city | state | zipCode | phone | ssn | username | password | errorFields                                                                                                     |
	|           |          |            |      |       |         |       |     |          |          | First name,Last name,Address,City,State,Zip Code,Social Security Number,Username,Password,Password confirmation |
	|           |          |            |      |       |         | 1234  |     |          |          | First name,Last name,Address,City,State,Zip Code,Social Security Number,Username,Password,Password confirmation |
	| Test      |          |            |      |       |         |       |     |          |          | Last name,Address,City,State,Zip Code,Social Security Number,Username,Password,Password confirmation            |
	| Test      | Tester   |            |      |       |         |       |     |          |          | Address,City,State,Zip Code,Social Security Number,Username,Password,Password confirmation                      |
	| Test      | Tester   | TestAdress |      |       |         |       |     |          |          | City,State,Zip Code,Social Security Number,Username,Password,Password confirmation                              |

Scenario: User with existing username cannot register
	Given user navigates to registration page
	And user registers with details
	| First Name | Last Name | Address    | City     | State     | Zip Code | Phone # | SSN    | Username | Password |
	| Test       | Tester    | TestAdress | TestCity | TestState | 1234     | 12345   | 123456 | tst      | tst123   |
	When user navigates to registration page
	And user registers with details
	| First Name | Last Name | Address    | City     | State     | Zip Code | Phone # | SSN    | Username | Password |
	| Test       | Tester    | TestAdress | TestCity | TestState | 1234     | 12345   | 123456 | tst      | tst123   |
	Then the error message This username already exists. is displayed