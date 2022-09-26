using LiberisWeb.Page;
using TechTalk.SpecFlow;

namespace LiberisWeb.Steps
{
    [Binding]
    public class PageValidationFeatureSteps
    {

        HomePage hp;

        [Given(@"user is on Homepage")]
        public void GivenUserIsOnHomepage()
        {
            hp = new HomePage();
        }

        [When(@"user click on Get a Demo Button")]
        public void WhenUserClickOnGetADemoButton()
        {
            hp.getADemoButton1Click();
        }
        
        [Then(@"verify the title as ""(.*)""")]
        public void ThenVerifyTheTitleAs(string expectedTitle)
        {
            hp.AssertTitle(expectedTitle);
        }    

        //Second Scenario Methods
        [When(@"without selecting any Radio button user click on Get a demo button")]
        public void WhenWithoutSelectingAnyRadioButtonUserClickOnGetADemoButton()
        {
            hp.getADemoButton2Click();
        }

        [Then(@"User should get message as ""(.*)""")]
        public void ThenUserShouldGetMessageAs(string expectedErrorMessage)
        {
            hp.AssertErrorMessage(expectedErrorMessage);
        }

        //Third Scenario menthods
        [Then(@"Check Type of Partners list ""(.*)"" present on webpage")]
        public void ThenCheckTypeOfPartnersListPresentOnWebpage(string expectedPartnersList)
        {
            hp.AssertPartnersList(expectedPartnersList);
        }

        
    }
}
