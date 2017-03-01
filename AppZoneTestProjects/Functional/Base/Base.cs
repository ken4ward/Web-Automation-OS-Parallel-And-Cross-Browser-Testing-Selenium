using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using AppZoneTestProjects.Functional.Utils.Login;
using AppZoneTestProjects.Functional.Constants.Login;
using AppZoneTestProjects.Functional.Constants.Interface.SystemAdmin;
using AppZoneTestProjects.Functional.Utils.Interface.SystemAdmin;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.PhantomJS;
namespace AppZoneTestProjects.Functional.Base
{
    public class Base
    {
        public IWebDriver driver;
        //public PhantomJSDriver driver;
        public static String RegistrationFailedPanels = UserValidations.RegistrationFailedPanels;
        public static String CloseFailedPanel         = UserValidations.CloseFailedPanel;
        public static String dest;
        static int count = 0;

        //Global variables
        public static String[] ParamObjects = new String[]{"", ""};
        public static String[] ParamValues;

        public Base() { }
        public Base(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void LoginFailed(String InputConstant, String FailedLogin)
        {
            new LoginValidations(driver).WaitForATime(InputConstant);
            driver.FindElement(By.CssSelector(FailedLogin)).Click();
        }

        public void UserRegisrationFailed(String InputConstant, String CancelButton)
        {
            ++count;
            InputConstant = RegistrationFailedPanels.Substring(0, RegistrationFailedPanels.Trim().Length - 1);
            CancelButton = CloseFailedPanel.Substring(0, CloseFailedPanel.Trim().Length - 1);
            new LoginValidations(driver).WaitForATime(InputConstant + count);
            driver.FindElement(By.CssSelector(CancelButton + count)).Click();
        }

        public void ReusableGlobalSearch()
        {
            for (int i = 0; i < ParamObjects.Length; i++)
            {
                driver.FindElement(By.CssSelector(ParamObjects[i])).SendKeys(ParamValues[i]);
                driver.FindElement(By.CssSelector(UserConstants.SearchUser)).Click();
                System.Threading.Thread.Sleep(500);
                // new UserValidate(driver).ListViewContainsText(driver, ParamValues[i]);
                // System.Threading.Thread.Sleep(500);
                driver.FindElement(By.Id(UserConstants.UserReset)).Click();
                new UserValidate(driver).WaitPageLoad(ParamObjects[i]);
            }
        }

        public void DropDownElements(String PassConstant, int Compare, String PassConstantText)
        {
            IList<IWebElement> DropDownPath = driver.FindElements(By.CssSelector(PassConstant));
            for (int i = 0; i < DropDownPath.Count; ++i )
            {
                if (DropDownPath.Count == Compare)
                {
                    new UserValidate(driver).WaitElementVisible(DropDownPath[i].ToString());
                    driver.FindElement(By.CssSelector(DropDownPath[i].ToString())).Click();
                    IWebElement ele =  driver.FindElement(By.CssSelector("#s2id_autogen3_search"));
                    SelectElement DropDown = new SelectElement(ele);
                    DropDown.SelectByText(PassConstantText);
                }
            } 
        }
    }
}
