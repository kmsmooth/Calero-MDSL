using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumEasy.Hooks;
using SeleniumEasy.PageObject;
using System;
using TechTalk.SpecFlow;

namespace SeleniumEasy.Steps
{
    [Binding]
    public class AgeSteps
    {
        public IWebDriver driver = WebHook.driver;
        AgePage agePage = new AgePage();


        [Given(@"I navigate to the homepage")]
        public void GivenINavigateToTheHomepage()
        {
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/table-sort-search-demo.html");
        }
        
        [When(@"I search of users in ""(.*)""")]
        public void WhenISearchOfUsersIn(string p0)
        {
            agePage.SearchUsers(p0);
        }

        [Then(@"I verify that the average age of all the employees in that office is (.*)")]
        public void ThenIVerifyThatTheAverageAgeOfAllTheEmployeesInThatOfficeIs(int p0)
        {
            agePage.Age(p0);
        }



     
    }
}
