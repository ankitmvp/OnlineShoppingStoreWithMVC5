using OnlineShoppingStore.Domain.Entities;
using System.Collections.Generic;

namespace OnlineShoppingStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
