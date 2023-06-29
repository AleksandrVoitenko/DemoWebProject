using MediatR;

namespace Debtors.Application.Debtors.Commands.CreateDebtors
{
    public class CreateDebtorCommand : IRequest<Guid>
    {
        public Guid UserID { get; set; }
        public string DebtorName { get; set; }
        public string DebtorObject { get; set; }
        public string? Description { get; set; }
    }
}
