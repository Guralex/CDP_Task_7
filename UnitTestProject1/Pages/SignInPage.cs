using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using UnitTestProject1.Core;

namespace UnitTestProject1.Pages
{
    class SignInPage
    {
        [FindsBy(How = How.XPath, Using = "//input[@class='fm-sign-in-form__input-text' and @type='text']")]
        private IWebElement loginField;

        [FindsBy(How = How.XPath, Using = "//input[@class='fm-sign-in-form__input-text' and @type='password']")]
        private IWebElement passwordField;

        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'submit button')]")]
        private IWebElement signInButton;

        [FindsBy(How = How.XPath, Using = " //div[@class='error']")]
        private IWebElement loginFailedError;
       
        private SignInPage()
        {
            PageFactory.InitElements(Driver.GetDriverInstance, this);
        }

        public static SignInPage GetSignInPage
        {
            get
            {
                return new SignInPage();
            }
        }

        public void InsertLogin(String login) {

            Console.WriteLine("Inserting text into Login field");
            loginField.SendKeys(login);
        }

        public void InsertPassword(String pass)
        {
            Console.WriteLine("Inserting text into Password field");
            passwordField.SendKeys(pass);
        }

        public void ClickSignInButton() {
            Console.WriteLine("Clicking Sign In Button");
            signInButton.Click();
        }
        public IWebElement GetErrorMsg() {

            return loginFailedError;
        }
    }
}
