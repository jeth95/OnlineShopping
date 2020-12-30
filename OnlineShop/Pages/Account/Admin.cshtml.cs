using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Models;
using OnlineShop.Services;
using OnlineShop.ViewModels;

namespace OnlineShop.Pages.Account
{
    public class AdminModel : PageModel
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        public IEnumerable<Product> Products { get; set; }

        public AdminModel(IProductService productService, IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Products = await _productService.GetProductsAsync();
            return Page();
        }
      
    }
}
