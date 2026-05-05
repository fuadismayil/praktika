using CarFineHistory.Data;
using CarFineHistory.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarFineHistory.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            DashboardVM vm = new DashboardVM
            {
                Cars = DemoDB.Cars,
                Fines = DemoDB.Fines,
                Violations = DemoDB.Violations
            };

            return View(vm);
        }
    }
}