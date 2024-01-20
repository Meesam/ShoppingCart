﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Product : DateTimeClass
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product title is required.")]
        [MinLength(5)]
        [MaxLength(150)]
        public string ProductTitle { get; set; } = string.Empty;

        [Required(ErrorMessage = "Product price is required.")]
        public double ProductPrice { get; set; }

        [Required(ErrorMessage = "Product description is required")]
        [MinLength(5)]
        public string ProductDescription { get; set; } = string.Empty;
    }
}
