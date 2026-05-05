namespace CarFineHistory.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string OwnerName { get; set; }
        public int PassengerCount { get; set; }
        public string Passport { get; set; }
        public string Fuel { get; set; }
        public int Point { get; set; }

        public List<Fine> Fines { get; set; } = new List<Fine>();
    }
}
