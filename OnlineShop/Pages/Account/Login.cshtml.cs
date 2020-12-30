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
    [BindProperties]
    public class LoginModel : PageModel
    {
        private readonly IAuthService _authService;

        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Error { get; set; }


        public LoginModel (IAuthService authService)
        {
            _authService = authService ?? throw new ArgumentNullException(nameof(authService));
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync ()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                await _authService.Login(EmailAddress, Password);
            }
            catch (Exception e)
            {
                Error = e.Message;
                return Page();
            }

            return RedirectToPage("../Index");
        }
    }
}
