using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TImeMaster
{
    public class TestBase
    {
        public IWebDriver driver;
        protected AppManager app;

        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            app = new AppManager();
            
        }


        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
    }
}
