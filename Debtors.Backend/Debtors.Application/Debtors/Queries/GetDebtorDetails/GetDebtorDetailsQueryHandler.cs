using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Debtors.Application.Interfaces;
using Debtors.Application.Common.Exceptions;


namespace Debtors.Application.Debtors.Queries.GetDebtorDetails
{
    public class GetDebtorDetailsQueryHandler : IRequestHandler<GetDebtorDetailsQuery, DebtorDetailsVm>
    {
        private readonly IDebtorsDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetDebtorDetailsQueryHandler(IDebtorsDbContext dbContext, IMapper mapper) 
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<DebtorDetailsVm> Handle(GetDebtorDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Debtors
                .FirstOrDefaultAsync(debtor => debtor.Id == request.Id, cancellationToken);

            if(entity == null || entity.UserId != request.UserId)
            {
                throw new NotFoundException(nameof(entity), request.Id);
            }

            return _mapper.Map<DebtorDetailsVm>(entity);
        }
    }
}
