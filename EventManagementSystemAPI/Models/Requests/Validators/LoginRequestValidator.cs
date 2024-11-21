using FluentValidation;

namespace EventManagementSystemAPI.Models.Requests.Validators;

public class LoginRequestValidator : AbstractValidator<LoginRequest>
{
    public LoginRequestValidator() 
    {
        RuleFor(model => model.Email).EmailAddress();
        RuleFor(model => model.Password).MaximumLength(16).MinimumLength(8);
    }
}

