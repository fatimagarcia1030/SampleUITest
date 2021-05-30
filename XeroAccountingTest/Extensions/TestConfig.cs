using System;
using System.Configuration;
using System.IO;

namespace XeroAccountingTest.Extensions
{
    public class TestConfig
    {
        private static string _loginPage;
        private static string _webDriversPath;
        private static string _driver;
        private static string _emailAddress;
        private static string _password;
        private static string _pet;
        private static string _job;
        private static string _car;
        private static string _accountName;
        private static string _accountNumber;

        public static string LoginPage
        {
            get
            {
                _loginPage = ConfigurationManager.AppSettings["LoginPage"];
                return _loginPage;
            }
        }

        public static string EmailAddress
        {
            get 
            {
                _emailAddress = ConfigurationManager.AppSettings["EmailAddress"];
                return _emailAddress;
            }
        }

        public static string Password
        {
            get
            {
                _password = ConfigurationManager.AppSettings["Password"];
                return _password;
            }
        }

        public static string Job
        {
            get
            {
                _job = ConfigurationManager.AppSettings["DreamJob"];
                return _job;
            }
        }

        public static string Pet
        {
            get
            {
                _pet = ConfigurationManager.AppSettings["Pet"];
                return _pet;
            }
        }

        public static string Car
        {
            get
            {
                _car = ConfigurationManager.AppSettings["Car"];
                return _car;
            }
        }
        public static string AccountName
        {
            get
            {
                _accountName = ConfigurationManager.AppSettings["AccountName"];
                return _accountName;
            }
        }

        public static string AccountNumber
        {
            get 
            {
                _accountNumber = ConfigurationManager.AppSettings["AccountNumber"];
                return _accountNumber;
            }
        }

        public static string Driver
        {
            get
            {
                _driver = GetDriverType();
                return _driver;
            }
        }

        public static string WebDriversPath
        {
            get
            {
                _webDriversPath = GetWebDriversPath();
                return _webDriversPath;
            }
        }

        public static string GetDriverType()
        {
            string driver = "chrome";
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["Driver"]))
                driver = ConfigurationManager.AppSettings["Driver"];
            return driver;
        }

        public static string GetWebDriversPath()
        {
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["WebDriversPath"]))
                return ConfigurationManager.AppSettings["WebDriversPath"];
            string baseDirectory = (new FileInfo(AppDomain.CurrentDomain.BaseDirectory)).Directory.Parent.FullName;
            return Path.GetFullPath(string.Format("{0}\\..\\WebDrivers", baseDirectory));
        }
    }
}
