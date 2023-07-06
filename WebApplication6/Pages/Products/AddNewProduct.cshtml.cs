using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Emit;
using WebApplication6.Data;
using WebApplication6.Model;

namespace WebApplication6.Pages.Products
{
    public class AddNewProductModel : PageModel
    {
        private readonly ProductDBContext _dbContext;
        public ProductList ProductList { get; set; }
        public AddNewProductModel(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Onpost(ProductList productList)
        {
            if(productList.ProductName == null)
            {
                ModelState.AddModelError("ProductList.ProductName","" );
            }
            if (productList.ProductDetails == null)
            {
                ModelState.AddModelError("productList.ProductDetails","");
            }
            if (productList.ProductQty == null)
            {
                ModelState.AddModelError(string.Empty, "Product QTY can't be Empty");
            }

            if (ModelState.IsValid)
            {
                await _dbContext.Products.AddAsync(productList);
                await _dbContext.SaveChangesAsync();
                return RedirectToPage("Index");
               
            }
            return Page();
        }
        public void OnGet()
        {
        }
    }
}
