using Microsoft.EntityFrameworkCore;
using EventManagementSystem.DAL.DTOs;

namespace EventManagementSystem.DAL;

public class Context : DbContext
{
    public DbSet<UserDto> Users { get; set; }
    public DbSet<UserRoleDto> UserRoles { get; set; }
    public DbSet<EventDto> Courses { get; set; }
    public DbSet<RegistrationDto> GradeBooks { get; set; }
    public Context()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("EventManagementSystemAPI"));
    }
}
