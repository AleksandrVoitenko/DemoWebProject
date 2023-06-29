using MediatR;
using Microsoft.EntityFrameworkCore;
using Debtors.Application.Interfaces;
using Debtors.Application.Common.Exceptions;
using Debtors.Domain.Entities;

namespace Debtors.Application.Debtors.Commands.RemoveDebtor
{
    public class RemoveDebtorCommandHandler :IRequestHandler<RemoveDebtorCommand, Unit>
    {
        private readonly IDebtorsDbContext _dbContext;

        public RemoveDebtorCommandHandler(IDebtorsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(RemoveDebtorCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Debtors
                .FirstOrDefaultAsync(debtor => debtor.Id == request.Id, cancellationToken);
            if (entity == null || entity.UserId != request.UserId) 
            { 
                throw new NotFoundException(nameof(Debtor), request.Id);
            }

            entity.IsValied = false;
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
