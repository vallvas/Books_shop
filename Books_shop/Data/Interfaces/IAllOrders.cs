using Books_shop.Data.Models;

namespace Books_shop.Data.Interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
