using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.Application.Debtors.Queries.GetDebtorDetails
{
    public class GetDebtorDetailsQuery : IRequest<DebtorDetailsVm>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    } 
}
