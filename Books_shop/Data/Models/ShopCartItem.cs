namespace Books_shop.Data.Models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public Book book { get; set; }
        public int price { get; set; }
        public string ShopCartId { get; set; }
    }
}
