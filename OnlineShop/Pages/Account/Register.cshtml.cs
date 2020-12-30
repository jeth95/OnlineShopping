using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Models;
using OnlineShop.Services;

namespace OnlineShop.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService _userService;
        
        public RegisterModel(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }
        [BindProperty]
        public new User User { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _userService.AddUserAsync(User);
            return RedirectToPage("../Index");
        }
        
    }
  
}
