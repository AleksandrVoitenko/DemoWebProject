
using MediatR;

namespace Debtors.Application.Debtors.Queries.GetDebtorsList
{
    public class GetDebtorsListQuery : IRequest<DebtorsListVm>
    {
        public Guid UserId { get; set; }
    }
}
