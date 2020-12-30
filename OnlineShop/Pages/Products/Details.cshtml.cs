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
using OnlineShop.ViewModels;

namespace OnlineShop.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly IProductService _productService;

        public DetailsModel( IProductService productService)
        {
            _productService = productService;
        }

        public Product Product { get; set; }

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

       
    }
}
