using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumEasy.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumEasy.PageObject
{
    class FormPage
    {
        public IWebDriver driver;
        public FormPage()
        {
            driver = WebHook.driver;
        }

        private By firstName = By.CssSelector("#contact_form > fieldset > div:nth-child(2) > div > div > input");
        private By lastName = By.CssSelector("#contact_form > fieldset > div:nth-child(3) > div > div > input");
        private By email = By.CssSelector("#contact_form > fieldset > div:nth-child(4) > div > div > input");
        private By phone = By.CssSelector("#contact_form > fieldset > div:nth-child(5) > div > div > input");
        private By address = By.CssSelector("#contact_form > fieldset > div:nth-child(6) > div > div > input");
        private By city = By.CssSelector("#contact_form > fieldset > div:nth-child(7) > div > div > input");
        private By state = By.CssSelector("#contact_form > fieldset > div:nth-child(8) > div > div > select");
        private By zipCode = By.CssSelector("#contact_form > fieldset > div:nth-child(9) > div > div > input");
        private By website = By.CssSelector("#contact_form > fieldset > div:nth-child(10) > div > div > input");
        private By tickBox = By.CssSelector("#contact_form > fieldset > div:nth-child(11) > div > div:nth-child(2) > label > input[type=radio]");
        private By description = By.CssSelector("#contact_form > fieldset > div:nth-child(12) > div > div > textarea");
        private By clickSend = By.CssSelector("#contact_form > fieldset > div:nth-child(14) > div > button");
        public void FirstName(string p0)
        {
            driver.FindElement(firstName).SendKeys(p0);
        }

        public void LastName(string p1)
        {
            driver.FindElement(lastName).SendKeys(p1);
        }

        public void Email(string p2)
        {
            driver.FindElement(email).SendKeys(p2);
        }

        public void Phone(string p3)
        {
            driver.FindElement(phone).SendKeys(p3);
        }

        public void Address(string p4)
        {
            driver.FindElement(address).SendKeys(p4);
        }

        public void City(string p5)
        {
            driver.FindElement(city).SendKeys(p5);
        }

        public void State()
        {
            driver.FindElement(state).Click();
            var selectElement = new SelectElement(driver.FindElement(By.CssSelector("#contact_form > fieldset > div:nth-child(8) > div > div > select")));
            selectElement.SelectByText("New York");
            
        }

        public void ZipCode(string p6)
        {
            driver.FindElement(zipCode).SendKeys(p6);
        }
        
        public void Website(string p7)
        {
            driver.FindElement(website).SendKeys(p7);
        }

        public void TickBox()
        {
            driver.FindElement(tickBox).Click();
        }

        public void Descpription()
        {
            driver.FindElement(description).SendKeys("Form Filled in");
        }

        public void ClickSend()
        {
            driver.FindElement(clickSend).Click();
        }

    }
}
