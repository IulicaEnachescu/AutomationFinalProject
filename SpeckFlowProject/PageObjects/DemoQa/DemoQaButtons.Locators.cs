using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSpecSelProj
{
    partial class DemoQaButtons
    {
        private IWebDriver _driver;



        public DemoQaButtons(IWebDriver driver) => _driver = driver;
        public IWebElement ClickMeButton => _driver.FindElement(By.XPath("//button[text()='Click Me']"));

        public IWebElement DoubleClickMeButton => _driver.FindElement(By.Id("doubleClickBtn"));

        public IWebElement RightClickMeButton => _driver.FindElement(By.Id("rightClickBtn"));

        public IWebElement ClickMeMessage => _driver.FindElement(By.Id("dynamicClickMessage"));

        public IWebElement DoubleClickMessage => _driver.FindElement(By.Id("doubleClickMessage"));

        public IWebElement RightClickMessage => _driver.FindElement(By.Id("rightClickMessage"));
    }
}

