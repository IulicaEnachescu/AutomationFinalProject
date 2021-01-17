﻿using OpenQA.Selenium;

namespace TestSpecSelProj
{
    public class BasePage
    {
        public readonly string CasqadUrl = "http://demosite.casqad.org/";
        private IWebDriver _driver;

        public BasePage(IWebDriver driver) => _driver = driver;

        public void NavigateToUrl(string pageUrl)
        {
            _driver.Navigate().GoToUrl(pageUrl);
        }
    }
}
