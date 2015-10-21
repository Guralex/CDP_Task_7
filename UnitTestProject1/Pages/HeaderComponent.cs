using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Core;

namespace UnitTestProject1.Pages
{
    class HeaderComponent
    {

        [FindsBy(How = How.XPath, Using = "//a[@class='accountnav_firstlink header__account-nav-link sign-in web-analytics-custom-link']")]
        private IWebElement signInLink;

        [FindsBy(How = How.XPath, Using = "//a[@class='accountnav_firstlink header__account-nav-link sign-in web-analytics-custom-link']")]
        private IWebElement signOutlink;

        private HeaderComponent()
        {
            PageFactory.InitElements(Driver.GetDriverInstance, this);
        }

        public static HeaderComponent GetHeaderInstance
        {
            get
            {
                return new HeaderComponent();
            }
        }

        public void ClickSignInLink()
        {
            Console.WriteLine("Clicking 'Sign In' link.");
            signInLink.Click();

        }

        public IWebElement GetSignOutLink()
        {
            return signOutlink;
        }
    }
}
