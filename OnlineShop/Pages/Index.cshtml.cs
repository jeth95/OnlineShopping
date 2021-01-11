using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OnlineShop.Models;
using OnlineShop.Services;
using OnlineShop.ViewModels;

namespace OnlineShop.Pages
{
    public class IndexModel : PageModel
    {
        readonly IMapper _mapper;
        
        readonly ILogger<IndexModel> _logger;
        
        readonly IProductService _productService;

        public IEnumerable<Category> Categories { get; set; }
        
        public IEnumerable<ProductViewModel> Products { get; set; }

        
        public IndexModel(ILogger<IndexModel> logger, IProductService productService, IMapper mapper)
        {
            _mapper = mapper ?? throw new System.ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            _productService = productService ?? throw new System.ArgumentNullException(nameof(productService));

            Products = new List<ProductViewModel>();
            Categories = new List<Category>();
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Products = _mapper.Map<IEnumerable<ProductViewModel>>(await _productService.GetProductsAsync());
            Categories = await _productService.GetCategoriesAsync();
            return Page();
        }
    }
}
