using OpenQA.Selenium;

namespace XeroAccountingTest.PageModels
{
    public class AuthenticationQuestionsPage
    {
        private static IWebDriver Driver;
        private static IWebElement _elementName;

        public AuthenticationQuestionsPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement SecurityQuestionsLink
        {
            get
            {
                _elementName = Driver.FindElement(By.XPath("//button[@data-automationid='auth-authwithsecurityquestionsbutton']"));
                return _elementName;
            }
        }

        public IWebElement FirstQuestion
        {
            get
            {
                _elementName = Driver.FindElement(By.XPath("//label[@data-automationid='auth-firstanswer--label']"));
                return _elementName;
            }
        }

        public IWebElement SecondQuestion
        {
            get
            {
                _elementName = Driver.FindElement(By.XPath("//label[@data-automationid='auth-secondanswer--label']"));
                return _elementName;
            }
        }

        public IWebElement FirstAnswer
        {
            get
            {
                _elementName = Driver.FindElement(By.XPath("//input[@data-automationid='auth-firstanswer--input']"));
                return _elementName;
            }
        }

        public IWebElement SecondAnswer
        {
            get
            {
                _elementName = Driver.FindElement(By.XPath("//input[@data-automationid='auth-secondanswer--input']"));
                return _elementName;
            }
        }

        public IWebElement ConfirmButton
        {
            get
            {
                _elementName = Driver.FindElement(By.XPath("//button[@data-automationid='auth-submitanswersbutton']"));
                return _elementName;
            }
        }

    }
}
