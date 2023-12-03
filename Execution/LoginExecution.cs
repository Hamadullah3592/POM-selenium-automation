using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjectModel
{
    [TestClass]
    public class LoginExecution
    {
        LoginPage loginPage = new LoginPage();
     
        [TestMethod]
        public void LoginWithValidData()
        {
            BasePage.SeleniumInit();
            loginPage.Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester");
            string actualtxt = BasePage.driver.FindElement(By.ClassName("welcome_menu")).Text;
            Assert.AreEqual("Welcome to Adactin Group of Hotels", actualtxt, "Login Sucessfully");
           // BasePage.driver.Close();

        }
    }
}
