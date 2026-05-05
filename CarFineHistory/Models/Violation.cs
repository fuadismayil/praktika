namespace CarFineHistory.Models
{
    public class Violation
    {
        public int Id { get; set; }
        public string Reason { get; set; }
        public int Point { get; set; }

        public List<Fine> Fines { get; set; }
    }
}
