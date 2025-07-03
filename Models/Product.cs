using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce_MVC__11.Models
{
    public class Product
    {
        public int Id { get; set; }
    
        public string Name { get; set; }
        public int MyProperty { get; set; }
        public decimal Price { get; set; }

        public double Rate { get; set; }

        public int Quantity  { get; set; }
        public float Discount  { get; set; }
        public string? Image { get; set; }
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Categories{ get; set; }

    }
}
