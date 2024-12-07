using Microsoft.EntityFrameworkCore;
using EventManagementSystem.DAL.DTOs;
using Microsoft.Extensions.Configuration;

namespace EventManagementSystem.DAL;

public class Context : DbContext
{
    public DbSet<UserDto> Users { get; set; }
    public DbSet<EventDto> Events { get; set; }
    public DbSet<RegistrationDto> Registrations { get; set; }
    public Context(DbContextOptions<Context> opts) : base(opts)
    { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Database.EnsureCreated();
        //string connectionString = Options.ConnectionString;
        //optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("EventManagementSystemAPI"));
    }
}
