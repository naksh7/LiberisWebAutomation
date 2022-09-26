using LiberisWeb.Drivers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LiberisWeb.Page
{
    public class HomePage 
    {        
        IWebDriver driver = Utils.getDriver();        

        By getADemoButton1 = By.ClassName("header-cta");
        By getADemoButton2 = By.ClassName("js-partner-hero-button");
        By errorMessage = By.ClassName("ph-submit-error");
        By partnersList = By.XPath("//input[@name='radio-group']");       
        
        public void getADemoButton1Click()
        {
            driver.FindElement(getADemoButton1).Click();
        }

        public void AssertTitle(String expected)
        {
            string actualTitle = driver.Title;
            Assert.AreEqual(expected, actualTitle, "Title are not Equal");
        }

        public void getADemoButton2Click()
        {
            driver.FindElement(getADemoButton2).Click();
        }

        public void AssertErrorMessage(string expectedErrorMessage)
        {
            Thread.Sleep(2000);
            string actualErrorMessage = driver.FindElement(errorMessage).Text;
            Assert.AreEqual(expectedErrorMessage, actualErrorMessage, "Error message is not equal or not shown");
        }

        public void AssertPartnersList(string expectedPartnersList)
        {
            var expectedList = Utils.StringSplitter(expectedPartnersList);
            int count = 0;
            IList<IWebElement> partnersListWebelement = driver.FindElements(partnersList);

            if (!(partnersListWebelement.Count == expectedList.Count))
                Console.WriteLine("Count of partners not matching. Expected :-" + expectedList.Count + " Actual :- " + partnersListWebelement.Count);

            for (int i = 0; i < partnersListWebelement.Count; i++)
            {
                var actualPartner = partnersListWebelement.ElementAt(i).GetAttribute("id");
                if (!expectedList.Contains(actualPartner))
                {
                    Console.WriteLine(actualPartner + " is not from Expected List");
                    count++;
                }
            }

            if (count > 0)
                Assert.Fail(count + " partners from Actual and Expected not matching");
        }


    }       
}
