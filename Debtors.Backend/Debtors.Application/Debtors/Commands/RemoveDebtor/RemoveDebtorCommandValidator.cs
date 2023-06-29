using FluentValidation;

namespace Debtors.Application.Debtors.Commands.RemoveDebtor
{
    public class RemoveDebtorCommandValidator : AbstractValidator<RemoveDebtorCommand>
    {
        public RemoveDebtorCommandValidator()
        {
            RuleFor(debtorCommand => debtorCommand.Id).NotEqual(Guid.Empty);
            RuleFor(debtorCommand => debtorCommand.UserId).NotEqual(Guid.Empty);
        }
    }
}
