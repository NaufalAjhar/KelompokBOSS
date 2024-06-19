using System;
using System.Collections.Generic;

namespace itemList
{
    public class cartItem
    {
        public int Id { get; set; }
        public int itemId { get; set; }
        public string Name { get; set; }
        public int qty { get; set; }
        public int Price { get; set; }

        public int UserId { get; set; }
    }
    public class CartManager
    {
        private List<cartItem> cartItems;

        public CartManager()
        {
            cartItems = new List<cartItem>();
        }

        public List<cartItem> GetItems()
        {
            return cartItems;
        }

        public void AddToCart(cartItem item, int userId)
        {
            item.UserId = userId; 
            cartItems.Add(item);
        }

        public void Clear()
        {
            cartItems.Clear();
        }
    }
}