using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSpecSelProj
{
    public partial class HomeLoginPage
    {
        private IWebDriver _driver;

        public HomeLoginPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement AdministrareButton => _driver.FindElement(By.XPath("//a[text()='Administrare']"));
        public IWebElement CosButton => _driver.FindElement(By.XPath("//a[text()='Coș']"));
        public IWebElement AdaugaProdusButton => _driver.FindElement(By.XPath("//a[text()='Adaugă produs nou']"));
        public IWebElement AdaugaProdButton => _driver.FindElement(By.ClassName("btn-primary"));
        public IWebElement DeconectareButton => _driver.FindElement(By.XPath("//a[text()='Deconectare']"));
        public IWebElement ComandaAcumButton => _driver.FindElement(By.XPath("//a[text()='Comandă Acum']"));
        //public IWebElement AdaugaProdusButton => _driver.FindElement(By.CssSelector("a.btn.btn - primary"));
    }
}

