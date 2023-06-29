using Debtors.Application.Interfaces;
using Debtors.Domain;
using MediatR;

namespace Debtors.Application.Debtors.Commands.CreateDebtors
{
    public class CreateDebtorCommandHandler : IRequestHandler<CreateDebtorCommand, Guid>
    {
        private readonly IDebtorsDbContext _dbContext;

        public CreateDebtorCommandHandler(IDebtorsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateDebtorCommand request, CancellationToken cancellationToken)
        {
            var debtor = new Debtor
            {
                UserId = request.UserID,
                DebtorName = request.DebtorName,
                DebtorObject = request.DebtorObject,
                Description = request.Description,
                Id = Guid.NewGuid(),
                CreationDate = DateTime.Now,
                EditDate = null,
                IsValied = true
            };

            await _dbContext.Debtors.AddAsync(debtor, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return debtor.Id;
        }
    }
}
