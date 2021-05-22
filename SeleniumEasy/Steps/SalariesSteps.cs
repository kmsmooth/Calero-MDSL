using OpenQA.Selenium;
using SeleniumEasy.Hooks;
using SeleniumEasy.PageObject;
using System;
using TechTalk.SpecFlow;

namespace SeleniumEasy.Steps
{
    [Binding]
    public class SalariesSteps
    {
        public IWebDriver driver = WebHook.driver;
        SalariesPage salariesPage = new SalariesPage();

        [Given(@"I navigate Url ""(.*)""")]
        public void GivenINavigateUrl(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }

        [When(@"I read the salaries of all the ""(.*)"" at the company")]
        public void WhenIReadTheSalariesOfAllTheAtTheCompany(string p0)
        {
            salariesPage.ReadSalaries(p0);
        }


        [Then(@"I shoud able to verify that the highest salary for a software engineer is \$(.*)/y")]
        public void ThenIShoudAbleToVerifyThatTheHighestSalaryForASoftwareEngineerIsY(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
