Feature: PageValidationFeature
	Validation of Page, Page Navigation, Title of Pages,
	Partners on avialable on page,


@TitleVerification
Scenario: Verification of Page Title
	Given user is on Homepage	
	When user click on Get a Demo Button
	Then verify the title as "Become A Partner | Liberis"
	Then close the Browser


@ErrorMessageverification
Scenario: Verification of Message
	Given user is on Homepage	
	When user click on Get a Demo Button
	And without selecting any Radio button user click on Get a demo button
	Then User should get message as "Please select a type of partner"
	Then close the Browser

