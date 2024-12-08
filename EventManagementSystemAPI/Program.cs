using FluentValidation.AspNetCore;
using FluentValidation;
using EventManagementSystemAPI.Configuration;
using EventManagementSystemAPI.Models.Requests.Validators;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using EventManagementSystem.BLL.Configuration;
using EventManagementSystem.DAL.Configuration;
using EventManagementSystem.BLL.ExceptionMiddleware;
using EventManagementSystem.BLL.Exceptions;
using Microsoft.AspNetCore.Builder;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
            .AddJsonFile("appsettings.secrets.json", optional: true, reloadOnChange: true)
            .AddCommandLine(args)
            .AddEnvironmentVariables()
            .Build();

        var configuration = builder.Configuration;

        builder.Services.AddApiServices();
        builder.Services.AddBllServices();
        builder.Services.AddDalServices(configuration);

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseMiddleware<ExceptionMiddleware>();

        app.MapControllers();

        app.Run();
    }
}