using Microsoft.AspNetCore.Mvc;
using MonthlyContractSystems.Models;
using MonthlyContractSystems.Data;
using System.Linq;

namespace MonthlyContractSystems.Controllers
{
    public class LecturerController : Controller
    {

        [HttpGet]
        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Submit(ContractClaim claim)
        {
            claim.Id = ClaimRepository.Claims.Count + 1;
            Console.WriteLine($"New claim created with Id={claim.Id}, Status={claim.Status}");

            if (ModelState.IsValid)
            {

                claim.Id = ClaimRepository.Claims.Count + 1; // auto ID
                claim.Status = "Pending";
                ClaimRepository.Claims.Add(claim);
                return RedirectToAction("History");
                
            }
            return View(claim);
        }

        public IActionResult History()
        {
            var claims = ClaimRepository.Claims

                .OrderByDescending(c => c.Month)
                .ToList();

            return View(claims);
        }

    }
}

