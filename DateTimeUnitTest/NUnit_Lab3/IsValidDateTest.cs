using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DateTimeCheckingWeb.Supporters;

namespace DateTimeUnitTest.NUnit_Lab3
{
    [TestFixture]
    public class IsValidDateTest
    {
        [Test]
        public void CheckDate_UTCID01()
        {
            bool result = DateValidator.IsValidDate("29", "2", "2000");
            Assert.IsTrue(result);
        }
        [Test]
        public void CheckDate_UTCID02()
        {
            bool result = DateValidator.IsValidDate("29", "2", "2009");
            Assert.IsFalse(result);
        }
        [Test]
        public void CheckDate_UTCID03()
        {
            bool result = DateValidator.IsValidDate("29", "2", "2020");
            Assert.IsTrue(result);
        }
        [Test]
        public void CheckDate_UTCID04()
        {
            bool result = DateValidator.IsValidDate("29", "2", "2100");
            Assert.IsFalse(result);
        }
        [Test]
        public void CheckDate_UTCID05()
        {
            Assert.Throws<ArgumentNullException>(() => DateValidator.IsValidDate(null, "2", "2000"));
        }
        [Test]
        public void CheckDate_UTCID06()
        {
            bool result = DateValidator.IsValidDate("35", "3", "2009");
            Assert.IsFalse(result);
        }
        [Test]
        public void CheckDate_UTCID07()
        {
            bool result = DateValidator.IsValidDate("0", "3", "2009");
            Assert.IsFalse(result);
        }
        [Test]
        public void CheckDate_UTCID08()
        {
            Assert.Throws<ArgumentNullException>(() => DateValidator.IsValidDate("30", null, "2009"));
        }
        [Test]
        public void CheckDate_UTCID09()
        {
            bool result = DateValidator.IsValidDate("30", "15", "2009");
            Assert.IsFalse(result);
        }
        [Test]
        public void CheckDate_UTCID10()
        {
            bool result = DateValidator.IsValidDate("30", "0", "2009");
            Assert.IsFalse(result);
        }
        [Test]
        public void CheckDate_UTCID11()
        {
            Assert.Throws<ArgumentNullException>(() => DateValidator.IsValidDate("30", "6", null));
        }
        [Test]
        public void CheckDate_UTCID12()
        {
            bool result = DateValidator.IsValidDate("30", "6", "85000");
            Assert.IsFalse(result);
        }
        [Test]
        public void CheckDate_UTCID13()
        {
            bool result = DateValidator.IsValidDate("30", "6", "0");
            Assert.IsFalse(result);
        }
        [Test]
        public void CheckDate_UTCID14()
        {
            Assert.Throws<FormatException>(() => DateValidator.IsValidDate("first", "6", "2000"));
        }
        [Test]
        public void CheckDate_UTCID15()
        {
            Assert.Throws<FormatException>(() => DateValidator.IsValidDate("29", "second", "2009"));
        }
        [Test]
        public void CheckDate_UTCID16()
        {
            Assert.Throws<FormatException>(() => DateValidator.IsValidDate("29", "2", "TwoThousand"));
        }
        [Test]
        public void CheckDate_UTCID17()
        {
            bool result = DateValidator.IsValidDate(30, 4, 2020);
            Assert.IsTrue(result);
        }
        [Test]
        public void CheckDate_UTCID18()
        {
            bool result = DateValidator.IsValidDate(15, 4, 2100);
            Assert.IsTrue(result);
        }
        [Test]
        public void CheckDate_UTCID19()
        {
            bool result = DateValidator.IsValidDate(15, 4, 2000);
            Assert.IsTrue(result);
        }
        [Test]
        public void CheckDate_UTCID20()
        {
            bool result = DateValidator.IsValidDate(29, 4, 2009);
            Assert.IsTrue(result);
        }
        [Test]
        public void CheckDate_UTCID21()
        {
            bool result = DateValidator.IsValidDate(0, 0, 2000);
            Assert.IsFalse(result);
        }
    }
}