using System.Threading;
using XeroAccountingTest.Extensions;
using XeroAccountingTest.PageModels;
using OpenQA.Selenium;

namespace XeroAccountingTest.Actions
{
    public class AuthenticationActions
    {
        private IWebDriver _driver;
        private AuthenticationQuestionsPage _authenticationPage;
        private ActionsExtension _securityAnswer;

        public AuthenticationActions(IWebDriver driver)
        {
            _driver = driver;
            _authenticationPage = new AuthenticationQuestionsPage(_driver);
            _securityAnswer = new ActionsExtension(_driver);
        }

        public void AnswerAuthenticationQuestions()
        {
            _driver.WaitUntilDocumentIsReady(60);
            _driver.WaitUntilVisible(_authenticationPage.SecurityQuestionsLink, 30);
            _authenticationPage.SecurityQuestionsLink.Click();
            Thread.Sleep(3000);

            _securityAnswer.AnswerSecurityQuestions();
        }

        public void ClickConfirmButton()
        {
            _authenticationPage.ConfirmButton.Click();
            Thread.Sleep(3000);
        }
    }
}
