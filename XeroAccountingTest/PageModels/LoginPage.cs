using OpenQA.Selenium;

namespace XeroAccountingTest.PageModels
{
    public class LoginPage
    {
        private static IWebDriver Driver;
        private static IWebElement _elementName;
     
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement EmailAddressField
        {
            get
            {
                _elementName = Driver.FindElement(By.Id("xl-form-email"));
                return _elementName;
            }
        }

        public IWebElement PasswordField
        {
            get
            {
                _elementName = Driver.FindElement(By.Id("xl-form-password"));
                return _elementName;
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                _elementName = Driver.FindElement(By.Id("xl-form-submit"));
                return _elementName;
            }
        }

        public IWebElement OtherAuthenticationLink
        {
            get
            {
                _elementName = Driver.FindElement(By.XPath("//button[@data-automationid='auth-continuebutton']"));
                return _elementName;
            }
        }
    }
}
