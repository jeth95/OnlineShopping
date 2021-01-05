using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using OnlineShop.Services;
using OnlineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.ViewComponents
{
    [ViewComponent(Name = "CategoryTab")]

    public class CategoryTab: ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public CategoryTab(IProductService productService, IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return View(new ProductViewModel { ProductId = id});
            //return View(_mapper.Map<ProductViewModel>(products));
        }

    }
}
