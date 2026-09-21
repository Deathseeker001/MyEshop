namespace MyEshop.Models
{
    public class CategoryToProduct
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        //Navigation property 
        public Category Category { get; set; }
        public Product Product { get; set; }
    }
}
