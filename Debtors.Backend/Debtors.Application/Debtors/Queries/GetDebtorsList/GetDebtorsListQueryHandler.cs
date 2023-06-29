using AutoMapper;
using AutoMapper.QueryableExtensions;
using Debtors.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.Application.Debtors.Queries.GetDebtorsList
{
    public class GetDebtorsListQueryHandler : IRequestHandler<GetDebtorsListQuery, DebtorsListVm>
    {
        private readonly IDebtorsDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetDebtorsListQueryHandler(IMapper mapper, IDebtorsDbContext dbContext)
        {
            _mapper = mapper;   
            _dbContext = dbContext;
        }

        public async Task<DebtorsListVm> Handle(GetDebtorsListQuery request, CancellationToken cancellationToken)
        {
            var entities = await _dbContext.Debtors
                .Where(debtor => debtor.UserId == request.UserId)
                .Where(debtor => debtor.IsValied)
                .ProjectTo<DebtorLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new DebtorsListVm {Debtors = entities};
        }
    }
}
