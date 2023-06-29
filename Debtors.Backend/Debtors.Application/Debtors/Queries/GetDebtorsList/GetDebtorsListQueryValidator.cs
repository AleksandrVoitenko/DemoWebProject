
using FluentValidation;

namespace Debtors.Application.Debtors.Queries.GetDebtorsList
{
    public class GetDebtorsListQueryValidator : AbstractValidator<GetDebtorsListQuery>
    {
        public GetDebtorsListQueryValidator() 
        {
            RuleFor(debtorQuery => debtorQuery.UserId).NotEqual(Guid.Empty);
        }
    }
}
