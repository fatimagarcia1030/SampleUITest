using OpenQA.Selenium;

namespace XeroAccountingTest.PageModels
{
    public class DashboardPage
    {
        private static IWebDriver Driver;
        private static IWebElement _elementName;

        public DashboardPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement OrganisationLabel
        {
            get
            {
                _elementName = Driver.FindElement(By.XPath("//span[@class='xnav-appbutton--text']"));
                return _elementName;
            }
        }

        public IWebElement AccountingLink
        {
            get
            {
                _elementName = Driver.FindElement(By.XPath("//button[@data-event-action='Clicked NAVIGATION: accounting']"));
                return _elementName;
            }
        }

        public IWebElement BankAccountsLink
        {
            get
            {
                _elementName = Driver.FindElement(By.XPath("//a[@data-event-action='Clicked NAVIGATION_SUBMENU: bank-accounts']"));
                return _elementName;
            }
        }

        public IWebElement MyXeroLink
        {
            get
            {
                _elementName = Driver.FindElement(By.XPath("//span[text()='My Xero']"));
                return _elementName;
            }
        }

        public IWebElement DemoCompanyLink
        {
            get
            {
                _elementName = Driver.FindElement(By.XPath("//a[@data-event-action='Clicked DEMO_ORG']"));
                return _elementName;
            }
        }

    }
}
