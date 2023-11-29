using EFCoreMigrations.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EFCoreMigrations.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Passport> Passports { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Post> Posts { get; set; }


}
