using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public interface IUserService
    {
        Task<User> GetUserAsync(int? id);

        Task AddUserAsync(User user);
    }
}
