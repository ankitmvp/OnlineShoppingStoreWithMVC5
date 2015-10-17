using OnlineShoppingStore.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.Core.Common;

namespace OnlineShoppingStore.Domain.Concrete
{
    class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
