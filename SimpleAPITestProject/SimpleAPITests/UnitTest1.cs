using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SimpleAPITestProject.SimpleAPITests
{
    public class Tests
    {
        ChromeDriver driver = new ChromeDriver(@"C:\Users\bohdan.potochniak\source\repos\SimpleAPITestProject\SimpleAPITestProject\webDriver");
        private string expectedFailingText = "Make sure you type your email and password correctly. Both your password and email are case-sensitive.";
       
        [SetUp]
        public void Setup()
        {
            driver.Navigate().GoToUrl("https://www.w3schools.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [Test]
        public void Test1()
        {
            IWebElement loginButton = driver.FindElement(By.CssSelector("a.w3-bar-item.w3-btn.w3-right"));
            loginButton.Click();
            Thread.Sleep(3000);
            IWebElement login = driver.FindElement(By.Id("modalusername"));
            login.SendKeys("bohdan.potochnyak@gmail.com");
            IWebElement pass = driver.FindElement(By.CssSelector("#current-password"));
            pass.SendKeys("Password");
            IWebElement enterButton = driver.FindElement(By.CssSelector(" div.LoginModal_cta_bottom_box_button_login__5Fbwv > button"));
            enterButton.Click();
            Thread.Sleep(5000);
            IWebElement actualFailingText = driver.FindElement(By.CssSelector("div.Alert_iwrp__5q1xH.Alert_danger__Wsdhv"));
        
            Assert.Equals(actualFailingText, expectedFailingText);
        }
    }
}