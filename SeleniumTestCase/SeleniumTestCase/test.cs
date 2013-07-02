using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace SeleniumTestCase
{
    public class TestClass
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
       // private const string IE_DRIVER_PATH = @"D:\selenium-dotnet-2.33.0";


        public void SetupTest()
        {

            var options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            //driver = new InternetExplorerDriver(IE_DRIVER_PATH, options);
            driver = new InternetExplorerDriver(options);

            baseURL = "http://qa.englishtown.com/partner/coolschool/Default.aspx";
            verificationErrors = new StringBuilder();
        }

        public void Steps()
        {
            driver.Navigate().GoToUrl(baseURL + "/partner/coolschool/Default.aspx");
            driver.FindElement(By.Id("txtName")).Clear();
            driver.FindElement(By.Id("txtName")).SendKeys("ct313");
            driver.FindElement(By.Id("txtPassWord")).Clear();
            driver.FindElement(By.Id("txtPassWord")).SendKeys("pass");
            driver.FindElement(By.Id("loginTrigger")).Click();
            System.Threading.Thread.Sleep(5000);
        }

        public bool Verify()
        {
            if (driver.FindElement(By.Id("MyCourseViewNew")).Displayed)
                return true;
            return false;
        }

        public void CleanUp()
        {
            
            driver.Close();
            driver.Quit();
        }
    }
}
