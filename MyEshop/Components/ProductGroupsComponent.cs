using Microsoft.AspNetCore.Mvc;
using MyEshop.Data;
using MyEshop.Models;

namespace MyEshop.Components
{
    public class ProductGroupsComponent : ViewComponent
    {
        private MyEshopContext _context;
        public ProductGroupsComponent(MyEshopContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = _context.Categories
                .Select(c => new ShowGroupViewModel()
                {
                    GroupId = c.Id,
                    Name = c.Name,
                    ProductCount = _context.CategoryToProducts.Count(g => g.CategoryId == c.Id)
                }).ToList();
            return View("/Views/Components/ProductGroupsComponent.cshtml", categories);
        }
    }
}
