using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AppZoneTestProjects.Functional.Base;

namespace AppZoneTestProjects.Functional.Utils.Login
{
    public class LoginAssertions : Base.Base
    {
        public LoginAssertions() { }
        public LoginAssertions(IWebDriver driver) : base(driver) { }

    }
}
