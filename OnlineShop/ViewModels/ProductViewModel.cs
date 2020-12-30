using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.ViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float OldPrice { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public bool IsNew => OldPrice == 0;
        public float Discount => OldPrice /(OldPrice - Price);

        public ICollection<Image> Images { get; set; }

        public ProductViewModel ()
        {
            Images = new List<Image>();
        }
    }
}
