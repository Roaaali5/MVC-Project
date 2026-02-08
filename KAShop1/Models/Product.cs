using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace KAShop1.Models
{
    public class Product
    {
         public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        [MinLength(3)]
        public string Name { get; set; }
        [Range(0,10000)]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public double Rate { get; set; }
        public string? Image { get; set; }
        [Display(Name="Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }




    }
}
