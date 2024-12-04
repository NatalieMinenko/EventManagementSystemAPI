using Microsoft.EntityFrameworkCore;
using EventManagementSystem.DAL.DTOs;

namespace EventManagementSystem.DAL;

public class Context : DbContext
{
    public DbSet<UserDto> Users { get; set; }
    public DbSet<EventDto> Events { get; set; }
    public DbSet<RegistrationDto> Registrations { get; set; }
    public Context()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //string connectionString = Options.ConnectionString;
        //optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("EventManagementSystemAPI"));
    }
}
