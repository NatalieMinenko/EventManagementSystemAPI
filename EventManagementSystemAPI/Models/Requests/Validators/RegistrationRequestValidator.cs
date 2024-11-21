using FluentValidation;

namespace EventManagementSystemAPI.Models.Requests.Validators;

public class RegistrationRequestValidator : AbstractValidator<RegistrationRequest>
{
    public RegistrationRequestValidator()
    {
        RuleFor(model => model.UserId).NotNull();
        RuleFor(model => model.EventId).NotNull();
    }
}
