using Microsoft.AspNetCore.Mvc;
using MonthlyContractSystems.Data;
using MonthlyContractSystems.Models;
using System.Linq;

namespace MonthlyContractSystems.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string role = "Lecturer")
        {
            ViewBag.Role = role;
            var recentClaims = ClaimRepository.Claims
                .OrderByDescending(c => c.Month)
                .Take(5)
                .ToList();

            return View(recentClaims); // Pass as model instead of ViewBag
        }
    }
}