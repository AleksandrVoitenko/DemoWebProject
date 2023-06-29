using MediatR;

namespace Debtors.Application.Debtors.Commands.EditDebtor
{
    public class EditDebtorCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string DebtorName { get; set; }
        public string DebtorObject { get; set; }
        public string? Description { get; set; }
        public DateTime? RepaymentDate { get; set; }
    }
}
