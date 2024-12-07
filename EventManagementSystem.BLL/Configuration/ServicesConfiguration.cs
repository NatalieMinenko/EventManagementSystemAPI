using EventManagementSystem.BLL.Interfaces;
using EventManagementSystem.DAL.Repositories;
using EventManagementSystem.DAL.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EventManagementSystem.BLL.Configuration;

public static class ServicesConfiguration
{
    public static void AddBllServices(this IServiceCollection services)
    {
        services.AddScoped<IUsersServices, UsersServices>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IEventsServices, EventsServices>();
        services.AddScoped<IEventRepository, EventRepository>();
    }
}
