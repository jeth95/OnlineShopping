using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public class AuthService : IAuthService
    {
        private readonly OnlineShopContext _context;

        public AuthService (OnlineShopContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task Login (string email, string password)
        {
            var user = await _context.Users.Where(u => u.Email == email).SingleAsync();

            if(user == null || user.Password != password)
            {
                // Throw error - No matching user
                throw new Exception("No user with matching email and password.");
            }

            return;
        }
    }
}
