using System;
using UnitTestProject1.Core;
using NUnit.Framework;
using UnitTestProject1.Pages;
using UnitTestProject1.Helpers;
using System.Configuration;

namespace UnitTestProject1
{
    public class UnitTest1 : BaseTest
    {

        [Test]
        public void InvalidCredsLogin()
        { 
            SignInHelper.SignIn(ConfigurationManager.AppSettings["InvalidLogin"],
            ConfigurationManager.AppSettings["InvalidPassword"]);
            SignInHelper.CheckErrorMessageDisplayed();

        }

        [Test]
        public void ValidCredsLogin()
        {
            SignInHelper.SignIn(ConfigurationManager.AppSettings["ValidLogin"],
            ConfigurationManager.AppSettings["ValidPassword"]);
            SignInHelper.CheckSuccessfulSignIn();
        }
    }
}
