using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalesUp.Data.Concrete.Configs;
using SalesUp.Data.Extensions;
using SalesUp.Entity;
using SalesUp.Entity.Identity;
using Task = System.Threading.Tasks.Task;

namespace SalesUp.Data.Concrete.Contexts;

public class SalesUpDbContext:IdentityDbContext<User, Role, string>
{
    public SalesUpDbContext(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Entity.Task> Tasks { get; set; }
    public DbSet<TaskItem> TaskItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.SeedData();
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerConfig).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}


