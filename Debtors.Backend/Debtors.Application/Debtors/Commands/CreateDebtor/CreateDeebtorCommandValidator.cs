using Debtors.Application.Debtors.Commands.CreateDebtors;
using FluentValidation;

namespace Debtors.Application.Debtors.Commands.CreateDebtor
{
    public class CreateDeebtorCommandValidator: AbstractValidator<CreateDebtorCommand>
    {
        public CreateDeebtorCommandValidator()
        {
            RuleFor(debtorCommand => debtorCommand.UserID).NotEqual(Guid.Empty);
            RuleFor(debtorCommand => debtorCommand.DebtorName).NotEmpty().MaximumLength(100);
            RuleFor(debtorCommand => debtorCommand.DebtorObject).NotEmpty().MaximumLength(100);
            RuleFor(debtorCommand => debtorCommand.Description).MaximumLength(250);
        }
    }
}
