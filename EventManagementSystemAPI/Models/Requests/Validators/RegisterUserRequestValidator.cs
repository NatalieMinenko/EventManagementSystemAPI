using FluentValidation;

namespace EventManagementSystemAPI.Models.Requests.Validators;

public class RegisterUserRequestValidator : AbstractValidator<RegisterUserRequest>
{
    public RegisterUserRequestValidator()
    { 
        RuleFor(model => model.FirstName).MaximumLength(50).MinimumLength(2);
        RuleFor(model => model.LastName).MaximumLength(50).MinimumLength(2);
        RuleFor(model => model.Email).EmailAddress();
        RuleFor(model => model.Password).MinimumLength(8);
        RuleFor(model => model.Phone).MaximumLength(16).MinimumLength(8);
    }
}
