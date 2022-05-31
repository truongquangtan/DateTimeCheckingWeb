using Xunit;
using DateTimeCheckingWeb.Supporters;
using FluentAssertions;

namespace DateTimeUnitTest
{
    public class MaxDayTest
    {
        [Fact]
        public void TestMaxDayFebruaryInGapYear()
        {
            int month = 2;
            int[] years = {2020, 2000};
            foreach(int year in years)
            {
                int maxDay = DateValidator.DaysInMonth(year, month);
                //Assert.Equal(29, maxDay);
                maxDay.Should().Be(29, $"Max day of year {year}, month {month} must be 29");
            }
        }
        [Fact]
        public void TestMaxDayFebruaryNotInGapYear()
        {
            int month = 2;
            int[] years = {2021, 2100};
            foreach (int year in years)
            {
                int maxDay = DateValidator.DaysInMonth(year, month);
                //Assert.Equal(28, maxDay);
                maxDay.Should().Be(28, $"Max day of year {year}, month {month} must be 28");
            }
        }
        [Fact]
        public void TestMaxDayOf30()
        {
            int[] months = { 4, 6, 9, 11 };
            int[] years = { 2000, 2001, 2002, 2021 };
            foreach (int year in years)
            {
                foreach (int month in months)
                {
                    int maxDay = DateValidator.DaysInMonth(year, month);
                    //Assert.Equal(30, maxDay);
                    maxDay.Should().Be(30, $"Max day of year {year}, month {month} must be 30");
                }
            }
        }
        [Fact]
        public void TestMaxDayOf31()
        {
            int[] months = { 1, 3, 5, 7, 8, 10, 12 };
            int[] years = { 2000, 2001, 2002, 2021 };
            foreach (int year in years)
            {
                foreach (int month in months)
                {
                    int maxDay = DateValidator.DaysInMonth(year, month);
                    Assert.Equal(31, maxDay);
                    maxDay.Should().Be(31, $"Max day of year {year}, month {month} must be 31");
                }
            }
        }
        [Fact]
        public void TestInvalidInputMonth()
        {
            int[] months = { 0, 13, -1, 99 };
            int year = 2000;
            foreach (int month in months)
            {
                int maxDay = DateValidator.DaysInMonth(year, month);
                //Assert.Equal(0, maxDay);
                maxDay.Should().Be(0, $"Max day of year {year}, month {month} must be 0 because month is invalid");
            }
        }
        [Fact]
        public void TestInvalidInputYear()
        {
            int[] months = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] years = { -1, 0 };
            foreach (int month in months)
            {
                foreach (int year in years)
                {
                    int maxDay = DateValidator.DaysInMonth(year, month);
                    //Assert.Equal(0, maxDay);
                    maxDay.Should().Be(0, $"Max day of year {year}, month {month} must be 0 because year is invalid");
                }
            }    
        }
    }
}