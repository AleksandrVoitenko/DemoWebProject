using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.Application.Debtors.Commands.EditDebtor
{
    public class EditDebtorCommand : IRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string DebtorName { get; set; }
        public string DebtorObject { get; set; }
        public string Description { get; set; }
    }
}
