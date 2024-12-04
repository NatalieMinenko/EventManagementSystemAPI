using FluentValidation;

namespace EventManagementSystemAPI.Models.Requests.Validators;

public class UpdateEventRequestValidator : AbstractValidator<UpdateEventRequest>
{
    public UpdateEventRequestValidator()
    {
        RuleFor(model => model.Name).MaximumLength(60).MinimumLength(2);
        RuleFor(model => model.Description).MaximumLength(1000).MinimumLength(2);
        RuleFor(model => model.DateTime).GreaterThan(DateTime.UtcNow).WithMessage("Time-travellers are not allowed").NotEmpty().WithMessage("DateTime field is required");
        RuleFor(model => model.AddressOfEvent).MaximumLength(100).MinimumLength(8);
        RuleFor(model => model.MaxParticipants).GreaterThan(1);
    }
}
