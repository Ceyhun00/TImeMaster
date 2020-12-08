using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TImeMaster.Helpers
{
    public class GroupHelper: HelperBase
    {
        public GroupHelper(AppManager manager)
           : base(manager)
        {
        }

        public void AddAction(GroupData groupData)
        {
            driver.FindElement(By.LinkText("Добавить событие на весь день")).Click();
            driver.FindElement(By.Id("pet_taskTitle")).SendKeys(groupData.Name);
            driver.FindElement(By.XPath("/html/body/div[9]/div[4]/form/table/tbody/tr/td[1]/input")).Click();
            Thread.Sleep(500);

        }
    }
}
