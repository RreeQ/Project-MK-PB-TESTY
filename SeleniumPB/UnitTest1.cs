using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace SeleniumPB
{
    [TestFixture]
    public class FirstTests
    {
        IWebDriver _driver;
        [SetUp]
        public void StartBrowser()
        {
            _driver = new FirefoxDriver();
        }
        [Test]
        public void MoreleTest()
        {

            #region

            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.morele.net/");

            var email = "janzwyczajnyselenium@o2.pl";
            var password = "Selenium1!";
            var KEYBOARD = "CH-9102010-NA";
            var CPU = "Intel I9 9900K";
            var MOBO = "AsRock Z390 Taichi";
            var RAM = "PVR416G360C6K";
            var SCREEN = "210-AMNE";

            var goToLoginPage = _driver.FindElement(By.XPath("/html/body/header/div[1]/div/div/div/div[2]/div/div[2]/div/div[4]/a/span"));
            goToLoginPage.Click();
            Thread.Sleep(2000);

            _driver.FindElement(By.XPath("//*[@id=\"username\"]")).SendKeys(email);

            _driver.FindElement(By.CssSelector("#password-log")).SendKeys(password);

            var rememberMe = _driver.FindElement(By.XPath("/html/body/main/div/div/div[3]/form/div[3]/div/label/span"));
            rememberMe.Click();

            Thread.Sleep(1000);
            var loginButton = _driver.FindElement(By.XPath("/html/body/main/div/div/div[3]/form/button"));
            loginButton.Click();

            Thread.Sleep(2000);

            var search = _driver.FindElement(By.XPath("/html/body/header/div[1]/div/div/div/div[2]/div/div[1]/form/div/input"));
            search.SendKeys(CPU);
            search.Submit();
            Thread.Sleep(2000);
            _driver.Navigate().GoToUrl("https://www.morele.net/procesor-intel-core-i9-9900k-octa-core-5-0ghz-16mb-14nm-box-bx80684i99900k-4142641/");
            Thread.Sleep(1500);
            var itemToBasket = _driver.FindElement(By.XPath("/html/body/main/div/section[1]/div[1]/div[6]/aside/div[2]/div/div[7]/a"));

            itemToBasket.Click();

            Thread.Sleep(1500);

            search = _driver.FindElement(By.XPath("/html/body/header/div[1]/div/div/div/div[2]/div/div[1]/form/div/input"));

            search.SendKeys(MOBO);
            search.Submit();

            Thread.Sleep(2000);
            _driver.Navigate().GoToUrl("https://www.morele.net/plyta-glowna-asrock-z390-taichi-5033667/");
            itemToBasket = _driver.FindElement(By.XPath("/html/body/main/div/section[1]/div[1]/div[6]/aside/div[2]/div/div[7]/a"));
            itemToBasket.Click();

            Thread.Sleep(1500);

            search = _driver.FindElement(By.XPath("/html/body/header/div[1]/div/div/div/div[2]/div/div[1]/form/div/input"));

            search.SendKeys(RAM);
            search.Submit();

            Thread.Sleep(2000);

            itemToBasket = _driver.FindElement(By.XPath("/html/body/main/div/section[1]/div[1]/div[6]/aside/div[2]/div/div[7]/a"));
            itemToBasket.Click();

            Thread.Sleep(1500);

            search = _driver.FindElement(By.XPath("/html/body/header/div[1]/div/div/div/div[2]/div/div[1]/form/div/input"));

            search.SendKeys(SCREEN);
            search.Submit();

            Thread.Sleep(2000);
            itemToBasket = _driver.FindElement(By.XPath("/html/body/main/div/section[1]/div[1]/div[6]/aside/div[2]/div/div[7]/a"));
            itemToBasket.Click();

            Thread.Sleep(1500);

            search = _driver.FindElement(By.XPath("/html/body/header/div[1]/div/div/div/div[2]/div/div[1]/form/div/input"));

            search.SendKeys(KEYBOARD);
            search.Submit();

            Thread.Sleep(2000);
            itemToBasket = _driver.FindElement(By.XPath("/html/body/main/div/section[1]/div[1]/div[6]/aside/div[2]/div/div[7]/a"));
            itemToBasket.Click();

            Thread.Sleep(2000);

            _driver.Navigate().GoToUrl("https://www.morele.net/koszyk/");

            Thread.Sleep(2000);

            //var goToPayment = _driver.FindElement(By.CssSelector(".checked"));
            //goToPayment.Click();

            //var newAdress = _driver.FindElement(By.XPath("/html/body/main/div/div[1]/section/form/div/div/div[1]/div/div/div/div"));
            //newAdress.Click();

            //Thread.Sleep(1500);

            //var name = _driver.FindElement(By.XPath("//*[@id='name_1_0']"));
            //name.SendKeys("Janusz");

            _driver.Navigate().GoToUrl("https://www.morele.net/logout");

            StringAssert.StartsWith("https://www.morele.net/", _driver.Url);
            #endregion
        }
        [TearDown]
        public void CloseBrowser()
        {

            Thread.Sleep(1500);
            _driver.Close();
        }
    }
}
