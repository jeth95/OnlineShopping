using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Models;
using OnlineShop.Services;
using OnlineShop.ViewModels;

namespace OnlineShop.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        private float price;
        
        [BindProperty]
        public Product Product { get; set; }

        public EditModel(IProductService productService, IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }



        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _productService.GetProductAsync(id);
            price = Product.Price;

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {

                if(price != Product.Price)
                {
                    Product.OldPrice = price;
                }

                await _productService.UpdateProductAsync(Product);
            } catch (DbUpdateConcurrencyException)
            {
                if (!_productService.ProductExists(Product.ProductId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("../Account/Admin");
        }


    }
}
