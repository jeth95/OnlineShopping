using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }

        public string Name { get; set; }

        // Image name before adding guid
        public string Alt { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
