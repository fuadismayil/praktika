using CarFineHistory.Models;

namespace CarFineHistory.Data
{
    public static class DemoDB
    {
        public static List<Car> Cars = new List<Car>();
        public static List<Fine> Fines = new List<Fine>();
        public static List<Violation> Violations = new List<Violation>();
    }
}