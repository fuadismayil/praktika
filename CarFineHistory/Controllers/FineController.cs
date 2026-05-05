using CarFineHistory.Data;
using CarFineHistory.Models;
using CarFineHistory.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarFineHistory.Controllers
{
    public class FineController : Controller
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
        public IActionResult Create(Fine fine)
        {
            Car? car = DemoDB.Cars.FirstOrDefault(c => c.Id == fine.CarId);
            Violation? violation = DemoDB.Violations.FirstOrDefault(v => v.Id == fine.ViolationId);

            if (car == null || violation == null)
            {
                TempData["Error"] = "Fine yaratmaq ucun masin ve qayda pozuntusu secilmelidir.";
                return RedirectToAction("Index", "Home");
            }

            fine.Id = DemoDB.Fines.Count + 1;

            // Fine yaranan vaxt avtomatik goturulur
            fine.Date = DateTime.Now;

            fine.Car = car;
            fine.Violation = violation;

            DemoDB.Fines.Add(fine);

            car.Fines.Add(fine);
            violation.Fines.Add(fine);

            car.Point += violation.Point;

            return RedirectToAction("Index", "Home");
        }
    }
}