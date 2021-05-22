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
        public void SearchUsers(string p0)
        {
            driver.FindElement(searchUsers).SendKeys(p0);
        }

        public void Age()
        {
            var arr = new int[] { 66, 59, 48, 39, 36, 28,};
            double avg = Queryable.Average(arr.AsQueryable());
            Console.WriteLine("Average = " + avg);
        }
        
    

    
    }
}
