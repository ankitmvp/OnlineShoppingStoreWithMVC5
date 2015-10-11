using OnlineShoppingStore.Domain.Entities;

namespace OnlineShoppingStore.Domain.Abstract
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Cart cart, ShippingDetails shippingDetails);
    }
}
