using Microsoft.EntityFrameworkCore;
using VehicleInsurance.Models;

namespace VehicleInsurance.Data
{
    public class InsuranceDbContext : DbContext
    {
        public InsuranceDbContext(DbContextOptions<InsuranceDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Models.Insurance> Insurances { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Estimate> Estimates { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
