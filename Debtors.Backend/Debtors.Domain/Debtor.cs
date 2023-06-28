
namespace Debtors.Domain
{
    public class Debtor
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string DebtorName { get; set; }
        public string DebtorObject { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set;}
    }
}
