using Microsoft.EntityFrameworkCore;

namespace hwsqlite.Sample
{
    
    public class eCommerceDbContext : DbContext
    {
        
        #region Properties
        public DbSet<Product> Products {get; set;}
        #endregion
        
        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=./ecommerce.db");
        }
        #endregion
    }
}