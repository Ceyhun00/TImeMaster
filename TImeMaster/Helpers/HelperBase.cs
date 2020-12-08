using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TImeMaster.Helpers
{
    public class HelperBase
    {

        public IWebDriver driver;
        protected AppManager manager;
        public HelperBase(AppManager manager)
        {
            this.manager = manager;
            this.driver = manager.driver;
        }
    }
}
