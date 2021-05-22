using OpenQA.Selenium;
using SeleniumEasy.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumEasy.PageObject
{
    class SalariesPage
    {
        public IWebDriver driver;
        public SalariesPage()
        {
            driver = WebHook.driver;
        }

        private By readSalaries = By.CssSelector("#example_filter > label > input[type=search]");
        public void ReadSalaries(string p0)
        {
            driver.FindElement(readSalaries).SendKeys(p0);
        }

        private By validHighestSalary = By.CssSelector("#example > tbody > tr.even > td:nth-child(6)");
        public bool ValidHighestSalary(string p0)
        {
            return driver.Url.Contains(p0);
        }






    }
}
