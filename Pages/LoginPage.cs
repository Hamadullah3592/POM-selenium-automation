using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjectModel
{
    public class LoginPage : BasePage
    {
        public void Login(string url, string username, string password)
        {
            driver.Url = url;
            driver.FindElement(By.Id("username")).SendKeys(username);
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.Id("login")).Click();

        }
    }
}
