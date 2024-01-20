using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Order : DateTimeClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string OrderStatus { get; set; } = string.Empty;
    }
}
