namespace MyEshop.Models
{
    public class Item
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }


        //Navigation property
        public Product Product { get; set; }
    }
}
