using OpenQA.Selenium;

namespace TestSpecSelProj
{
    partial class DemoQaRegisterPage 
    {
        private IWebDriver _driver;
       

        public DemoQaRegisterPage(IWebDriver driver) => _driver = driver;

        private IWebElement firstNameFieldTextBox => _driver.FindElement(By.Id("firstName"));
        private IWebElement lastNameFieldTextBox => _driver.FindElement(By.Id("lastName"));
        private IWebElement emailFieldTextBox => _driver.FindElement(By.Id("userEmail"));
        private IWebElement genderButton => _driver.FindElement(By.XPath("//label[text()='Female']"));
        private IWebElement mobileFieldTextBox => _driver.FindElement(By.Id("userNumber"));
        private IWebElement currentAddressFieldTextBox => _driver.FindElement(By.Id("currentAddress"));
        private IWebElement dateOfBirthFieldDatepicker => _driver.FindElement(By.Id("dateOfBirthInput"));
        private IWebElement monthDropdownSelect => _driver.FindElement(By.ClassName("react-datepicker__month-select"));
        private IWebElement yearDropdownSelect => _driver.FindElement(By.ClassName("react-datepicker__year-select"));

        private IWebElement subjectsFieldAutocomplete => _driver.FindElement(By.Id("subjectsInput"));

        private IWebElement hobbiesSportsCheckbox => _driver.FindElement(By.XPath("//label[(text()='Sports')]"));
        private IWebElement chooseFileButton => _driver.FindElement(By.Id("uploadPicture"));
        private IWebElement addressFieldTextBox => _driver.FindElement(By.Id("currentAddress"));

        private IWebElement stateDropdown => _driver.FindElement(By.CssSelector("#state input"));
        
        private IWebElement firstStateOption => _driver.FindElement(By.Id("react-select-3-option-0"));
        
        private IWebElement cityDropdown => _driver.FindElement(By.CssSelector("#city input"));
        private IWebElement firstCityOption => _driver.FindElement(By.Id("react-select-4-option-0"));
        
        private IWebElement submitButton => _driver.FindElement(By.Id("submit"));
        public IWebElement confirmationDialogTitle => _driver.FindElement(By.Id("example-modal-sizes-title-lg"));
    }
}
