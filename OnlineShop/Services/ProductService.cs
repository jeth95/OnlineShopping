using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Models;
using OnlineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public class ProductService : IProductService
    {
        private readonly OnlineShopContext _repository;

        public ProductService(OnlineShopContext repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public async Task UpdateProductAsync(Product product)
        {
            _repository.Attach(product).State = EntityState.Modified;

            await _repository.SaveChangesAsync();

        }
        public async Task<Product> GetProductAsync(int? id)
        {
            return await _repository.Products.Include(p => p.Images).FirstOrDefaultAsync(p => p.ProductId == id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _repository.Products.Include(p => p.Images).ToListAsync();
        }
        public bool ProductExists(int id)
        {
            return _repository.Products.Any(p => p.ProductId == id);
        }

        public async Task RemoveProductAsync(Product product)
        {
            _repository.Remove(product);
            await _repository.SaveChangesAsync();
        }

        public async Task AddProductAsync(Product product)
        {
            _repository.Add(product);
            await _repository.SaveChangesAsync();
        }

        //public ProductDetailsViewModel MapProductToViewModel(Product product)
        //{
        //    return new ProductDetailsViewModel
        //    {
        //        Id = product.Id,
        //        Name = product.Name,
        //        Price = product.Price,
        //        OldPrice = product.OldPrice,
        //        Category = product.Category,
        //        Description = product.Description,
        //        Images = product.Images.Split(";"),
        //    };
        //}

        //public List<ProductDetailsViewModel> MapProductsToViewModel(List<Product> products)
        //{
        //    var _products = new List<ProductDetailsViewModel>();

        //    foreach (var product in products)
        //    {
        //       _products.Add(MapProductToViewModel(product));
        //    }

        //    return _products;
        //}
    }
}