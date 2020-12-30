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
        private readonly IMapper _mapper;
        private readonly ILogger<IndexModel> _logger;
        private readonly IProductService _productService;
        public IEnumerable<ProductViewModel> Products { get; set; }


        public IndexModel(ILogger<IndexModel> logger, IProductService productService, IMapper mapper)
        {
            _mapper = mapper ?? throw new System.ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            _productService = productService ?? throw new System.ArgumentNullException(nameof(productService));
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Products = _mapper.Map<IEnumerable<ProductViewModel>>(await _productService.GetProductsAsync());
            //Products = await _productService.GetProductsAsync();
            return Page();
        }
    }
}
