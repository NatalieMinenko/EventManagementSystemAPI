using FluentValidation;
using System.Reflection;

namespace EventManagementSystemAPI.Models.Requests.Validators;

public class UpdateUserRequestValidator : AbstractValidator<UpdateUserRequest>
{
    public UpdateUserRequestValidator()
    {
        RuleFor(model => model.FirstName).MaximumLength(50).MinimumLength(2);
        RuleFor(model => model.LastName).MaximumLength(50).MinimumLength(2);
        RuleFor(model => model.Email).EmailAddress();
        RuleFor(model => model.Phone).MaximumLength(25).MinimumLength(8);
    }
}
