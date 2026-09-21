using System.ComponentModel.DataAnnotations;

namespace MyEshop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Navigation property
        public ICollection<CategoryToProduct> CategoryToProducts { get; set; }

    }
}
