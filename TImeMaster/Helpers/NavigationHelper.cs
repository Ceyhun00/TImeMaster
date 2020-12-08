using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TImeMaster.Helpers
{
    public class NavigationHelper: HelperBase
    {
        public NavigationHelper(AppManager manager)
          : base(manager)
        {
        }
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl("https://time-master.ru/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
            Thread.Sleep(500);
        }
    }
}
