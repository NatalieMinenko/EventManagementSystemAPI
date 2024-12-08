using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using FluentValidation.AspNetCore;
using EventManagementSystemAPI.Models.Requests.Validators;

namespace EventManagementSystemAPI.Configuration;

public static class ServicesConfiguration
{
    public static void AddApiServices(this IServiceCollection services)
    {
        services.AddAuthentication();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddFluentValidationAutoValidation();
        services.AddValidatorsFromAssemblyContaining<RegisterUserRequestValidator>();
    }
}
