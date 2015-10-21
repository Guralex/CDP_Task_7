using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Core;
using UnitTestProject1.Pages;

[TestFixture]
public abstract class BaseTest
{

    [TestFixtureSetUp]
    public static void Init()
    {
        Driver.GetDriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
        Driver.GetDriverInstance.Manage().Window.Maximize();
    }

    [TestFixtureTearDown]
    public static void Close()
    {
        Driver.Close();
    }

    [SetUp]
    public void OpenBasePage()
    {
        Driver.GetDriverInstance.Navigate().GoToUrl(ConfigurationManager.AppSettings["HomePageUrl"]);
    }


    [TearDown]
    public void CleanUp()
    {
        Driver.GetDriverInstance.Manage().Cookies.DeleteAllCookies();
    }
}