using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjectModel
{
    public class BasePage
    {
        public static IWebDriver driver;
        public static IWebDriver SeleniumInit()
        {
            IWebDriver chromedriver = new ChromeDriver();
            driver = chromedriver;
            return driver;

        }
    }
}
