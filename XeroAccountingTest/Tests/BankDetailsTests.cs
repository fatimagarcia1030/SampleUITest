using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using XeroAccountingTest.Extensions;
using XeroAccountingTest.Actions;

namespace XeroAccountingTest.Tests
{
    [TestClass]
    public class BankDetailsTest
    {
        private IWebDriver _driver;
        private LoginActions loginActions;
        private AuthenticationActions authenticationActions;
        private DashboardActions dashboardActions;
        private BankAccountActions bankAccountActions;

        [TestInitialize]
        public void RunBeforeScenario()
        {
            _driver = WebDriverManager.Current.GetDefaultWebDriver();
            loginActions = new LoginActions(_driver);
            authenticationActions = new AuthenticationActions(_driver);
            dashboardActions = new DashboardActions(_driver);
            bankAccountActions = new BankAccountActions(_driver);
        }

        [TestCleanup]
        public void RunAfterScenario()
        {
            _driver.Close();
            _driver.Quit();
        }

        //As a Xero User,
        //In order to manage my business successfully,
        //I want to be able to add an “ANZ(NZ)” bank account inside any Xero Organisation
        [TestMethod]
        public void AddBankDetails()
        {
            loginActions.LoginToDashboard();
            loginActions.ClickAuthenticationLink();
            authenticationActions.AnswerAuthenticationQuestions();
            authenticationActions.ClickConfirmButton();

            dashboardActions.NavigateToCompanyDashboard();
            dashboardActions.ClickAccountingLink();
            dashboardActions.ClickBankAccountsLink();

            bankAccountActions.ClickAddBankAccount();
            bankAccountActions.SelectANZ();
            bankAccountActions.GenerateDetails();
            bankAccountActions.EnterBusinessName();
            bankAccountActions.SelectAccountType();
            bankAccountActions.EnterAccountNumber();
            bankAccountActions.ClickContinue();

            bankAccountActions.AssertBankDetailsAdded();
            bankAccountActions.AssertBankDetailsDisplayed();
        }
    }
}