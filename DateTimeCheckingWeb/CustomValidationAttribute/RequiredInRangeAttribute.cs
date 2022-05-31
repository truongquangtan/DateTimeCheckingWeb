using System.ComponentModel.DataAnnotations;

namespace DateTimeCheckingWeb.CustomValidationAttribute
{
    public class RequiredInRangeAttribute : ValidationAttribute
    {
        public int Min { get; }
        public int Max { get; }
        
        public RequiredInRangeAttribute(int min, int max)
        {
            if(min > max)
            {
                Min = max;
                Max = min;
            }
            else
            {
                Min = min;
                Max = max;
            }    
        }

        public override bool IsValid(object? value)
        {
            string? input = value as string;
            bool isNumber = int.TryParse(input, out int number);
            if(isNumber)
            {
                return number >= Min && number <= Max;
            }
            else
            {
                return false;
            }    
        }
    }
}
