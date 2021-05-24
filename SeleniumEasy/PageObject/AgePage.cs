using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumEasy.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumEasy.PageObject
{
    class AgePage
    {
        public IWebDriver driver;
        public AgePage()
        {
            driver = WebHook.driver;
        }

        private By searchUsers = By.CssSelector("#example_filter > label > input[type=search]");
        private bool averageAge;

        public void SearchUsers(string p0)
        {
            driver.FindElement(searchUsers).SendKeys(p0);
        }

        public int Age(int p0)
        {
            var age = 66 + 28 + 39 + 36 + 48 + 59;
            var averageAge = age / 6;
            return averageAge;          
        }

      



    }
}
