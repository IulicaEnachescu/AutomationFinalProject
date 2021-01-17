
using System.Reflection;

namespace TestSpecSelProj
{
    partial class DemoQaTextBoxPage
    {
        public void FillInForm()
        {
            fullNameFieldTextBox.SendKeys("Test User Full Name");
            emailFieldTextBox.SendKeys("testuser@test.com");
            currentAddressFieldTextBox.SendKeys("My current street 11, Brasov, Romania");
            permanentAddressFieldTextBox.SendKeys("My permanent street 101, Brasov, Romania");
            submitButton.Click();
        }
        public void FillInForm(UserDto user)
        {
            var fullNameValue = user.GetType().GetRuntimeProperty("FullName").GetValue(user);
            if (fullNameValue != null)
            {
                fullNameFieldTextBox.SendKeys(fullNameValue.ToString());
            }
            var emailValue = user.GetType().GetRuntimeProperty("Email").GetValue(user);
            if (emailValue != null)
            {
                emailFieldTextBox.SendKeys(emailValue.ToString());
            }
            var currentAddressValue = user.GetType().GetRuntimeProperty("CurrentAddress").GetValue(user);
            if (currentAddressValue != null)
            {
                currentAddressFieldTextBox.SendKeys(currentAddressValue.ToString());
            }

            var permanentAddressValue = user.GetType().GetRuntimeProperty("CurrentAddress").GetValue(user);
            if (permanentAddressValue != null)
            {
                permanentAddressFieldTextBox.SendKeys(permanentAddressValue.ToString());
            }
            submitButton.Click();
        }

        public void SubmitForm()
        {
            submitButton.Click();
        }
    }
}
