using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using System.Threading;

namespace UnitTestProject1
{
    [Binding]
    public sealed class Hooks1
    {
        private static ChromeDriver Driver = new ChromeDriver();

        [BeforeTestRun]
        public static void BeforeTests()
        {
            Driver.Navigate().GoToUrl("http://ya.ru");
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
