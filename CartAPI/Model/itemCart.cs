namespace CartAPI.Model
{
    public class itemCart
    {
        public int Id { get; set; } 
        public int itemId { get; set; }
        public string Name { get; set; }
        public int qty { get; set; }
        public int Price { get; set; }

        public int userId { get; set; }

        public itemCart(int Id, int itemId,string Name, int qty, int Price, int userId)
        {
            this.Id = Id;
            this.itemId = itemId;
            this.Name = Name;
            this.qty = qty;
            this.Price = Price;
            this.userId = userId;
        }
    }
}
