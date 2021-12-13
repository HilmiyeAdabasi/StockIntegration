using Microsoft.EntityFrameworkCore;
using StockIntegration.Entity;

namespace StockIntegration.DataAccess
{
    public class StockDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.; Database=StockIntegration; Trusted_Connection=True; MultipleActiveResultSets=true");
        }
        public DbSet<Stock> Stocks { get; set; }
    }
}
