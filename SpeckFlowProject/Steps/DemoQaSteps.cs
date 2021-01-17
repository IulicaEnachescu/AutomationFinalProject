using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TestSpecSelProj
{
    [Binding]
    public sealed class DemoQaSteps
    {
        private IWebDriver _driver;

        public DemoQaSteps(IWebDriver driver) => _driver = driver;




        [When(@"I fill in the registration form")]
        public void WhenIFillInTheRegistrationForm(Table table)
        {
            var user = table.CreateInstance<PracticeFormDto>();
            DemoQaRegisterPage demoQaFormPage = new DemoQaRegisterPage(_driver);
            demoQaFormPage.FillInForm(user);  
            demoQaFormPage.SubmitForm();
        }

        [Then(@"I should see the confirmation that the form was submitted")]
        public void ThenIShouldSeeTheConfirmationThatTheFormWasSubmitted()
        {
            DemoQaRegisterPage demoQaFormPage = new DemoQaRegisterPage(_driver);
            Assert.AreEqual("Thanks for submitting the form", demoQaFormPage.confirmationDialogTitle.Text);
        }

        [When(@"I fill in the text box form")]
        public void WhenIFillInTheTextBoxForm(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            DemoQaTextBoxPage demoQaTextBoxPage = new DemoQaTextBoxPage(_driver);
            demoQaTextBoxPage.FillInForm(user);  //TODO use table for the data
            demoQaTextBoxPage.SubmitForm();
        }

        [Then(@"I should see the confirmation panel")]
        public void ThenIShouldSeeTheConfirmationPanel()
        {
            DemoQaTextBoxPage demoQaTextBoxPage = new DemoQaTextBoxPage(_driver);
            Assert.IsTrue(demoQaTextBoxPage.confirmationPanel.Displayed);
        }
        [When(@"I click the '(.*)'")]
        public void WhenIClickThe(string p0)
        {
            DemoQaButtons demoQaButtonsPage = new DemoQaButtons(_driver);
            demoQaButtonsPage.Click(p0);
        }

        [Then(@"I should see the message '(.*)'")]
        public void ThenIShouldSeeTheMessage(string p0)
        {
            DemoQaButtons demoQaButtonsPage = new DemoQaButtons(_driver);
            demoQaButtonsPage.AssertCorrectTextMessage(p0, demoQaButtonsPage.ClickMeMessage);
        }
        [When(@"I search '(.*)'")]
        public void WhenISearch(string p0)
        {
            DemoQaTablePage demoQaTablePage = new DemoQaTablePage(_driver);
            demoQaTablePage.SearchRecord(p0);
        }
        [Then(@"I should see one row with delete button")]
        public void ThenIShouldSeeOneRowWithDeleteButton()
        {
            DemoQaTablePage demoQaTablePage = new DemoQaTablePage(_driver);
            demoQaTablePage.AssertTextFound(demoQaTablePage.DeleteFirstRecord);
        }
        [When(@"I delete first row")]
        public void WhenIDeleteFirstRow()
        {
            DemoQaTablePage demoQaTablePage = new DemoQaTablePage(_driver);
            demoQaTablePage.DeleteRecord();
        }

        [Then(@"I should see No rows found message")]
        public void ThenIShouldSeeNoRowsFoundMessage()
        {
            DemoQaTablePage demoQaTablePage = new DemoQaTablePage(_driver);
            demoQaTablePage.AssertNoRowsFound();
        }



    }
}
