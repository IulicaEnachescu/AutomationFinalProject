using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSpecSelProj
{
    partial class HomeLoginPage
    {
        public void Click(IWebElement element)
        {
            AdministrareButton.Click();
        }
        public void AssertElementdisplayed(IWebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }
    }
}
