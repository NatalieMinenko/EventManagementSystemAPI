using FluentValidation;

namespace EventManagementSystemAPI.Models.Requests.Validators;
public class UpdatePasswordRequestValidator : AbstractValidator<UpdatePasswordRequest>
{
    public UpdatePasswordRequestValidator()
    {
        RuleFor(model => model.Password).MaximumLength(16).MinimumLength(8);
        RuleFor(model => model.NewPassword).MaximumLength(16).MinimumLength(8);
    }
}
