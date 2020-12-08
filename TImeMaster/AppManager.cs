using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TImeMaster.Helpers;

namespace TImeMaster
{
    public class AppManager
    {
        private static ThreadLocal<AppManager> app = new ThreadLocal<AppManager>();

        private NavigationHelper navigation;
        private LoginHelper auth;
        private GroupHelper group;

        public IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;

        public AppManager()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
            group = new GroupHelper(this);
            auth = new LoginHelper(this);
            navigation = new NavigationHelper(this);
        }
        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }
        public NavigationHelper Navigation
        {
            get
            {
                return navigation;
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return auth;
            }
        }
        public GroupHelper Group
        {
            get
            {
                return group;
            }
        }

        public void Stop()
        {
            driver.Quit();
        }


    }
}
