using Microsoft.AspNetCore.Mvc;
using MonthlyContractSystems.Data;
using System.Linq;

namespace MonthlyContractSystems.Controllers
{
    public class HRController : Controller
    {
        [HttpGet]
        public IActionResult History()
        {
            var claims = ClaimRepository.Claims
                .Where(c => c.Status == "Verified")
                .ToList();

            return View(claims);
        }

        [HttpPost]
        public IActionResult MarkPaid(int id)
        {
            var claim = ClaimRepository.Claims.FirstOrDefault(c => c.Id == id);
            if (claim != null && claim.Status == "Verified")
            {
                claim.Status = "Paid";
                Console.WriteLine($"💸 Claim {id} marked as Paid");
            }
            return RedirectToAction("History");
        }
    }
}
