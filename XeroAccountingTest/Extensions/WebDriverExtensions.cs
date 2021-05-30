using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace XeroAccountingTest.Extensions
{
    public static class WebDriverExtensions
    {
        public static void NavigateToLoginPage(this IWebDriver webDriver)
        {
            webDriver.Navigate().GoToUrl(TestConfig.LoginPage);
            WaitUntilDocumentIsReady(webDriver, 60);
            webDriver.Manage().Window.Maximize();
        }

        public static void WaitUntilDocumentIsReady(this IWebDriver webDriver, int waitTime)
        {
            IWait<IWebDriver> _wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(waitTime));
            _wait.Until(driver1 => ((IJavaScriptExecutor)webDriver).ExecuteScript("return document.readyState").Equals("complete"));
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(waitTime);
        }

        public static void ScrollTo(this IWebDriver driver, IWebElement element)
        {
            var _element = element;
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", _element);
        }

        public static IWebElement WaitUntilVisible(this IWebDriver webDriver, IWebElement waitElement, int waitTime)
        {

            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, waitTime));
            var element = wait.Until<IWebElement>(wbd =>
            {
                try
                {
                    var elementToBeDisplayed = waitElement;
                    if (elementToBeDisplayed.Displayed)
                    {
                        return elementToBeDisplayed;
                    }
                    return null;
                }
                catch (StaleElementReferenceException)
                {
                    return null;
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            });
            return element;
        }

    }
}
