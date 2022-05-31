using System.ComponentModel.DataAnnotations;
using DateTimeCheckingWeb.Models;

namespace DateTimeCheckingWeb.CustomValidationAttribute
{
    public class RequiredNumberFormatAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string? input = value as string;

            bool tryParseResult = int.TryParse(input, out _);
            return tryParseResult;
        }
    }
}
