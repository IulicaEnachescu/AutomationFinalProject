using OpenQA.Selenium;

namespace TestSpecSelProj
{
    partial class DemoQaTextBoxPage
    {
        private IWebDriver _driver;
        public DemoQaTextBoxPage(IWebDriver driver) => _driver = driver;
        private IWebElement fullNameFieldTextBox => _driver.FindElement(By.Id("userName"));
        private IWebElement emailFieldTextBox => _driver.FindElement(By.Id("userEmail"));
        private IWebElement currentAddressFieldTextBox => _driver.FindElement(By.Id("currentAddress"));
        private IWebElement permanentAddressFieldTextBox => _driver.FindElement(By.Id("permanentAddress"));
        private IWebElement submitButton => _driver.FindElement(By.Id("submit"));
        public IWebElement confirmationPanel => _driver.FindElement(By.Id("output"));
    }
}
