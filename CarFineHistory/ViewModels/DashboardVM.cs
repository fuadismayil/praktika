using CarFineHistory.Models;

namespace CarFineHistory.ViewModels
{
    public class DashboardVM
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<Fine> Fines { get; set; } = new List<Fine>();
        public List<Violation> Violations { get; set; } = new List<Violation>();
    }
}