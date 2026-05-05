using CarFineHistory.Data;
using CarFineHistory.Models;
using CarFineHistory.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarFineHistory.Controllers
{
    public class ViolationController : Controller
    {
        public IActionResult Get()
        {
            DashboardVM vm = new DashboardVM
            {
                Cars = DemoDB.Cars,
                Fines = DemoDB.Fines,
                Violations = DemoDB.Violations
            };

            return View("~/Views/Home/Index.cshtml", vm);
        }

        [HttpPost]
        public IActionResult Create(Violation violation)
        {
            violation.Id = DemoDB.Violations.Count + 1;
            violation.Fines = new List<Fine>();

            DemoDB.Violations.Add(violation);

            return RedirectToAction("Index", "Home");
        }
    }
}