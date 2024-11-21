using FluentValidation;

namespace EventManagementSystemAPI.Models.Requests.Validators;

public class UpdateEventRequestValidator : AbstractValidator<UpdateEventRequest>
{
    public UpdateEventRequestValidator()
    {
        RuleFor(model => model.Name).MaximumLength(60).MinimumLength(2);
        RuleFor(model => model.Description).MaximumLength(1000).MinimumLength(2);
    }
}
