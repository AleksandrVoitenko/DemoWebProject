using Debtors.Application.Common.Exceptions;
using Debtors.Application.Interfaces;
using Debtors.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Debtors.Application.Debtors.Commands.EditDebtor
{
    public class EditDebtorCommandHadle : IRequestHandler<EditDebtorCommand>
    {
        private readonly IDebtorsDbContext _dbContext;

        public EditDebtorCommandHadle(IDebtorsDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(EditDebtorCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Debtors
                .FirstOrDefaultAsync(debtor => debtor.Id == request.Id, cancellationToken);

            if(entity == null || entity.UserId != request.UserId)
            {
                throw new NotFoundException(nameof(Debtor), request.Id);
            }

            entity.DebtorName = request.DebtorName;
            entity.DebtorObject = request.DebtorObject;
            entity.Description = request.Description;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
