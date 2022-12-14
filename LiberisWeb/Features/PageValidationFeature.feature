Feature: PageValidationFeature
	Validation of Page, Page Navigation, Title of Pages,
	Partners on avialable on page,


@TitleVerification
Scenario: Verification of Page Title
	Given user is on Homepage	
	When user click on Get a Demo Button
	Then verify the title as "Become A Partner | Liberis"
	
@ErrorMessageverification
Scenario: Verification of ErrorMessage
	Given user is on Homepage	
	When user click on Get a Demo Button
	And without selecting any Radio button user click on Get a demo button
	Then User should get message as "Please select a type of partner"

@PartnersVerification
Scenario: Verification of Partners
	Given user is on Homepage	
	When user click on Get a Demo Button
	Then Check Type of Partners list "I'm a Broker,I'm an ISO,I'm a Strategic Partner" present on webpage	

#Added negative Scenario, changed list of partners
@PartnersVerificationNegative
Scenario: Neg-Verification of Partners
	Given user is on Homepage	
	When user click on Get a Demo Button
	Then Check Type of Partners list "I'm a Brokers,I'm an ISO,I'm a Strategic Partners" present on webpage	
