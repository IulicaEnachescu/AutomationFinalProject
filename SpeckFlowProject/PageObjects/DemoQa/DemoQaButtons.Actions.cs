using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSpecSelProj
{
    partial class DemoQaButtons
    {
        public void Click(string buttonType)
        {
            if (buttonType== "ClickMeButton")
            ClickMeButton.Click();

            if (buttonType == "DoubleClickMeButton")
                new Actions(_driver).DoubleClick(DoubleClickMeButton).Perform();

            if (buttonType == "RightClickMeButton")
                new Actions(_driver).ContextClick(RightClickMeButton).Perform();
        }
        

        public void AssertCorrectTextMessage(string message, IWebElement element)
        {
            Assert.AreEqual(message, element.Text);
        }
    }
}

