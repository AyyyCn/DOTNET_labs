namespace TP3.Models
{
    public class MembershipType
    {
        public Guid Id { get; set; }
        public float SignUpFee { get; set; }
        public int DurationInMonthes { get; set; }
        public float DiscountRate { get; set; }

        public virtual ICollection<Customer>? Customers { get; set; }

    }
}
