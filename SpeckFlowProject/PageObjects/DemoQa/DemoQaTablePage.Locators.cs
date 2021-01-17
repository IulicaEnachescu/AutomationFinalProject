using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSpecSelProj
{
    partial class DemoQaTablePage
    {
        private IWebDriver _driver;



        public DemoQaTablePage(IWebDriver driver) => _driver = driver;
        public IWebElement SearchBox => _driver.FindElement(By.Id("searchBox"));
        public IWebElement SearchButton => _driver.FindElement(By.Id("basic-addon2"));

        public IWebElement DeleteFirstRecord => _driver.FindElement(By.Id("delete-record-1"));

        public IWebElement NoResultText => _driver.FindElement(By.XPath("//div[@class='rt-noData']"));
    }
}
