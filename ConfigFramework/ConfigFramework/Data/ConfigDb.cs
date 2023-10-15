using System.Data.Entity;

namespace ConfigFramework.Data
{
    public class ConfigDb: DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public ConfigDb(): base("name=ConfigDb") { }

    }
}