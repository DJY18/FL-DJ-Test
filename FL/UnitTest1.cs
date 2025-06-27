using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Runtime.InteropServices.JavaScript.JSType;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.DevTools.V135.Network;



namespace FH
{
    public class Tests
    {
        IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();


        }

        [Test]
        public void CreateAccount()
        { string txt;
            driver.Navigate().GoToUrl("https://reqres.in/");
            Assert.That(driver.Url, Is.EqualTo("https://reqres.in/"));

            driver.FindElement(By.XPath("//*[@id=\"console\"]/div[1]/ul/li[7]/a")).Click();

            txt = driver.FindElement(By.XPath("//*[@id=\"console\"]/div[2]/div[2]/p/strong/span")).GetAttribute();

            Assert.IsTrue(txt.Contains("201"));
            

        }

        [Test]
        public void LoginSuccessful()
        {
            driver.Navigate().GoToUrl("https://reqres.in/");
            Assert.That(driver.Url, Is.EqualTo("https://reqres.in/"));

            driver.FindElement(By.XPath("//*[@id=\"console\"]/div[1]/ul/li[13]/a")).Click();



        }





        [TearDown]  
        public void TearDown() { driver.Quit(); }
    }
}


