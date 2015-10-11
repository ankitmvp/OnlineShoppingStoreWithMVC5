using OnlineShoppingStore.Domain.Entities;
using System.Collections.Generic;

namespace OnlineShoppingStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        void SaveProduct(Product product);
        Product DeleteProduct(int productId);
    }
}
