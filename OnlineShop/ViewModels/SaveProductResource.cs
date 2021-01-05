using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.ViewModels
{
    public class SaveProductResource
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public float Price { get; set; }

        public float? OldPrice { get; set; }

        [Required]
        public string CategoryId { get; set; }

        [Required]
        public string Description { get; set; }

        [Display(Name="Add Images")]
        public IFormFile [] Images { get; set; }
    }
}
