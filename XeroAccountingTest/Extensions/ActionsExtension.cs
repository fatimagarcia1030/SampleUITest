using XeroAccountingTest.PageModels;
using OpenQA.Selenium;
using System.Threading;
using System;

namespace XeroAccountingTest.Extensions
{
    public class ActionsExtension
    {
        private static IWebDriver _driver;
        private static AuthenticationQuestionsPage _authenticationPage;
        private static DashboardPage _dashboard;

        private static string businessName;
        private static string accountNumber;
        private static int randomNum;

        public ActionsExtension(IWebDriver driver)
        {
            _driver = driver;
            _authenticationPage = new AuthenticationQuestionsPage(_driver);
            _dashboard = new DashboardPage(_driver);
        }

        public void NavigateToDemoCompany()
        {
            if (_dashboard.OrganisationLabel.Text != "Demo Company (NZ)")
            {
                _driver.WaitUntilVisible(_dashboard.MyXeroLink, 30);
                _dashboard.MyXeroLink.Click();
                _driver.WaitUntilVisible(_dashboard.DemoCompanyLink, 30);
                _dashboard.DemoCompanyLink.Click();
                Thread.Sleep(3000);
            }
            else
            {
                Thread.Sleep(3000);
            }
            
        }

        public void AnswerSecurityQuestions()
        {
            _authenticationPage.FirstAnswer.SendKeys(GetAnswerQuestion(_authenticationPage.FirstQuestion.Text));
            _authenticationPage.SecondAnswer.SendKeys(GetAnswerQuestion(_authenticationPage.SecondQuestion.Text));
        }

        private string GetAnswerQuestion(string _question)
        {
            string _answer;

            if (_question.Contains("car"))
            {
                _answer = TestConfig.Car;
            }
            else if (_question.Contains("job"))
            {
                _answer = TestConfig.Job;
            }
            else if (_question.Contains("pet"))
            {
                _answer = TestConfig.Pet;
            }
            else
            {
                return ("error");
            }

            return _answer;
        }

        public string BusinessNameGenerator()
        {
            Random numberRand = new Random();
             randomNum = numberRand.Next(10, 100);

            businessName = TestConfig.AccountName + randomNum.ToString();
            return businessName;
        }

        public string AccountNumberGenerator()
        {
            Random numberRand = new Random();
            randomNum = numberRand.Next(10, 100);

            accountNumber = TestConfig.AccountNumber + randomNum.ToString();
            return accountNumber;
        }
    }
}
