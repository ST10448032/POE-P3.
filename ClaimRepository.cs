using MonthlyContractSystems.Models;
using System;
using System.Collections.Generic;

namespace MonthlyContractSystems.Data
{
    public static class ClaimRepository
    {
        public static List<ContractClaim> Claims = new List<ContractClaim>
        {
            new ContractClaim
            {
                Id = 1,
                LecturerName = "John Doe",
                Month = new DateTime(2025, 10, 1),
                HoursWorked = 20,
                HourlyRate = 150,
                Status = "Pending"
            },
            new ContractClaim
            {
                Id = 2,
                LecturerName = "Jane Smith",
                Month = new DateTime(2025, 9, 1),
                HoursWorked = 15,
                HourlyRate = 160,
                Status = "Verified"
            },
            new ContractClaim
            {
                Id = 3,
                LecturerName = "Mark Lee",
                Month = new DateTime(2025, 8, 1),
                HoursWorked = 25,
                HourlyRate = 140,
                Status = "Paid"
            }
        };
    }
}
