using OpenQA.Selenium;
using SeleniumEasy.Hooks;
using SeleniumEasy.PageObject;
using System;
using TechTalk.SpecFlow;

namespace SeleniumEasy.Steps
{
    [Binding]
    public class FormSteps
    {
        public IWebDriver driver = WebHook.driver;
        FormPage formpage = new FormPage();

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/input-form-demo.html");
        }

        [Given(@"user Fills in details '(.*)' '(.*)' '(.*)' '(.*)' '(.*)' '(.*)' '(.*)' '(.*)'")]
        public void GivenUserFillsInDetails(string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7)
        {
            formpage.FirstName(p0);
            formpage.LastName(p1);
            formpage.Email(p2);
            formpage.Phone(p3);
            formpage.Address(p4);
            formpage.City(p5);
            formpage.State();
            formpage.ZipCode(p6);
            formpage.Website(p7);
        }


        //[Given(@"user Fills in details '(.*)' '(.*)' '(.*)' '(.*)' '(.*)' '(.*)' '(.*)' '(.*)' '(.*)'")]
        //public void GivenUserFillsInDetails(string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8)
        //{
        //    formpage.FirstName(p0);
        //    formpage.LastName(p1);
        //    formpage.Email(p2);
        //    formpage.Phone(p3);
        //    formpage.Address(p4);
        //    formpage.City(p5);
        //    formpage.State();
        //    formpage.ZipCode(p7);
        //    formpage.Website(p8);
        //}

        
        [Given(@"I tick yes or no do you have hosting\?")]
        public void GivenITickYesOrNoDoYouHaveHosting()
        {
            formpage.TickBox();
        }

        [Given(@"I enter project description")]
        public void GivenIEnterProjectDescription()
        {
            formpage.Descpription();
        }

        [When(@"I click send")]
        public void WhenIClickSend()
        {
            formpage.ClickSend();
        }
        
       
    }
}
