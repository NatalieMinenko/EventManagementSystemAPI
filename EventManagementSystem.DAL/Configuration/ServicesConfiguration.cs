using EventManagementSystem.DAL.Repositories.Interfaces;
using EventManagementSystem.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace EventManagementSystem.DAL.Configuration;

public static class ServicesConfiguration
{
    public static void AddDalServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<Context>(options => options.UseNpgsql(configuration.GetConnectionString("EventManagementSystemDBConnect")));
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IEventRepository, EventRepository>();
        services.AddScoped<IRegisterRepository, RegisterRepository>();
    }
}
