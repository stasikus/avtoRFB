using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace avtoRFB
{
    class Driver
    {
        public static IWebDriverExt Instance { get; private set; }

        public static void Initialize()
        {
            if (Instance == null)
            {
                var firingDriver = new FirefoxDriverExt();
                Instance = firingDriver;
                Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
            }
        }

        public static void Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }
    }
}