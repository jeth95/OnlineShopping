using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting.Internal;
using OnlineShop.Data;
using OnlineShop.Models;
using OnlineShop.Services;
using OnlineShop.ViewModels;

namespace OnlineShop.Pages.Products
{
    public class AddModel : PageModel
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public AddModel(IProductService productService, IWebHostEnvironment hostingEnvironment, IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _hostingEnvironment = hostingEnvironment ?? throw new ArgumentNullException(nameof(hostingEnvironment));
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SaveProductResource Product { get; set; }


        //To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync ()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Product.Images != null && Product.Images.Length > 0)
            {
                Image image;
                Product newProduct = _mapper.Map<Product>(Product);
                IFormFile currentFile;

                // Upload images
                for (int index = 0; index < Product.Images.Length; index++)
                {
                    currentFile = Product.Images[index];
                    image = new Image
                    {
                        Alt = currentFile.FileName,
                        Name = GetUniqueName(currentFile.FileName)
                    };

                    // Add image to product
                    newProduct.Images.Add(image);

                    // Upload image
                    UploadImage(currentFile, image.Name);
                }

                // Add to DB
                await _productService.AddProductAsync(newProduct);

                return RedirectToPage("../Index");
            }
            return Page();
        }


        private string GetUniqueName(string fileName) { 
            return Guid.NewGuid().ToString() + "_" + fileName;
        }


        private void UploadImage(IFormFile image, string uniqueName)
        {
            string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "img");

            using var stream = new FileStream(Path.Combine(uploadsFolder, uniqueName), FileMode.Create);
            image.CopyTo(stream);
        }
    }
}
