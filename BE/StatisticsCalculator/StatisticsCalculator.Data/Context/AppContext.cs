using StatisticsCalculator.Data.Models;
using System.Data.Entity;

namespace StatisticsCalculator.Data.Context
{
    public class AppContext : DbContext
    {
        public AppContext() : base("StatisticsCalculatorDB")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Document> Documents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
