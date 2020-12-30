using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public class UserService : IUserService
    {
        private readonly OnlineShopContext _repository;

        public UserService(OnlineShopContext repository) 
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
                
        }

        public async Task<User> GetUserAsync(int? id)
        {
            return await _repository.Users.FirstOrDefaultAsync(user => user.UserId == id);
        }

        public async Task AddUserAsync(User user)
        {
            _repository.Add(user);
            await _repository.SaveChangesAsync();
        }
    }
}
