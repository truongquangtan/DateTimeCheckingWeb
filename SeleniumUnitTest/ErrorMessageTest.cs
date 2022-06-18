using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumUnitTest
{
    public class ErrorMessageTest : IDisposable
    {
        private IWebDriver driver;
        private string url = "https://localhost:7231";

        public ErrorMessageTest()
        {
            driver = new ChromeDriver();
        }

        public void Dispose()
        {
            if(driver != null)
            {
                driver.Dispose();
            }    
        }

        [Theory]
        [InlineData("a", "10", "2000")]
        [InlineData("first", "11", "2000")]
        public void TestErrorMessageForDayInput_NotANumber(string day, string month, string year)
        {
            NavigateToTestPage();
            SendKeyInputFieldsDayMonthYear(day, month, year);
            ClickCheckButton();

            System.Threading.Thread.Sleep(1000);

            string errorMessageFieldDay = GetErrorFieldDayText();
            AssertErrorMessageForDay_NotANumber(errorMessageFieldDay);

            System.Threading.Thread.Sleep(2000);
        }

        [Theory]
        [InlineData("32", "12", "2000")]
        [InlineData("0", "0", "2000")]
        public void TestErrorMessageForDayInput_OutOfRange(string day, string month, string year)
        {
            NavigateToTestPage();
            SendKeyInputFieldsDayMonthYear(day, month, year);
            ClickCheckButton();

            System.Threading.Thread.Sleep(1000);

            string errorMessageFieldDay = GetErrorFieldDayText();
            AssertErrorMessageForDay_OutOfRange(errorMessageFieldDay);

            System.Threading.Thread.Sleep(2000);
        }

        [Theory]
        [InlineData("", "12", "2000")]
        public void TestErrorMessageForDayInput_FieldRequired(string day, string month, string year)
        {
            NavigateToTestPage();
            SendKeyInputFieldsDayMonthYear(day, month, year);
            ClickCheckButton();

            System.Threading.Thread.Sleep(1000);

            string errorMessageFieldDay = GetErrorFieldDayText();
            AssertErrorMessageForDay_Required(errorMessageFieldDay);

            System.Threading.Thread.Sleep(2000);
        }

        [Theory]
        [InlineData("1", "a", "2000")]
        [InlineData("1", "January", "2000")]
        public void TestErrorMessageForMonthInput_NotANumber(string day, string month, string year)
        {
            NavigateToTestPage();
            SendKeyInputFieldsDayMonthYear(day, month, year);
            ClickCheckButton();

            System.Threading.Thread.Sleep(1000);

            string errorMessageFieldMonth = GetErrorFieldMonthText();
            AssertErrorMessageForMonth_NotANumber(errorMessageFieldMonth);

            System.Threading.Thread.Sleep(2000);
        }

        [Theory]
        [InlineData("1", "0", "2000")]
        [InlineData("1", "15", "2000")]
        public void TestErrorMessageForMonthInput_OutOfRange(string day, string month, string year)
        {
            NavigateToTestPage();
            SendKeyInputFieldsDayMonthYear(day, month, year);
            ClickCheckButton();

            System.Threading.Thread.Sleep(1000);

            string errorMessageFieldMonth = GetErrorFieldMonthText();
            AssertErrorMessageForMonth_OutOfRange(errorMessageFieldMonth);

            System.Threading.Thread.Sleep(2000);
        }

        [Theory]
        [InlineData("1", "", "2000")]
        [InlineData("", "", "2000")]
        public void TestErrorMessageForMonthInput_FieldRequired(string day, string month, string year)
        {
            NavigateToTestPage();
            SendKeyInputFieldsDayMonthYear(day, month, year);
            ClickCheckButton();

            System.Threading.Thread.Sleep(1000);

            string errorMessageFieldMonth = GetErrorFieldMonthText();
            AssertErrorMessageForMonth_Required(errorMessageFieldMonth);

            System.Threading.Thread.Sleep(2000);
        }

        [Theory]
        [InlineData("1", "10", "a")]
        [InlineData("first", "11", "thousand")]
        public void TestErrorMessageForYearInput_NotANumber(string day, string month, string year)
        {
            NavigateToTestPage();
            SendKeyInputFieldsDayMonthYear(day, month, year);
            ClickCheckButton();

            System.Threading.Thread.Sleep(1000);

            string errorMessageFieldYear = GetErrorFieldYearText();
            AssertErrorMessageForYear_NotANumber(errorMessageFieldYear);

            System.Threading.Thread.Sleep(2000);
        }

        [Theory]
        [InlineData("32", "12", "999")]
        [InlineData("0", "0", "5000")]
        public void TestErrorMessageForYearInput_OutOfRange(string day, string month, string year)
        {
            NavigateToTestPage();
            SendKeyInputFieldsDayMonthYear(day, month, year);
            ClickCheckButton();

            System.Threading.Thread.Sleep(1000);

            string errorMessageFieldYear = GetErrorFieldYearText();
            AssertErrorMessageForYear_OutOfRange(errorMessageFieldYear);

            System.Threading.Thread.Sleep(2000);
        }

        [Theory]
        [InlineData("1", "12", "")]
        public void TestErrorMessageForYearInput_FieldRequired(string day, string month, string year)
        {
            NavigateToTestPage();
            SendKeyInputFieldsDayMonthYear(day, month, year);
            ClickCheckButton();

            System.Threading.Thread.Sleep(1000);

            string errorMessageFieldYear = GetErrorFieldYearText();
            AssertErrorMessageForYear_Required(errorMessageFieldYear);

            System.Threading.Thread.Sleep(2000);
        }

        private void NavigateToTestPage()
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }
        private void SendKeyInputFieldsDayMonthYear(string day, string month, string year)
        {
            IWebElement txtDay = driver.FindElement(By.Id("Day"));
            txtDay.SendKeys(day);

            IWebElement txtMonth = driver.FindElement(By.Id("Month"));
            txtMonth.SendKeys(month);

            IWebElement txtYear = driver.FindElement(By.Id("Year"));
            txtYear.SendKeys(year);
        }
        private void ClickCheckButton()
        {
            IWebElement checkButton = driver.FindElement(By.Id("submit"));
            checkButton.Click();
        }

        private string GetErrorFieldDayText()
        {
            IWebElement errorFieldDay = driver.FindElement(By.Id("validation-for-day"));
            string errorMessageFieldDay = errorFieldDay.Text;
            return errorMessageFieldDay;
        }
        private string GetErrorFieldMonthText()
        {
            IWebElement errorFieldMonth = driver.FindElement(By.Id("validation-for-month"));
            string errorMessageFieldMonth = errorFieldMonth.Text;
            return errorMessageFieldMonth;
        }
        private string GetErrorFieldYearText()
        {
            IWebElement errorFieldYear = driver.FindElement(By.Id("validation-for-year"));
            string errorMessageFieldYear = errorFieldYear.Text;
            return errorMessageFieldYear;
        }

        private void AssertErrorMessageForDay_NotANumber(string message)
        {
            Assert.Equal("Input for day is not a number", message);
        }
        private void AssertErrorMessageForDay_OutOfRange(string message)
        {
            Assert.Equal("Input for day is out of range", message);
        }
        private void AssertErrorMessageForDay_Required(string message)
        {
            Assert.Equal("The Day field is required.", message);
        }

        private void AssertErrorMessageForMonth_NotANumber(string message)
        {
            Assert.Equal("Input for month is not a number", message);
        }
        private void AssertErrorMessageForMonth_OutOfRange(string message)
        {
            Assert.Equal("Input for month is out of range", message);
        }
        private void AssertErrorMessageForMonth_Required(string message)
        {
            Assert.Equal("The Month field is required.", message);
        }

        private void AssertErrorMessageForYear_NotANumber(string message)
        {
            Assert.Equal("Input for year is not a number", message);
        }
        private void AssertErrorMessageForYear_OutOfRange(string message)
        {
            Assert.Equal("Input for year is out of range", message);
        }
        private void AssertErrorMessageForYear_Required(string message)
        {
            Assert.Equal("The Year field is required.", message);
        }
    }
}