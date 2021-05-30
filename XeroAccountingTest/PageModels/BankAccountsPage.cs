using OpenQA.Selenium;

namespace XeroAccountingTest.PageModels
{
    public class BankAccountsPage
    {
        private static IWebDriver Driver;
        private static IWebElement _elementName;

        public BankAccountsPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement AddBankAccountButon
        {
            get
            {
                _elementName = Driver.FindElement(By.XPath("//a[@href='/Banking/Account/#find']"));
                return _elementName;
            }
        }

        public IWebElement AddBankAccountsHeader
        {
            get 
            {
                _elementName = Driver.FindElement(By.XPath("//h1[text()='Add Bank Accounts']"));
                return _elementName;
            }
        }

        public IWebElement ANZOption
        {
            get
            {
                _elementName = Driver.FindElement(By.XPath("//li[text()='ANZ (NZ)']"));
                return _elementName;
            }
        }

        public IWebElement BusinessNameField
        {
            get 
            {
                _elementName = Driver.FindElement(By.Id("accountname-1037-inputEl"));
                return _elementName;
            }
        }

        public IWebElement SelectAccountType
        {
            get
            {
                _elementName = Driver.FindElement(By.Id("accounttype-1039-inputEl"));
                return _elementName;
            }
        }

        public IWebElement EverydayAccount
        {
            get
            {
                _elementName = Driver.FindElement(By.XPath("//li[text()='Everyday (day-to-day)']"));
                return _elementName;
            }
        }

        public IWebElement AccountNumber
        {
            get
            {
                _elementName = Driver.FindElement(By.Id("accountnumber-1068-inputEl"));
                return _elementName;
            }
        }

        public IWebElement ContinueButton
        {
            get 
            {
                _elementName = Driver.FindElement(By.Id("common-button-submit-1015-btnInnerEl"));
                return _elementName;
            }
        }

        public IWebElement ConfirmationBanner
        {
            get
            {
                _elementName = Driver.FindElement(By.XPath("//div[@id='notify01']//div[@class='message']/p"));
                return _elementName;
            }
        }

        public IWebElement BankAccountName(string name)
        {
                _elementName = Driver.FindElement(By.XPath("//*[text()='"+name+"']"));
                return _elementName;
        }

        public IWebElement BankAccountNumber(string accountnumber)
        {
            _elementName = Driver.FindElement(By.XPath("//*[text()='" + accountnumber + "']"));
            return _elementName;
        }
    }
}
