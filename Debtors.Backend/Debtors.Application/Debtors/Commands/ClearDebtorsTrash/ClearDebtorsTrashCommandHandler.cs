using Debtors.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Debtors.Application.Debtors.Commands.ClearDebtorsTrash
{
    public class ClearDebtorsTrashCommandHandler : IRequestHandler<ClearDebtorsTrashCommand, Unit>
    {
        private readonly IDebtorsDbContext _dbContext;

        public ClearDebtorsTrashCommandHandler(IDebtorsDbContext dbContext) 
        {  
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(ClearDebtorsTrashCommand request, CancellationToken cancellationToken)
        {
            var entities = await _dbContext.Debtors
                .Where(debtor => debtor.UserId == request.UserId)
                .Where(debtor => !debtor.IsValied)
                .ToListAsync(cancellationToken);

            foreach (var entity in entities)
            {
                _dbContext.Debtors.Remove(entity);
            }

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
