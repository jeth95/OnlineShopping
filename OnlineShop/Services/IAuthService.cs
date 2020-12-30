using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public interface IAuthService
    {
        Task Login (string email, string password);
    }
}
