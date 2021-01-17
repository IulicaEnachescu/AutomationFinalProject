using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace TestSpecSelProj
{
    partial class DemoQaRegisterPage
    {
        public void FillInForm(PracticeFormDto user)
        {
            var firstNameValue = user.GetType().GetRuntimeProperty("FirstName").GetValue(user);
            if (firstNameValue != null)
            {
                firstNameFieldTextBox.SendKeys(firstNameValue.ToString());
            }
            var lastNameValue = user.GetType().GetRuntimeProperty("LastName").GetValue(user);
            if (lastNameValue!=null)
            { lastNameFieldTextBox.SendKeys(lastNameValue.ToString()); }

            var emailValue = user.GetType().GetRuntimeProperty("Email").GetValue(user);
            if (emailValue!=null)
            {
                emailFieldTextBox.SendKeys(emailValue.ToString());
            }

            var genderValue = user.GetType().GetRuntimeProperty("Gender").GetValue(user);
            if (genderValue != null)
            {
                _driver.FindElement(By.XPath($"//label[text()='{genderValue}']")).Click();
            }
            var mobilePhoneValue = user.GetType().GetRuntimeProperty("MobilePhone").GetValue(user);
            if (mobilePhoneValue != null)
            {
                mobileFieldTextBox.SendKeys(mobilePhoneValue.ToString());
            }

            var dateOfBirthValue = user.GetType().GetRuntimeProperty("DateOfBirth").GetValue(user);
            if (dateOfBirthValue != null)
            {
                var date = dateOfBirthValue.ToString().Split('/').ToList();
                SelectElement selectElement;
                dateOfBirthFieldDatepicker.Click();
                selectElement = new SelectElement(monthDropdownSelect);
                selectElement.SelectByValue((int.Parse(date[0]) - 1).ToString());

                selectElement = new SelectElement(yearDropdownSelect);
                selectElement.SelectByValue(date[2]);

                _driver.FindElement(By.CssSelector($".react-datepicker__day--0{date[1]}")).Click();
            }
            var subjectsValue = user.GetType().GetRuntimeProperty("Subjects").GetValue(user);
            if (subjectsValue != null)
            {
                var subjects = subjectsValue.ToString().Split(',').ToList();
                foreach (var subject in subjects)
                {
                    subjectsFieldAutocomplete.SendKeys(subject);
                    Thread.Sleep(10);
                    subjectsFieldAutocomplete.SendKeys(Keys.Tab);
                }
            }
            var hobbiesValue = user.GetType().GetRuntimeProperty("Hobbies").GetValue(user);
            if (hobbiesValue != null)
            {
                var hobbies = hobbiesValue.ToString().Split(',').ToList();
                foreach (var hobby in hobbies)
                {
                    _driver.FindElement(By.XPath($"//label[text()='{hobby.Trim()}']")).Click();
                }
            }


            var currentAddressValue = user.GetType().GetRuntimeProperty("CurrentAddress").GetValue(user);
            if (currentAddressValue != null)
            {
                currentAddressFieldTextBox.SendKeys(currentAddressValue.ToString());
            }

            var stateValue = user.GetType().GetRuntimeProperty("State").GetValue(user);
            if (stateValue != null)
            {
                stateDropdown.SendKeys(stateValue.ToString());
                stateDropdown.SendKeys(Keys.Tab);
            }

            var cityValue = user.GetType().GetRuntimeProperty("City").GetValue(user);
            if (cityValue != null)
            {
                cityDropdown.SendKeys(cityValue.ToString());
                cityDropdown.SendKeys(Keys.Tab);
            }
        }

        public void SubmitForm()
        {
            submitButton.Click();
            Thread.Sleep(500);
        }

    }
}
