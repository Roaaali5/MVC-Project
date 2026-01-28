using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KAShop1.Models
{
    public class Category
    {
        
        public int Id { get; set; }
        [Column("varchar(50)")]
        [MaxLength(50)]
        [MinLength(3)]
        [Required]
        public string Name { get; set; }
    }
}
