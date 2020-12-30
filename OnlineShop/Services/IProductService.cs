using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public interface IProductService
    {
        Task<Product> GetProductAsync(int? id);
        Task<IEnumerable<Product>> GetProductsAsync();
        bool ProductExists(int id);
        Task UpdateProductAsync(Product product);
        Task RemoveProductAsync(Product product);

        Task AddProductAsync(Product product);
    }
}
