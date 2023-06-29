using MediatR;

namespace Debtors.Application.Debtors.Commands.RemoveDebtor
{
    public class RemoveDebtorCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}
