using LaptopStore.Data.Interfaces;
using LaptopStore.Data.Models;
using System;
using System.Linq;

namespace LaptopStore.Data.Repository
{
    public class OrderRepository : IOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly Cart cart;

        public OrderRepository(AppDBContent appDBContent, Cart cart)
        {
            this.appDBContent = appDBContent;
            this.cart = cart;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            //Order lastOrder = appDBContent.Order.OrderByDescending(x => x.id).ToList().LastOrDefault();
           // order.id = lastOrder != null ? lastOrder.id + 1 : 1;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();

            var items = cart.ListCartItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    laptopId = el.laptop.id,
                    orderId = order.id,
                    price = el.laptop.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
