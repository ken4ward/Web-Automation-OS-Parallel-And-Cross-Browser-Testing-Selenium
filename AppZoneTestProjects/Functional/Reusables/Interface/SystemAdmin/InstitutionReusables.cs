using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using AppZoneTestProjects.Functional.Base;
using AppZoneTestProjects.Functional.Constants.Interface.SystemAdmin;
namespace AppZoneTestProjects.Functional.Reusables.Interface.SystemAdmin
{
    public class InstitutionReusables : Base.Base
    {
        public InstitutionReusables() { }
        public InstitutionReusables(IWebDriver driver) : base(driver) { }

        public void InstitutionReusablesMethod(String InstitutionName, String InstitutionAddress, String InstitutionEmail, String InstitutionPhone, String InstitutionShortName, String InstitutionSlogan,
            String InstitutionHQName, String InstitutionHQLocation, String InstituteAdminFirstName, String InstituteAdminLastName, String InstituteAdminContactPhone, String InstituteAdminContactEmail)
        {
            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionName)).Clear();
            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionName)).SendKeys(InstitutionName);
            
            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionAddress)).Clear();
            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionAddress)).SendKeys(InstitutionName);

            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionEmail)).Clear();
            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionEmail)).SendKeys(InstitutionEmail);
            
            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionPhone)).Clear();
            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionPhone)).SendKeys(InstitutionPhone);

            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionSlogan)).Clear();
            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionSlogan)).SendKeys(InstitutionSlogan);

            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionShortName)).Clear();
            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionShortName)).SendKeys(InstitutionShortName);

            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionHQName)).Clear();
            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionHQName)).SendKeys(InstitutionHQName);
            
            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionHQLocation)).Clear();
            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionHQLocation)).SendKeys(InstitutionHQLocation);

            driver.FindElement(By.CssSelector(InstitutionConstants.InstituteAdminFirstName)).Clear();
            driver.FindElement(By.CssSelector(InstitutionConstants.InstituteAdminFirstName)).SendKeys(InstituteAdminFirstName);

            driver.FindElement(By.CssSelector(InstitutionConstants.InstituteAdminLastName)).Clear();
            driver.FindElement(By.CssSelector(InstitutionConstants.InstituteAdminLastName)).SendKeys(InstituteAdminLastName);

            driver.FindElement(By.CssSelector(InstitutionConstants.InstituteAdminContactPhone)).Clear();
            driver.FindElement(By.CssSelector(InstitutionConstants.InstituteAdminContactPhone)).SendKeys(InstituteAdminContactPhone);

            driver.FindElement(By.CssSelector(InstitutionConstants.InstituteAdminContactEmail)).Clear();
            driver.FindElement(By.CssSelector(InstitutionConstants.InstituteAdminContactEmail)).SendKeys(InstituteAdminContactEmail);

            driver.FindElement(By.CssSelector(InstitutionConstants.InstitutionSave)).Click();
        }
    }
}
