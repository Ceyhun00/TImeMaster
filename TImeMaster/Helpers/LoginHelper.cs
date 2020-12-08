using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TImeMaster.Helpers
{
    public class LoginHelper: HelperBase
    {
        public LoginHelper(AppManager manager)
           : base(manager)
        {
        }
        public void Login(AccountData accountData)
        {

            driver.FindElement(By.LinkText("Вход")).Click();
            driver.FindElement(By.Id("authUsername")).Click();
            driver.FindElement(By.Id("authUsername")).SendKeys(accountData.Username);
            driver.FindElement(By.Id("authPassword")).SendKeys(accountData.Password);
            driver.FindElement(By.CssSelector("div:nth-child(5) > input")).Click();
            Thread.Sleep(500);

        }
    }
}
