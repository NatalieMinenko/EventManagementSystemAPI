using EventManagementSystem.BLL.Interfaces;
using EventManagementSystem.DAL;
using EventManagementSystem.DAL.Repositories;
using EventManagementSystem.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EventManagementSystem.BLL.Configuration;

public static class ServicesConfiguration
{
    public static void AddBllServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<Context>(options => options.UseNpgsql(configuration.GetConnectionString("EventManagementSystemDBConnect")));
        services.AddScoped<IUsersServices, UsersServices>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IEventsServices, EventsServices>();
        services.AddScoped<IEventRepository, EventRepository>();
        //services.AddScoped<IRegisterServices, RegisterServices>();
        services.AddScoped<IRegisterRepository, RegisterRepository>();
    }
}
