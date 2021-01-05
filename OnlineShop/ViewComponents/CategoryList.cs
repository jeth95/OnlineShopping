using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using OnlineShop.Models;
using OnlineShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.ViewComponents
{
    [ViewComponent(Name = "CategoryList")]
    public class CategoryList: ViewComponent
    {
        private readonly IMemoryCache _cache;
        private readonly IProductService _productService;
        
        public CategoryList(IMemoryCache cache, IProductService productService)
        {
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = _cache.Get("categories");

            if(categories == null)
            {
                categories = await _productService.GetCategoriesAsync();
                
                using var cacheEntry = _cache.CreateEntry("categories");
                _cache.Set(cacheEntry, categories);
            }
            return View(categories);
        }
    }
}
