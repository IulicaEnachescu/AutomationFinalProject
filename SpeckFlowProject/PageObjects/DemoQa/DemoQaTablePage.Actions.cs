using NUnit.Framework;
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
        public void DeleteRecord()
        {
            DeleteFirstRecord.Click();
        }
        public void SearchRecord(string text)
        {
            SearchBox.SendKeys(text);
            SearchButton.Click();
        }
        public void AssertTextFound(IWebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }
        public void AssertNoRowsFound()
        {
            Assert.IsTrue(NoResultText.Displayed);
        }
    }
}