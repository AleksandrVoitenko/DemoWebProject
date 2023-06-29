namespace Debtors.Domain.Entities
{
    public class Debtor :BaseEntity
    {
        public Guid UserId { get; set; }
        public string DebtorName { get; set; }
        public string DebtorObject { get; set; }
        public string? Description { get; set; }
        public DateTime? RepaymentDate { get; set; } 
    }
}
