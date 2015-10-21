using NUnit.Framework;
using System;
using UnitTestProject1.Pages;

namespace UnitTestProject1.Helpers
{
    class SignInHelper
    {

        public static void SignIn(String login, String password)
        {
            Console.WriteLine("Signing in using creds:["+login+"|"+password+"].");
            HeaderComponent.GetHeaderInstance.ClickSignInLink();
            SignInPage.GetSignInPage.InsertLogin(login);
            SignInPage.GetSignInPage.InsertPassword(password);
            SignInPage.GetSignInPage.ClickSignInButton();
        }

        public static void CheckErrorMessageDisplayed() {
          
            Console.WriteLine("Checking if error message is present");
            Assert.IsTrue(SignInPage.GetSignInPage.GetErrorMsg().Displayed);
            Console.WriteLine("Error message is present");
        }
        public static void CheckSuccessfulSignIn()
        {
            Console.WriteLine("Checking if user is successfully authorized.");
            Assert.IsTrue(HeaderComponent.GetHeaderInstance.GetSignOutLink().Displayed);
            Console.WriteLine("User is successfully authorized.");

        }
    }
}
