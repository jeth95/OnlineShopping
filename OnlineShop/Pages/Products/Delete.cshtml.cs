using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Models;
using OnlineShop.Services;

namespace OnlineShop.Pages.Products
{
    public class DeleteModel : PageModel
    {
        private readonly IProductService _productService;

        [BindProperty]
        public Product Product { get; set; }

        public DeleteModel(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _productService.GetProductAsync(id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _productService.GetProductAsync(id);

            if (Product != null)
            {
                await _productService.RemoveProductAsync(Product);
            }

            return RedirectToPage("../Account/Admin");
        }
    }
}
