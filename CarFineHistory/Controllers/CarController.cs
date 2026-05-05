using CarFineHistory.Data;
using CarFineHistory.Models;
using CarFineHistory.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarFineHistory.Controllers
{
    public class CarController : Controller
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
        public IActionResult Create(Car car)
        {
            car.Id = DemoDB.Cars.Count + 1;
            car.Point = 0;
            car.Fines = new List<Fine>();

            DemoDB.Cars.Add(car);

            return RedirectToAction("Index", "Home");
        }
    }
}