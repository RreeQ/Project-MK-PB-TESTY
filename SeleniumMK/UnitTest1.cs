using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
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
            _driver = new FirefoxDriver();
        }

        [Test]
        public void PinterestTEST()
        {
//            Random rnd = new Random();
//            int month = rnd.Next(50, 99999);
//            _driver.Navigate().GoToUrl("https://pl.pinterest.com/");
//            var email = "test1selenium" + month + "@abuabudabu.com";
//            var password = "test1seleniumhaslo!";
//            var age = "22";
//            var emailTextBox = _driver.FindElement(By.XPath("//*[@id='email']"));
//            emailTextBox.SendKeys(email);
//            var passwordTextBox = _driver.FindElement(By.XPath("//*[@id='password']"));
//            passwordTextBox.SendKeys(password);
//            var ageTextBox = _driver.FindElement(By.XPath("//*[@id='age']"));
//            ageTextBox.SendKeys(age + Keys.Enter);

//            new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
//.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists((By.XPath("//*[@id='male']"))));
//            _driver.FindElement(By.XPath("//*[@id='male']")).Click();
//            new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
//.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists((By.CssSelector("._r5"))));
//            _driver.FindElement(By.CssSelector("._r5")).Click();

//            System.Threading.Thread.Sleep(10000);

//            _driver.FindElement(By.CssSelector(".NuxExtensionUpsell__optionalSkip")).Click();

//            System.Threading.Thread.Sleep(5000);

//            _driver.FindElement(By.CssSelector(".NuxPickerInterestsGrid > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > button:nth-child(1)")).Click();
//            _driver.FindElement(By.CssSelector(".NuxPickerInterestsGrid > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > button:nth-child(1)")).Click();
//            _driver.FindElement(By.CssSelector(".NuxPickerInterestsGrid > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1) > div:nth-child(1) > button:nth-child(1)")).Click();
//            _driver.FindElement(By.CssSelector(".NuxPickerInterestsGrid > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > button:nth-child(1)")).Click();
//            _driver.FindElement(By.CssSelector(".NuxPickerInterestsGrid > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(5) > div:nth-child(1) > div:nth-child(1) > button:nth-child(1)")).Click();

//            _driver.FindElement(By.CssSelector("._r5")).Click();

//            System.Threading.Thread.Sleep(5000);

//            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
//            _driver.FindElement(By.CssSelector(".experienceSystemPushOverlay")).Click();

//            _driver.FindElement(By.XPath("/html/body/div/div/div[1]/div/div[1]/div[1]/div[2]/div[1]/div/div[2]/div/div/div[3]/div[4]/div/div/div/a/div/div")).Click();
//            string actualvalue = _driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div/div[1]/div[1]/div[3]/div/div/div/div[1]/div[1]/div[2]/div/div/div[1]/div/div/div[1]/h4")).Text;
//            Assert.IsTrue(actualvalue.Contains("Testselenium"));

            StringAssert.StartsWith("https://pl.pinterest.com/", _driver.Url);
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
