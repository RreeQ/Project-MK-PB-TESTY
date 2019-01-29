using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest
{
    [TestFixture]
    public class SeleniumMk
    {
        IWebDriver _driver;
        [SetUp]
        public void StartBrowser()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        public void SeleniumMK()
        {
            _driver.Navigate().GoToUrl("https://www.x-kom.pl/");
            Random rnd = new Random();
            int month = rnd.Next(50, 99999);
            var imie = "abdul";
            var lastname = "selenium";
            var password = "test1seleniumhaslo!";
            var email = "testselenium1" + month + "@gmail.com";
            _driver.FindElement(By.XPath("//*[@id='header']/header/div/div[2]/div/div[4]/div/a/div/i")).Click();
            _driver.FindElement(By.XPath("/html/body/div[2]/div/section[2]/div[2]/div/a")).Click();
            var nameTextBox = _driver.FindElement(By.CssSelector("#firstName"));
            nameTextBox.SendKeys(imie);
            var lastnameTextBox = _driver.FindElement(By.CssSelector("#lastName"));
            lastnameTextBox.SendKeys(lastname);
            var emailTextBox = _driver.FindElement(By.CssSelector("#email"));
            emailTextBox.SendKeys(email);
            var passwordTextBox = _driver.FindElement(By.CssSelector("#password"));
            passwordTextBox.SendKeys(password);
            _driver.FindElement(By.XPath("//*[@id='termsOfUseAcceptation']")).Click();
            _driver.FindElement(By.XPath("//*[@id='consent-0865a6f2e72120e8f807bbc8365f0793']")).Click();
            _driver.FindElement(By.XPath("//*[@id='consent-9a785ca7c529d901c6170cc000221a7e']")).Click();
            
            _driver.FindElement(By.XPath("//*[@id='registrationForm']/div[6]/div[5]/div/button")).Click();
            System.Threading.Thread.Sleep(5000);
            var lookingfor = _driver.FindElement(By.XPath("//*[@id='searchBar']/div[1]/div[1]/input"));
            lookingfor.SendKeys("myszka");
            System.Threading.Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//*[@id='searchBar']/div[1]/div[3]/button/i")).Click();
            System.Threading.Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//*[@id='productList']/div[1]/a/img")).Click();
            System.Threading.Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//*[@id='app']/div[2]/div[4]/div/div[2]/div[1]/div[2]/div[2]/button/span/span[2]")).Click();
            System.Threading.Thread.Sleep(4000);
            _driver.FindElement(By.XPath("//*[@id='basketItems']/div/div/div[4]/span/span")).Text.Contains("45,00 zł");



            //Random rnd = new Random();
            //int month = rnd.Next(50, 99999);
            //var email = "test1selenium" + month + "@abuabudabu.com";
            //var password = "test1seleniumhaslo!";
            //var age = "22";
            //var emailTextBox = _driver.FindElement(By.XPath("//*[@id='email']"));
            //emailTextBox.SendKeys(email);
            //var passwordTextBox = _driver.FindElement(By.XPath("//*[@id='password']"));
            //passwordTextBox.SendKeys(password);
            //var ageTextBox = _driver.FindElement(By.XPath("//*[@id='age']"));
            //ageTextBox.SendKeys(age + Keys.Enter);
            //            new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
            //.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists((By.XPath("//*[@id='male']"))));
            //            _driver.FindElement(By.XPath("//*[@id='male']")).Click();

            //            System.Threading.Thread.Sleep(2000);


            //            _driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div[2]/button/div")).Click();


            //            System.Threading.Thread.Sleep(5000);

            //            _driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[3]/div[2]/div/div")).Click();

            //            System.Threading.Thread.Sleep(5000);

            //            _driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/div[3]/div/div[1]/div[1]/div[1]")).Click();
            //            _driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/div[3]/div/div[1]/div[1]/div[2]")).Click();
            //            _driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/div[3]/div/div[1]/div[1]/div[3]")).Click();
            //            _driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/div[3]/div/div[1]/div[1]/div[4]")).Click();
            //            _driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/div[3]/div/div[1]/div[1]/div[5]")).Click();

            //            _driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/div[4]/div[2]/div/button/div")).Click();

            //            System.Threading.Thread.Sleep(5000);

            //            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //            _driver.FindElement(By.CssSelector(".experienceSystemPushOverlay")).Click();

            //            _driver.FindElement(By.XPath("/html/body/div/div/div[1]/div/div[1]/div[1]/div[2]/div[1]/div/div[2]/div/div/div[3]/div[4]/div/div/div/a/div/div")).Click();
            //            string actualvalue = _driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div/div[1]/div[1]/div[3]/div/div/div/div[1]/div[1]/div[2]/div/div/div[1]/div/div/div[1]/h4")).Text;
            //            Assert.IsTrue(actualvalue.Contains("Testselenium"));

            //StringAssert.StartsWith("https://pl.pinterest.com/", _driver.Url);
            //_driver.FindElement(By.XPath("//*[@id='Password']")).Click();
            //StringAssert.StartsWith("https://chomikuj.pl", _driver.Url);
            //_driver.FindElement(By.XPath("//*[@id='header - items']/div[2]/div[2]/a")).Click();
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //_driver.FindElement(By.XPath("//*[@id='AgeConfirmed']")).Click();
            //_driver.FindElement(By.XPath("//*[@id='TermsAccepted']")).Click();
            //_driver.FindElement(By.XPath("/ html / body / div[2] / div[1] / div / div[4] / div / div / div / form / dl / dd[4] / input")).Click();
            //_driver.FindElement(By.XPath("/ html / body / div[2] / div[3] / div[1] / div / div / span / div[5]")).Click();
            //_driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div/div[4]/div/div/form/div/div/dd/input")).Click();
            //_driver.FindElement(By.XPath("/ html / body / div[4] / div / div[1] / div / div / div[2] / div / form / div / input")).Click();
            //_driver.FindElement(By.XPath("/html/body/div[2]/div[2]/form/div/button")).Click();
            //_driver.FindElement(By.XPath("/ html / body / div[3] / div / div[3] / div[2] / div[1] / div[2] / h2 / a")).Text.Contains("test1selenium");

        }
        [TearDown]
        public void CloseBrowser()
        {
            _driver.Close();
        }
    }

}
