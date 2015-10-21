using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace UnitTestProject1.Core
{
    public class Driver
    {
        private static IWebDriver driverInstance;

         public static IWebDriver GetDriverInstance
        {
            get
            {
                if (driverInstance == null)
                {
                    var profile = new FirefoxProfile();
                    profile.EnableNativeEvents = false;
                    driverInstance = new FirefoxDriver(profile);
                }
                return driverInstance;
            }
        }

        public static void Close()
        {
            if (driverInstance != null)
            {
                driverInstance.Quit();
                driverInstance = null;
            }
        }

    }
}
