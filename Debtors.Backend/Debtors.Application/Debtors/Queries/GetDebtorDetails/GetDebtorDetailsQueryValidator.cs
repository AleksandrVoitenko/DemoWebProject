using FluentValidation;

namespace Debtors.Application.Debtors.Queries.GetDebtorDetails
{
    public class GetDebtorDetailsQueryValidator : AbstractValidator<GetDebtorDetailsQuery>
    {
        public GetDebtorDetailsQueryValidator() 
        {
            RuleFor(debtorQuery => debtorQuery.Id).NotEqual(Guid.Empty);
            RuleFor(debtorQuery => debtorQuery.UserId).NotEqual(Guid.Empty);
        }
    }
}
