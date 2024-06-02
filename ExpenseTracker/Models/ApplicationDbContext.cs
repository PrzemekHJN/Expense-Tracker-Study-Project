using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Models
{


    public class ApplicationDbContext: DbContext
    {
        public IConfiguration _config {  get; set; }
        public ApplicationDbContext(IConfiguration config)
        {
            _config = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }

        // public ApplicationDbContext(DbContextOptions options):base(options)
        // {           
        // }

    }
}
