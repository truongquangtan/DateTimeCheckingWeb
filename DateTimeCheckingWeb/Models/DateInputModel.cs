using DateTimeCheckingWeb.CustomValidationAttribute;
using System.ComponentModel.DataAnnotations;

namespace DateTimeCheckingWeb.Models
{
    public class DateInputModel
    {
        [Required]
        [RequiredNumberFormat(ErrorMessage = "Input for day is not a number")]
        [RequiredInRange(1,31,ErrorMessage = "Input for day is out of range")]
        public string? Day { get; set; }
        [Required]
        [RequiredNumberFormat(ErrorMessage = "Input for month is not a number")]
        [RequiredInRange(1, 12, ErrorMessage = "Input for month is out of range")]
        public string? Month { get; set; }
        [Required]
        [RequiredNumberFormat(ErrorMessage = "Input for year is not a number")]
        [RequiredInRange(1000, 4000, ErrorMessage = "Input for year is out of range")]
        public string? Year { get; set; }
        public string? Message { get; set; }
    }
}
