using SalesWebMvc3.Models.Enums;

namespace SalesWebMvc3.Models
{
    public class SalesRecord
    {
        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double value, ESalesStatus status, Saller seller)
        {
            Id = id;
            Date = date;
            Value = value;
            Status = status;
            Seller = seller;
        }

        public int Id { get; set; }
        public DateTime Date{ get; set; }
        public double Value{ get; set; }
        public ESalesStatus Status { get; set; }
        public Saller Seller{ get; set; }
    }
}
