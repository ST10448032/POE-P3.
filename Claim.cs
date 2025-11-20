using System;
using System.ComponentModel.DataAnnotations;

namespace MonthlyContractSystems.Models
{
    public class ContractClaim
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lecturer name is required")]
        public string LecturerName { get; set; }

        [Required(ErrorMessage = "Month is required")]
        public DateTime Month { get; set; }

        [Required(ErrorMessage = "Hours worked is required")]
        public decimal HoursWorked { get; set; }

        [Required(ErrorMessage = "Hourly rate is required")]
        public decimal HourlyRate { get; set; }

        public string Status { get; set; } = "Pending";

        public decimal Amount => HoursWorked * HourlyRate;
    }
}
