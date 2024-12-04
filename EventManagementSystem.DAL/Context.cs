using Microsoft.EntityFrameworkCore;
using EventManagementSystem.DAL.Configurations;
using EventManagementSystem.DAL.DTOs;
using EventManagementSystem.DAL.Repositories;

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
        optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("EventManagementSystemAPI"));
    }
}
