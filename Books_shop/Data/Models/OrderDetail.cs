namespace Books_shop.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int bookID { get; set; }
        public uint price { get; set; }
        public virtual Book books { get; set; }
        public virtual Order order { get; set; }
    }
}
