using MediatR;

namespace Debtors.Application.Debtors.Commands.ClearDebtorsTrash
{
    public class ClearDebtorsTrashCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
    }
}
