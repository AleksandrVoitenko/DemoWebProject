using FluentValidation;

namespace Debtors.Application.Debtors.Commands.EditDebtor
{
    public class EditDebtorCommandValidator : AbstractValidator<EditDebtorCommand>
    {
        public EditDebtorCommandValidator()
        {
            RuleFor(debtorCommand => debtorCommand.Id).NotEqual(Guid.Empty);
            RuleFor(debtorCommand => debtorCommand.UserId).NotEqual(Guid.Empty);
            RuleFor(debtorCommand => debtorCommand.DebtorName).NotEmpty().MaximumLength(100);
            RuleFor(debtorCommand => debtorCommand.DebtorObject).NotEmpty().MaximumLength(100);
            RuleFor(debtorCommand => debtorCommand.Description).MaximumLength(250);
        }
    }
}
