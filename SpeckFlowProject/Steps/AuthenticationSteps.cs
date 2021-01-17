using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestSpecSelProj;

namespace TestSpecSelProj
{
    [Binding]  //specflow attribute - indicates that this class is binded with a feature file
    public sealed class AuthenticationSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private IWebDriver _driver;

        public AuthenticationSteps(IWebDriver driver) => _driver = driver;

        [Given(@"I navigate to authentication page")]
        public void GivenINavigateToAuthenticationPage()
        {
            BasePage basePage = new BasePage(_driver);
            HomePage homePage = new HomePage(_driver);
            basePage.NavigateToUrl(basePage.CasqadUrl);
            homePage.GoToAuthentication();
        }


        [When(@"I login with following credentials")]
        public void WhenILoginWithFollowingCredentials(Table table)
        {
            var myUser = table.CreateInstance<UserDto>();
            LoginPage loginPage = new LoginPage(_driver);
            //loginPage.AuthenticateUser(myUser.userEmail, myUser.userPassword);
            loginPage.LoginIntoApplication(myUser);
        }


        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            HomePage homePage = new HomePage(_driver);
            Assert.IsTrue(homePage.DeconectareButton.Displayed);
        }
        [Then(@"I am not logged in")]
        public void ThenIAmNotLoggedIn()
        {
            LoginPage loginPage = new LoginPage(_driver);
            Assert.IsTrue(loginPage.SubmitButton.Displayed);
        }
        [When(@"I click administrare")]
        public void WhenIClickAdministrare()
        {
            HomeLoginPage loginPage = new HomeLoginPage(_driver);
            loginPage.Click(loginPage.AdministrareButton);
        }

        [Then(@"I see adauga produs nou")]
        public void ThenISeeAdaugaProdusNou()
        {
            HomeLoginPage loginPage = new HomeLoginPage(_driver);
            loginPage.AssertElementdisplayed(loginPage.AdaugaProdusButton);
        }

        [When(@"I click adauga produs")]
        public void WhenIClickAdaugaProdus()
        {
            HomeLoginPage loginPage = new HomeLoginPage(_driver);
            loginPage.AdaugaProdusButton.Click();
        }

        [Then(@"I see adauga produsul button")]
        public void ThenISeeAdaugaProdusulButton()
        {
            HomeLoginPage loginPage = new HomeLoginPage(_driver);
            loginPage.AssertElementdisplayed(loginPage.AdaugaProdButton);
        }
        [When(@"I click cos")]
        public void WhenIClickCos()
        {
            HomeLoginPage loginPage = new HomeLoginPage(_driver);
            loginPage.CosButton.Click();
        }

        [Then(@"I see comanda acum button")]
        public void ThenISeeComandaAcumButton()
        {
            HomeLoginPage loginPage = new HomeLoginPage(_driver);
            loginPage.AssertElementdisplayed(loginPage.ComandaAcumButton);
        }
        [When(@"I click deconectare button")]
        public void WhenIClickDeconectareButton()
        {
            HomeLoginPage loginPage = new HomeLoginPage(_driver);
            loginPage.DeconectareButton.Click();
        }

        [Then(@"I see autentificare on home page")]
        public void ThenISeeAutentificareOnHomePage()
        {
            HomePage homePage = new HomePage(_driver);
            Assert.IsTrue(homePage.AutentificareButton.Displayed);
        }




    }
}
