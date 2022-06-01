using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LaptopStore.Data.Models
{
    public class Cart
    {
        private readonly AppDBContent appDBContent;
        public Cart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string CartId { get; set; }
        public List<CartItem> ListCartItems { get; set; }
        public int itemsCount { get; set; }

        public static Cart getCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session; //new session creating
            var context = services.GetService<AppDBContent>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);
            return new Cart(context) { CartId = cartId };
        }

        public void addToCart(Laptop laptop)
        {
            this.appDBContent.CartItem.Add(new CartItem { CartId = CartId, laptop = laptop, price = laptop.price });
            this.appDBContent.SaveChanges();
        }

        public void deleteFromCart(CartItem cartItem)
        {
            this.appDBContent.CartItem.Remove(cartItem);
            this.appDBContent.SaveChanges();
        }

        public List<CartItem> getCartItems()
        {
            return this.appDBContent.CartItem.Where(c => c.CartId == CartId).Include(s => s.laptop).ToList();
        }
    }
}
