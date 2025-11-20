using Microsoft.AspNetCore.Mvc;
using MonthlyContractSystems.Data;
using System.Linq;

namespace MonthlyContractSystems.Controllers
{
    public class CoordinatorController : Controller
    {
        [HttpGet]
        public IActionResult History()
        {
            var claims = ClaimRepository.Claims
                .Where(c => c.Status == "Pending")
                .ToList();

            return View(claims);
        }

        [HttpPost]
        
        public IActionResult Verify(int id)
        {
            var claim = ClaimRepository.Claims.FirstOrDefault(c => c.Status == "Pending");
            if (claim != null)
            {
                claim.Status = "Verified";
            }
            return RedirectToAction("History");
        }

    }
}
