using NUnit.Framework;
using UnitTestProject1.Helpers;
using System.Configuration;

namespace UnitTestProject1
{
    public class UnitTest1 : BaseTest
    {

        [Test]
        public void ValidCredsLogin()
        {
            SignInHelper.SignIn(ConfigurationManager.AppSettings["ValidLogin"],
                ConfigurationManager.AppSettings["ValidPassword"]);
            SignInHelper.CheckSuccessfulSignIn();
        }

        [Test]
        public void InvalidCredsLogin()
        {
            SignInHelper.SignIn(ConfigurationManager.AppSettings["InvalidLogin"],
                ConfigurationManager.AppSettings["InvalidPassword"]);
            SignInHelper.CheckErrorMessageDisplayed();

        }

        [Test]
        public void NoUsernameLogin()
        {
            SignInHelper.SignIn("",
                ConfigurationManager.AppSettings["InvalidPassword"]);
            SignInHelper.CheckErrorMessageDisplayed();

        }

        [Test]
        public void NoPasswordLogin()
        {
            SignInHelper.SignIn(ConfigurationManager.AppSettings["InvalidLogin"],
                "");
            SignInHelper.CheckErrorMessageDisplayed();

        }
    }
}
