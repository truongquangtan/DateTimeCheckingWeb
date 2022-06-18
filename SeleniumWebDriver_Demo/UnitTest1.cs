using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver_Demo
{
    public class UnitTest1 : IDisposable
    {
        private IWebDriver driver;
        private string url = "https://localhost:7231";

        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
            }
        }

        [Fact]
        public void Test1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            IWebElement txtDay = driver.FindElement(By.Id("Day"));
            txtDay.SendKeys("a");

            IWebElement txtMonth = driver.FindElement(By.Id("Month"));
            txtMonth.SendKeys("1");

            IWebElement txtYear = driver.FindElement(By.Id("Year"));
            txtYear.SendKeys("2000");

            IWebElement checkButton = driver.FindElement(By.Id("submit"));
            checkButton.Click();

            IWebElement errorFieldDay = driver.FindElement(By.Id("validation-for-day"));
            string errorMessageFieldDay = errorFieldDay.Text;

            Assert.Equal("Input for day is not a number", errorMessageFieldDay);
        }
    }
}