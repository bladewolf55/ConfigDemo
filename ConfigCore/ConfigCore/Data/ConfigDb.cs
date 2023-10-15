using Microsoft.EntityFrameworkCore;

namespace ConfigFramework.Data;

public class ConfigDb: DbContext
{
    public DbSet<Customer> Customers { get; set; }

    public ConfigDb(DbContextOptions options) : base(options) { }
}