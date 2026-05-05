namespace CarFineHistory.Models
{
    public class Fine
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int ViolationId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public bool IsPaid { get; set; }

        public Car Car { get; set; }
        public Violation Violation { get; set; }
    }
}
