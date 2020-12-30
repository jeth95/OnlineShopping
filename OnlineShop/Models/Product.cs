using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public float Price { get; set; }

        public float OldPrice { get; set; }

        [Required]
        public string Category { get; set; }
        
        [Required]
        public string Description { get; set; }

        public ICollection<Image> Images { get; set; }

        public Product ()
        {
            Images = new List<Image>();
        }
    }
}
