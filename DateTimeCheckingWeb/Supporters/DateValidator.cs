using System.ComponentModel;

namespace DateTimeCheckingWeb.Supporters
{
    public static class DateValidator
    {
        public static bool Validate(int day, int month, int year)
        {
            string convertFrom = $"{month}/{day}/{year}";
            return TryToConvertFrom(convertFrom);
        }
        private static bool TryToConvertFrom(string convertFrom)
        {
            try
            {
                DateTimeConverter converter = new();
                return converter.ConvertFromString(convertFrom) != null;
            } catch (FormatException)
            {
                return false;
            }
        }

        public static int DaysInMonth(int year, int month)
        {
            if (year <= 0) return 0;
            if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            if(month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }    
            if(month == 2)
            {
                if(year % 400 == 0)
                {
                    return 29;
                }
                else
                {
                    if(year % 100 == 0)
                    {
                        return 28;
                    }
                    else
                    {
                        if(year % 4 == 0)
                        {
                            return 29;
                        }
                        else
                        {
                            return 28;
                        }    
                    }    
                }    
            }
            else
            {
                return 0;
            }    
        }
        public static bool IsValidDate(int day, int month, int year)
        {
            if (year < 0 || year > 4000)
            {
                return false;
            }    
            if (month < 1 || month > 12)
            {
                return false;
            }
            else
            {
                if (day < 1)
                {
                    return false;
                }
                else
                {
                    if (day > DaysInMonth(year, month))
                    {
                        return false;
                    }    
                }    
            }
            return true;
        }
    }
}
