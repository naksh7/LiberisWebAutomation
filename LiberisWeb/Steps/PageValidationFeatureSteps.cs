using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace LiberisWeb.Steps
{
    [Binding]
    public class PageValidationFeatureSteps
    {
        IWebDriver driver;
        String url = "https://www.liberis.com/";

        [Given(@"user is on Homepage")]
        public void GivenUserIsOnHomepage()
        {
            driver = new ChromeDriver("C:\\Akshay\\LiberisWeb\\LiberisWeb\\Drivers");
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            driver.Url = url;
        }
        
        [When(@"user click on Get a Demo Button")]
        public void WhenUserClickOnGetADemoButton()
        {
            driver.FindElement(By.ClassName("header-cta")).Click();
        }
        
        [Then(@"verify the title as ""(.*)""")]
        public void ThenVerifyTheTitleAs(string p0)
        {
            String title = driver.Title;
            Assert.AreEqual(p0, title, "Title are not Equal");
        }

        [Then(@"close the Browser")]
        public void ThenCloseTheBrowser()
        {
            driver.Close();
        }
        //Second Scenario Unimplemented Methods
        [When(@"without selecting any Radio button user click on Get a demo button")]
        public void WhenWithoutSelectingAnyRadioButtonUserClickOnGetADemoButton()
        {
            driver.FindElement(By.ClassName("js-partner-hero-button")).Click();
        }

        [Then(@"User should get message as ""(.*)""")]
        public void ThenUserShouldGetMessageAs(string p0)
        {
            Thread.Sleep(2000);
            String errorMessage = driver.FindElement(By.ClassName("ph-submit-error")).Text;
            Assert.AreEqual(p0, errorMessage, "Error message are not equal or not shown");
        }


    }
}
