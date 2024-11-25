using FluentValidation;

namespace EventManagementSystemAPI.Models.Requests.Validators;

public class CreateEventRequestValidator : AbstractValidator<CreateEventRequest>
{
    public CreateEventRequestValidator()
    {
        //Date? - DateTime
        RuleFor(model => model.Name).MaximumLength(60).MinimumLength(2);
        RuleFor(model => model.Description).MaximumLength(1000).MinimumLength(2);
        RuleFor(model => model.Date).GreaterThan(DateTime.UtcNow).WithMessage("Time-travellers are not allowed");
        RuleFor(model => model.AdressOfEvent).MaximumLength(100).MinimumLength(8);
        RuleFor(model => model.NumberOfParticipants).GreaterThan(1);
    }
}

