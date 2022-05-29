namespace LaptopStore.Data.Models
{
    public class CartItem
    {
        public int id { get; set; }
        public Laptop laptop { get; set; }
        public int price { get; set; }
        public string CartId { get; set; }
    }
}
