using Microsoft.EntityFrameworkCore;
using NetCoreAI.Project1_ApiDemo.Entities;

namespace NetCoreAI.Project1_ApiDemo.Context
{
    public class NetCoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=NetCoreAI;User Id=SA;Password=S1611n2301T;TrustServerCertificate=True");
        }

        public DbSet<Customer> Customers { get; set; }     
    }
}
