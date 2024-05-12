using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemList
{
    public class cartItem
    {
        public String Name { get; set; }
        public int qty { get; set; }
        public int Price { get; set; }
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

        public void AddToCart(cartItem item)
        {
            cartItems.Add(item);
        }
    }

}
