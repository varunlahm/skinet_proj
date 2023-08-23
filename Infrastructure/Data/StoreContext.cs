
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucutre.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products{ get; set; }
    }
}