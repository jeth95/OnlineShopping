using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public interface IProductService
    {
        bool ProductExists(int id);
        Task AddProductAsync(Product product);
        Task<Product> GetProductAsync(int? id);
        Task<Category> GetCategoryAsync(int? id);
        Task UpdateProductAsync(Product product);
        Task RemoveProductAsync(Product product);
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<IEnumerable<Category>> GetCategoriesAsync();

    }
}
