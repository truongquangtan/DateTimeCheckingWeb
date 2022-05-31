using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using DateTimeCheckingWeb.Supporters;

namespace DateTimeUnitTest.NUnit_Lab3
{
    [TestFixture]
    public class DayInMonthTest
    {
        [Test]
        public void TestDayInMonth_UTCID01()
        {
            int actual = DateValidator.DaysInMonth("2020", "1");
            int expected = 31;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDayInMonth_UTCID02()
        {
            int actual = DateValidator.DaysInMonth("2021", "2");
            int expected = 28;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID03()
        {
            int actual = DateValidator.DaysInMonth("2000", "2");
            int expected = 29;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID04()
        {
            int actual = DateValidator.DaysInMonth("2100", "2");
            int expected = 28;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID05()
        {
            int actual = DateValidator.DaysInMonth("2020", "2");
            int expected = 29;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID06()
        {
            int actual = DateValidator.DaysInMonth("2021", "3");
            int expected = 31;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID07()
        {
            int actual = DateValidator.DaysInMonth("2021", "4");
            int expected = 30;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID08()
        {
            int actual = DateValidator.DaysInMonth("2021", "5");
            int expected = 31;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID09()
        {
            int actual = DateValidator.DaysInMonth("2021", "6");
            int expected = 30;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID10()
        {
            int actual = DateValidator.DaysInMonth("2021", "7");
            int expected = 31;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID11()
        {
            int actual = DateValidator.DaysInMonth("2021", "8");
            int expected = 31;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID12()
        {
            int actual = DateValidator.DaysInMonth("2021", "9");
            int expected = 30;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID13()
        {
            int actual = DateValidator.DaysInMonth("2021", "10");
            int expected = 31;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID14()
        {
            int actual = DateValidator.DaysInMonth("2021", "11");
            int expected = 30;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID15()
        {
            int actual = DateValidator.DaysInMonth("2021", "12");
            int expected = 31;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID16()
        {
            int actual = DateValidator.DaysInMonth("2019", "15");
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID17()
        {
            Assert.Throws<FormatException>(() => DateValidator.DaysInMonth("2021", "February"));
        }
        [Test]
        public void TestDayInMonth_UTCID18()
        {
            int actual = DateValidator.DaysInMonth("2019", "0");
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID19()
        {
            Assert.Throws<ArgumentNullException>(() => DateValidator.DaysInMonth("2021", null));
        }
        [Test]
        public void TestDayInMonth_UTCID20()
        {
            Assert.Throws<ArgumentNullException>(() => DateValidator.DaysInMonth(null, "8"));
        }
        [Test]
        public void TestDayInMonth_UTCID21()
        {
            int actual = DateValidator.DaysInMonth(0, 10);
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID22()
        {
            Assert.Throws<FormatException>(() => DateValidator.DaysInMonth("thousand", "8"));
        }
        [Test]
        public void TestDayInMonth_UTCID23()
        {
            int actual = DateValidator.DaysInMonth("85000", "10");
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID24()
        {
            int actual = DateValidator.DaysInMonth("50", "0");
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}
