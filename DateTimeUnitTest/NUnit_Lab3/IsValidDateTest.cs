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
    public class IsValidDateTest
    {
        [Test]
        public void TestDayInMonth_UTCID01()
        {
            int actual = DateValidator.DaysInMonth(2020, 1);
            int expected = 31;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDayInMonth_UTCID02()
        {
            int actual = DateValidator.DaysInMonth(2020, 1);
            int expected = 31;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID03()
        {
            int actual = DateValidator.DaysInMonth(2020, 1);
            int expected = 31;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID04()
        {
            int actual = DateValidator.DaysInMonth(2020, 1);
            int expected = 31;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID05()
        {
            int actual = DateValidator.DaysInMonth(2020, 1);
            int expected = 31;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID06()
        {
            int actual = DateValidator.DaysInMonth(2020, 1);
            int expected = 31;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID07()
        {
            int actual = DateValidator.DaysInMonth(2020, 1);
            int expected = 31;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDayInMonth_UTCID08()
        {
            int actual = DateValidator.DaysInMonth(2020, 1);
            int expected = 31;
            Assert.AreEqual(expected, actual);
        }
    }
}
