using Books_shop.Data.Interfaces;
using Books_shop.Data.Models;
using System;

namespace Books_shop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;
        
        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }
       
        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();
          
            var items = shopCart.listShopItems;
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    bookID = el.book.id,
                    orderID = order.id,
                    price = el.book.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }

}
 