using FluentValidation;

namespace Debtors.Application.Debtors.Commands.ClearDebtorsTrash
{
    public class ClearDebtorsTrashCommandValidator : AbstractValidator<ClearDebtorsTrashCommand>
    {
        public ClearDebtorsTrashCommandValidator() 
        {
            RuleFor(debtorCommand => debtorCommand.UserId).NotEqual(Guid.Empty);
        }
    }
}
