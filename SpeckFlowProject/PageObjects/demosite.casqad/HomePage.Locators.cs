﻿using OpenQA.Selenium;

namespace TestSpecSelProj
{
    partial class HomePage
    {
        private IWebDriver _driver;
        
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

      
        public IWebElement AutentificareButton => _driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        public IWebElement InscriereButton => _driver.FindElement(By.XPath("//a[text()='Înscriere']"));
        public IWebElement DeconectareButton => _driver.FindElement(By.XPath("//a[text()='Deconectare']"));
        private IWebElement VeziDetaliiButton => _driver.FindElement(By.CssSelector(".btn-primary"));
        private IWebElement NavBar => _driver.FindElement(By.Id("collapsibleNavbar"));
        public IWebElement CategoryLabel => _driver.FindElement(By.CssSelector(".list-group-item.disabled"));

    }
}
