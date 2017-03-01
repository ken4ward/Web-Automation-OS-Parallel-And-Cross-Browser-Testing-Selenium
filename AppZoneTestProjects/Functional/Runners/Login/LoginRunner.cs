using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Remote;
using AppZoneTestProjects.Functional.Suits.Login;
using AppZoneTestProjects.Functional.Suits.SystemAdmin.Users;
using AppZoneTestProjects.Functional.Constants.Login;
using AppZoneTestProjects.Functional.Utils.Login;
using AppZoneTestProjects.Functional.Reusables.Login;
using AppZoneTestProjects.Functional.Suits.SystemAdmin;
using AppZoneTestProjects.Functional.Constants.Interface.SystemAdmin;
using AppZoneTestProjects.Functional.Suits.SystemAdmin.Group;
using System.Collections;
using NUnit.Framework;
using System.Drawing;

namespace AppZoneTestProjects.Functional.Runners.Login
{
    [TestClass]
    public class LoginRunner
    {
        IWebDriver driver;
        private static String SeleniumHubURL;
        private static String TargetServerURL;
       
        public LoginRunner()
        {
            SeleniumHubURL = GetConfigurationProperty("SeleniumHubURL", TradeportMultiBrowserURLs.SeleniumHubURL);
            TargetServerURL = GetConfigurationProperty("TargetServerURL", TradeportMultiBrowserURLs.TargetServerURL);
            LoginValidations.WaitTime();
        }

        private static String GetConfigurationProperty(String environmentKey, String defaultValue)
        {
            String returnValue = defaultValue;
            String environmentValue = System.Environment.GetEnvironmentVariable(environmentKey);

            if (environmentValue != null)
            {
                returnValue = environmentValue;
            }
            return returnValue;
        }

        [TestMethod]
        public void TestChrome()
        {
            DesiredCapabilities browser = DesiredCapabilities.Chrome();
            DesiredCapabilityBrowser(browser);
        }
        [TestMethod]
        public void TestSafari()
        {
            DesiredCapabilities browser = DesiredCapabilities.Safari();
            DesiredCapabilityBrowser(browser);
        }
        [TestMethod]
        public void TestFirefox()
        {
            DesiredCapabilities browser = DesiredCapabilities.Firefox();
            DesiredCapabilityBrowser(browser);
        }

        [TestMethod]
        public void TestInternetExplorer()
        {
            DesiredCapabilities browser = DesiredCapabilities.InternetExplorer();
            browser.SetCapability("ignoreZoomSetting", true);
            browser.SetCapability("nativeEvents", false);
            DesiredCapabilityBrowser(browser);
        }
        [Test]
        public void TestOpera()
        {
            DesiredCapabilities browser = DesiredCapabilities.Opera();
            DesiredCapabilityBrowser(browser);
        }

        public void DesiredCapabilityBrowser(DesiredCapabilities browser)
        {
            try
            {
                driver = new RemoteWebDriver(new Uri(SeleniumHubURL), browser);
                driver.Navigate().GoToUrl(TargetServerURL);
                //ITakesScreenshot(driver, @"C:\Users\ken4ward\Desktop\Tidy\Screenshot");
                LoginValidations.WaitTime();
                //This is the login test suite
               // new LoginSuites(driver).DejavuSuiteForLogin();
                new UserSuites(driver).UserSuitesRunAll();
                //new UserSuites(driver).SearchUserObject();
               // new SearchUsers(driver).LoginUSerPage();
               // new SearchUsers(driver).SearchUsersGlobal();
                //new GroupSuites(driver).RunAllGroupTestCases();
                //new GroupSuites(driver).RunAllGroupSearch();
            }

            catch (Exception e)
            {
                e.Message.ToString();
            }
            finally
            {
                if (driver != null)
                {
                    // driver.Close();
                }
            }
        }

        private void ITakesScreenshot(IWebDriver driver, string saveLocation)
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(saveLocation, System.Drawing.Imaging.ImageFormat.Png);
        }

      /*  public Screenshot GetScreenshot()
        {
            Response screenshotResponse = this.Execute(DriverCommand.Screenshot, null);
            string base64 = screenshotResponse.Value.ToString();

            return new Screenshot(base64);
        }*/
    }
}
