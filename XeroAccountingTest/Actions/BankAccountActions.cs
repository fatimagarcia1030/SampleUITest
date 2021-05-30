using System.Threading;
using XeroAccountingTest.Extensions;
using XeroAccountingTest.PageModels;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace XeroAccountingTest.Actions
{
    public class BankAccountActions
    {
        private static IWebDriver _driver;
        private static BankAccountsPage _bankAccountsPage;
        private static ActionsExtension _actionsExtensions;

        private static string _businessName;
        private static string _accountNumber;

        public BankAccountActions(IWebDriver driver)
        {
            _driver = driver;
            _bankAccountsPage = new BankAccountsPage(_driver);
            _actionsExtensions = new ActionsExtension(_driver);
        }

        public void GenerateDetails()
        {
            _businessName = _actionsExtensions.BusinessNameGenerator();
            _accountNumber = _actionsExtensions.AccountNumberGenerator();
        }

        public void ClickAddBankAccount()
        {
            _driver.WaitUntilDocumentIsReady(60);
            _driver.WaitUntilVisible(_bankAccountsPage.AddBankAccountButon, 30);
            _bankAccountsPage.AddBankAccountButon.Click();
            Thread.Sleep(3000);
        }

        public void SelectANZ()
        {
            _driver.WaitUntilDocumentIsReady(60);
            _driver.WaitUntilVisible(_bankAccountsPage.AddBankAccountsHeader, 30);
            _bankAccountsPage.ANZOption.Click();
            Thread.Sleep(3000);
        }

        public void EnterBusinessName()
        {
            _bankAccountsPage.BusinessNameField.SendKeys(_businessName);
            Thread.Sleep(3000);
            
        }

        public void SelectAccountType()
        {
            _bankAccountsPage.SelectAccountType.Click();
            Thread.Sleep(3000);
            _bankAccountsPage.EverydayAccount.Click();
            Thread.Sleep(3000);
        }

        public void EnterAccountNumber()
        {
            _bankAccountsPage.AccountNumber.SendKeys(_accountNumber);
            Thread.Sleep(3000);
        }

        public void ClickContinue()
        {
            _bankAccountsPage.ContinueButton.Click();
            Thread.Sleep(3000);
        }

        public void AssertBankDetailsAdded()
        {
            _driver.WaitUntilDocumentIsReady(60);
            _driver.WaitUntilVisible(_bankAccountsPage.AddBankAccountButon, 30);
            Assert.IsTrue(_bankAccountsPage.ConfirmationBanner.Displayed);
            Assert.IsTrue(_bankAccountsPage.ConfirmationBanner.Text.Equals(_businessName+ " has been added."));
        }

        public void AssertBankDetailsDisplayed()
        {
            _driver.ScrollTo(_bankAccountsPage.BankAccountName(_accountNumber));
            Thread.Sleep(3000);
            Assert.IsTrue(_bankAccountsPage.BankAccountName(_accountNumber).Displayed);
            Assert.IsTrue(_bankAccountsPage.BankAccountNumber(_accountNumber).Displayed);
        }
    }
}
