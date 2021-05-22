using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SeleniumEasy.Hooks
{
    [Binding]
    public class WebHook
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public static void BeforeScenario()
        {
            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}
