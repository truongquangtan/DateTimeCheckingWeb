using FluentAssertions;
using Xunit;
using DateTimeCheckingWeb.Supporters;

namespace DateTimeUnitTest
{
    public class ValidateDateTest
    {
        [Theory]
        [InlineData(29,2,2000)]
        [InlineData(29,2,2004)]
        [InlineData(29,2,2020)]
        [InlineData(29,2,1200)]
        public void FebruaryDateInGapYearTest(int day, int month, int year)
        {
            bool result = DateValidator.IsValidDate(day, month, year);
            result.Should().BeTrue($"{day}/{month}/{year} must be the correct date");
        }

        [Theory]
        [InlineData(29,2,1000)]
        [InlineData(29,2,2009)]
        [InlineData(29,2,2100)]
        public void FebruaryDateNotInGapYearTest(int day, int month, int year)
        {
            bool result = DateValidator.IsValidDate(day, month, year);
            result.Should().BeFalse($"{day}/{month} must be the incorrect date because {year} is not gap year");
        }

        [Theory]
        [InlineData(0,1,1000)]
        [InlineData(-1,1,2000)]
        [InlineData(-100,1,2001)]
        [InlineData(32,1,2000)]
        [InlineData(60,1,2000)]
        public void DayOutOfRangeTest(int day, int month, int year)
        {
            bool result = DateValidator.IsValidDate(day, month, year);
            result.Should().BeFalse($"{day} is out of range");
        }

        [Theory]
        [InlineData(20,-1,2000)]
        [InlineData(20,0,2000)]
        [InlineData(20,-5,2000)]
        [InlineData(20,50,2000)]
        public void MonthOutOfRangeTest(int day, int month, int year)
        {
            bool result = DateValidator.IsValidDate(day, month, year);
            result.Should().BeFalse(because: $"{month} is out of range");
        }

        [Theory]
        [InlineData(-1,-1,2000)]
        [InlineData(-50,-2,2000)]
        [InlineData(20,20,2000)]
        public void BothDayAndMonthOutOfRangeTest(int day, int month, int year)
        {
            bool result = DateValidator.IsValidDate(day, month, year);
            result.Should().BeFalse(because: $"{month} and {day} is out of range");
        }
    }
}
