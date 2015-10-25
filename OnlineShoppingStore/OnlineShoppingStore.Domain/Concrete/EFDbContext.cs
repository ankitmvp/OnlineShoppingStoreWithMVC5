using OnlineShoppingStore.Domain.Entities;
using System.Data.Entity;

namespace OnlineShoppingStore.Domain.Concrete
{
    class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
