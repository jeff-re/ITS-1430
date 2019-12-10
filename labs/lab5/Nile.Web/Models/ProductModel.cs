using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nile.Web.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required (AllowEmptyStrings = false)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range (0, Int32.MaxValue, ErrorMessage = "price must be >= 0")]
        public decimal Price { get; set; } = 0;

        public bool IsDiscontinued { get; set; }
    }
}