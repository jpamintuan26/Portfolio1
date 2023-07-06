using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication6.Data;
using WebApplication6.Migrations;
using WebApplication6.Model;

namespace WebApplication6.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ProductDBContext _dbContext;
        public IEnumerable<ProductList> Products { get; set; }
       
        public IndexModel(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void OnGet()
        {
            Products = _dbContext.Products;
        }
    }
}
