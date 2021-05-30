using System.Threading;
using XeroAccountingTest.Extensions;
using XeroAccountingTest.PageModels;
using OpenQA.Selenium;

namespace XeroAccountingTest.Actions
{
    public class LoginActions
    {
        private static IWebDriver _driver;
        private static LoginPage _loginPage;     

        public LoginActions(IWebDriver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver);
        }

        public void LoginToDashboard()
        {
            _driver.NavigateToLoginPage();
            _driver.WaitUntilDocumentIsReady(60);

            _driver.WaitUntilVisible(_loginPage.EmailAddressField, 30);
            _loginPage.EmailAddressField.SendKeys(TestConfig.EmailAddress);
            _loginPage.PasswordField.SendKeys(TestConfig.Password);
            _loginPage.LoginButton.Click();
            Thread.Sleep(3000);
        }

        public void ClickAuthenticationLink()
        {
            _driver.WaitUntilDocumentIsReady(60);
            _driver.WaitUntilVisible(_loginPage.OtherAuthenticationLink, 30);
            _driver.ScrollTo(_loginPage.OtherAuthenticationLink);
            _loginPage.OtherAuthenticationLink.Click();
            Thread.Sleep(3000);
        }
    }
}
