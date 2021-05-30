using System.Threading;
using XeroAccountingTest.Extensions;
using XeroAccountingTest.PageModels;
using OpenQA.Selenium;

namespace XeroAccountingTest.Actions
{
    public class DashboardActions
    {
        private static IWebDriver _driver;
        private static DashboardPage _dashboardPage;
        private static ActionsExtension _actionsExtensions;

        public DashboardActions(IWebDriver driver)
        {
            _driver = driver;
            _dashboardPage = new DashboardPage(_driver);
            _actionsExtensions = new ActionsExtension(_driver);
        }

        public void NavigateToCompanyDashboard()
        {
            _driver.WaitUntilDocumentIsReady(60);
            _driver.WaitUntilVisible(_dashboardPage.OrganisationLabel, 30);
            _actionsExtensions.NavigateToDemoCompany();
        }

        public void ClickAccountingLink()
        {
            _driver.WaitUntilDocumentIsReady(60);
            _driver.WaitUntilVisible(_dashboardPage.OrganisationLabel, 30);
            _dashboardPage.AccountingLink.Click();
            Thread.Sleep(3000);
        }

        public void ClickBankAccountsLink()
        {
            _driver.WaitUntilVisible(_dashboardPage.BankAccountsLink, 30);
            _dashboardPage.BankAccountsLink.Click();
            Thread.Sleep(3000);
        }
    }
}
